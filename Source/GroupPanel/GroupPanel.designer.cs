namespace WinControl
{
    partial class GroupPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(176)))));
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(300, 20);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            this.pnlTitle.Click += new System.EventHandler(this.pnlTitle_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 20);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(300, 130);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // GroupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Panel pnlContent;
    }
}
