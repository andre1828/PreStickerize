using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreStickerize_Interface
{
    public partial class ApplicationInterface : Form
    {
        OpenFileDialog fileDialog;
        string folder = string.Empty;
        public ApplicationInterface()
        {
            InitializeComponent();
        }

        private void Sourcebutton_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";  //"JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            fileDialog.ShowDialog();

            for (int i = 0; i < fileDialog.FileNames.Length; i++)
            {
                imagesList.Items.Add
                (
                    new ListViewItem(new string[] { Path.GetFileName(fileDialog.FileNames[i]), "Ready" })
                );
                imagesList.Items[i].Name = Path.GetFileName(fileDialog.FileNames[i]);
            }

        }


        private void Destinationbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                DestinationTextBox.Text = folderBrowser.SelectedPath;
                folder = folderBrowser.SelectedPath;
            }

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            //If no files were selected or the user did not click the "Load" button
            if (fileDialog == null || fileDialog.FileNames.Length == 0) return;

            if (folder == string.Empty)
            {
                MessageBox.Show("Please select a destination folder ");
                return;
            }

            Conversion conversion = new Conversion();

            int numberOfFiles = fileDialog.FileNames.Length;

            Thread backgroundProcess = new Thread(() =>
            {

                Parallel.ForEach(fileDialog.FileNames, (file) =>
                {
                    Image fileImage = Image.FromFile(file);
                    
                    //Gets file length
                    int fileSize = (int)new FileInfo(file).Length;

                    if (fileSize > 358573) // if image is 350kb  => compress
                    {
                        Image compressedImage = Compression.compress(conversion.imageProcessor(fileImage));

                        compressedImage.Save(folder + "\\" + Path.GetFileNameWithoutExtension(file) + "_PreStickerized.png", ImageFormat.Png);

                        this.Invoke(new Action(
                            delegate
                            {
                                imagesList.Items.Find(Path.GetFileName(file), false)[0].SubItems[1].Text = "Done";
                            }));

                    }
                    else
                    {
                        conversion.imageProcessor(fileImage).Save(folder + "\\" + Path.GetFileNameWithoutExtension(file) + "_PreStickerized.png", ImageFormat.Png);

                        this.Invoke(new Action(
                            delegate
                            {

                                imagesList.Items.Find(Path.GetFileName(file), false)[0].SubItems[1].Text = "Done";
                            }));

                    }

                });

                DialogResult openFolderDialog = MessageBox.Show("Open folder with files?", "Done :D", MessageBoxButtons.YesNo);

                if (openFolderDialog == DialogResult.Yes) Process.Start(folder);


            }

            );
            backgroundProcess.IsBackground = true;
            backgroundProcess.Start();
        }

    }
}
