namespace PreStickerize_Interface
{
    partial class ApplicationInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button loadButton;
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.Destinationbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.imagesList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            loadButton.Location = new System.Drawing.Point(252, 104);
            loadButton.Name = "loadButton";
            loadButton.Size = new System.Drawing.Size(75, 20);
            loadButton.TabIndex = 2;
            loadButton.Text = "Load image(s)";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += new System.EventHandler(this.Sourcebutton_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DestinationTextBox.Location = new System.Drawing.Point(83, 30);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(486, 20);
            this.DestinationTextBox.TabIndex = 1;
            // 
            // Destinationbutton
            // 
            this.Destinationbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Destinationbutton.Location = new System.Drawing.Point(2, 30);
            this.Destinationbutton.Name = "Destinationbutton";
            this.Destinationbutton.Size = new System.Drawing.Size(75, 20);
            this.Destinationbutton.TabIndex = 3;
            this.Destinationbutton.Text = "Destination";
            this.Destinationbutton.UseVisualStyleBackColor = true;
            this.Destinationbutton.Click += new System.EventHandler(this.Destinationbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKbutton.Location = new System.Drawing.Point(252, 538);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // imagesList
            // 
            this.imagesList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.imagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.statusColumn});
            this.imagesList.GridLines = true;
            this.imagesList.Location = new System.Drawing.Point(5, 153);
            this.imagesList.Name = "imagesList";
            this.imagesList.Size = new System.Drawing.Size(564, 345);
            this.imagesList.TabIndex = 5;
            this.imagesList.UseCompatibleStateImageBehavior = false;
            this.imagesList.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 462;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.Width = 97;
            // 
            // ApplicationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 562);
            this.Controls.Add(this.imagesList);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Destinationbutton);
            this.Controls.Add(loadButton);
            this.Controls.Add(this.DestinationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ApplicationInterface";
            this.Text = "PreStickerize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button Destinationbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.ListView imagesList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
    }
}

