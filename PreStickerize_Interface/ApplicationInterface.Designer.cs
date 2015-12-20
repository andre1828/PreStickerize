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
            System.Windows.Forms.Button Sourcebutton;
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.Destinationbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            Sourcebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sourcebutton
            // 
            Sourcebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            Sourcebutton.Location = new System.Drawing.Point(5, 36);
            Sourcebutton.Name = "Sourcebutton";
            Sourcebutton.Size = new System.Drawing.Size(75, 20);
            Sourcebutton.TabIndex = 2;
            Sourcebutton.Text = "Source";
            Sourcebutton.UseVisualStyleBackColor = true;
            Sourcebutton.Click += new System.EventHandler(this.Sourcebutton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SourceTextBox.Location = new System.Drawing.Point(86, 36);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(486, 20);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DestinationTextBox.Location = new System.Drawing.Point(86, 94);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(486, 20);
            this.DestinationTextBox.TabIndex = 1;
            this.DestinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // Destinationbutton
            // 
            this.Destinationbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Destinationbutton.Location = new System.Drawing.Point(5, 91);
            this.Destinationbutton.Name = "Destinationbutton";
            this.Destinationbutton.Size = new System.Drawing.Size(75, 23);
            this.Destinationbutton.TabIndex = 3;
            this.Destinationbutton.Text = "Destination";
            this.Destinationbutton.UseVisualStyleBackColor = true;
            this.Destinationbutton.Click += new System.EventHandler(this.Destinationbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKbutton.Location = new System.Drawing.Point(255, 133);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // ApplicationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 179);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Destinationbutton);
            this.Controls.Add(Sourcebutton);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.SourceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ApplicationInterface";
            this.Text = "PreStickerize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button Destinationbutton;
        private System.Windows.Forms.Button OKbutton;
    }
}

