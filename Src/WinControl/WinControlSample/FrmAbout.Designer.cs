namespace WinControlSample
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            pictureBox = new System.Windows.Forms.PictureBox();
            lblLink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Enabled = false;
            pictureBox.Image = (System.Drawing.Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new System.Drawing.Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(300, 200);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // lblLink
            // 
            lblLink.Cursor = System.Windows.Forms.Cursors.Hand;
            lblLink.Location = new System.Drawing.Point(60, 144);
            lblLink.Name = "lblLink";
            lblLink.Size = new System.Drawing.Size(181, 16);
            lblLink.TabIndex = 2;
            lblLink.Click += lblLink_Click;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(314, 212);
            Controls.Add(pictureBox);
            Controls.Add(lblLink);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "WinControl Demo";
            Click += FrmAbout_Click;
            KeyPress += FrmAbout_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblLink;
    }
}