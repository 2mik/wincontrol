namespace GroupPanelSample
{
    partial class FrmSecond
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inheritedPanel1 = new GroupPanelSample.Controls.InheritedPanel();
            this.inheritedPanel2 = new GroupPanelSample.Controls.InheritedPanel();
            this.inheritedPanel3 = new GroupPanelSample.Controls.InheritedPanel();
            this.flowLayoutPanel.SuspendLayout();
            this.inheritedPanel1.SuspendLayout();
            this.inheritedPanel2.SuspendLayout();
            this.inheritedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.inheritedPanel1);
            this.flowLayoutPanel.Controls.Add(this.inheritedPanel2);
            this.flowLayoutPanel.Controls.Add(this.inheritedPanel3);
            this.flowLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(590, 400);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // inheritedPanel1
            // 
            this.inheritedPanel1.ContentBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            // 
            // inheritedPanel1.pnlContent
            // 
            this.inheritedPanel1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.inheritedPanel1.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inheritedPanel1.ContentPanel.Location = new System.Drawing.Point(0, 20);
            this.inheritedPanel1.ContentPanel.Name = "pnlContent";
            this.inheritedPanel1.ContentPanel.Size = new System.Drawing.Size(580, 100);
            this.inheritedPanel1.ContentPanel.TabIndex = 1;
            this.inheritedPanel1.Location = new System.Drawing.Point(3, 3);
            this.inheritedPanel1.Name = "inheritedPanel1";
            this.inheritedPanel1.Size = new System.Drawing.Size(580, 120);
            this.inheritedPanel1.TabIndex = 0;
            this.inheritedPanel1.TitleBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(210)))));
            this.inheritedPanel1.TitleText = "Inherited Panel 1";
            this.inheritedPanel1.TitleTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.inheritedPanel1.TitleClick += new System.EventHandler(this.inheritedPanel_TitleClick);
            // 
            // inheritedPanel2
            // 
            this.inheritedPanel2.ContentBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            // 
            // inheritedPanel2.pnlContent
            // 
            this.inheritedPanel2.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.inheritedPanel2.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inheritedPanel2.ContentPanel.Location = new System.Drawing.Point(0, 20);
            this.inheritedPanel2.ContentPanel.Name = "pnlContent";
            this.inheritedPanel2.ContentPanel.Size = new System.Drawing.Size(580, 100);
            this.inheritedPanel2.ContentPanel.TabIndex = 1;
            this.inheritedPanel2.Location = new System.Drawing.Point(3, 129);
            this.inheritedPanel2.Name = "inheritedPanel2";
            this.inheritedPanel2.Size = new System.Drawing.Size(580, 120);
            this.inheritedPanel2.TabIndex = 1;
            this.inheritedPanel2.TitleBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(210)))));
            this.inheritedPanel2.TitleText = "Inherited Panel 2";
            this.inheritedPanel2.TitleTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.inheritedPanel2.TitleClick += new System.EventHandler(this.inheritedPanel_TitleClick);
            // 
            // inheritedPanel3
            // 
            this.inheritedPanel3.ContentBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            // 
            // inheritedPanel3.pnlContent
            // 
            this.inheritedPanel3.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.inheritedPanel3.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inheritedPanel3.ContentPanel.Location = new System.Drawing.Point(0, 20);
            this.inheritedPanel3.ContentPanel.Name = "pnlContent";
            this.inheritedPanel3.ContentPanel.Size = new System.Drawing.Size(580, 100);
            this.inheritedPanel3.ContentPanel.TabIndex = 1;
            this.inheritedPanel3.Location = new System.Drawing.Point(3, 255);
            this.inheritedPanel3.Name = "inheritedPanel3";
            this.inheritedPanel3.Size = new System.Drawing.Size(580, 120);
            this.inheritedPanel3.TabIndex = 2;
            this.inheritedPanel3.TitleBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(210)))));
            this.inheritedPanel3.TitleText = "Inherited Panel 3";
            this.inheritedPanel3.TitleTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.inheritedPanel3.TitleClick += new System.EventHandler(this.inheritedPanel_TitleClick);
            // 
            // FrmSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 426);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "FrmSecond";
            this.Text = "Second Page";
            this.flowLayoutPanel.ResumeLayout(false);
            this.inheritedPanel1.ResumeLayout(false);
            this.inheritedPanel2.ResumeLayout(false);
            this.inheritedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private GroupPanelSample.Controls.InheritedPanel inheritedPanel1;
        private GroupPanelSample.Controls.InheritedPanel inheritedPanel2;
        private GroupPanelSample.Controls.InheritedPanel inheritedPanel3;
    }
}