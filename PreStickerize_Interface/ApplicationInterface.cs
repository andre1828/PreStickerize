using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            fileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            fileDialog.ShowDialog();
               
            string[] fileNames = fileDialog.SafeFileNames;
            string filename = string.Empty;


            foreach (string file in fileNames)
            {
                filename = filename +  file + " ";
            }

            SourceTextBox.Text = filename;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void OKbutton_Click(object sender, EventArgs e)
        {
            if(fileDialog.SafeFileNames.Length > 1)
            {
               Conversion.folderLevelConversion(fileDialog.FileNames, folder);
            }
        }
    }
}
