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
            pnlTitle = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = System.Drawing.Color.FromArgb(196, 193, 176);
            pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            pnlTitle.Location = new System.Drawing.Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new System.Drawing.Size(300, 20);
            pnlTitle.TabIndex = 0;
            pnlTitle.Click += pnlTitle_Click;
            pnlTitle.Paint += pnlTitle_Paint;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 20);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(300, 130);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // GroupPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlContent);
            Controls.Add(pnlTitle);
            Name = "GroupPanel";
            Size = new System.Drawing.Size(300, 150);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Panel pnlContent;
    }
}
