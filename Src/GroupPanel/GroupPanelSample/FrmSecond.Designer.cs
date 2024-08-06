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
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            inheritedPanel1 = new Controls.InheritedPanel();
            inheritedPanel2 = new Controls.InheritedPanel();
            inheritedPanel3 = new Controls.InheritedPanel();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(inheritedPanel1);
            flowLayoutPanel.Controls.Add(inheritedPanel2);
            flowLayoutPanel.Controls.Add(inheritedPanel3);
            flowLayoutPanel.Location = new System.Drawing.Point(9, 9);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new System.Drawing.Size(590, 400);
            flowLayoutPanel.TabIndex = 1;
            // 
            // inheritedPanel1
            // 
            inheritedPanel1.ContentBottomColor = System.Drawing.Color.FromArgb(232, 230, 255);
            // 
            // 
            // 
            inheritedPanel1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            inheritedPanel1.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            inheritedPanel1.ContentPanel.Location = new System.Drawing.Point(0, 20);
            inheritedPanel1.ContentPanel.Name = "pnlContent";
            inheritedPanel1.ContentPanel.Size = new System.Drawing.Size(580, 100);
            inheritedPanel1.ContentPanel.TabIndex = 1;
            inheritedPanel1.Location = new System.Drawing.Point(3, 3);
            inheritedPanel1.Name = "inheritedPanel1";
            inheritedPanel1.Size = new System.Drawing.Size(580, 120);
            inheritedPanel1.TabIndex = 0;
            inheritedPanel1.TitleBottomColor = System.Drawing.Color.FromArgb(196, 193, 210);
            inheritedPanel1.TitleText = "Inherited Panel 1";
            inheritedPanel1.TitleTopColor = System.Drawing.Color.FromArgb(221, 220, 220);
            inheritedPanel1.TitleClick += inheritedPanel_TitleClick;
            // 
            // inheritedPanel2
            // 
            inheritedPanel2.ContentBottomColor = System.Drawing.Color.FromArgb(232, 230, 255);
            // 
            // 
            // 
            inheritedPanel2.ContentPanel.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            inheritedPanel2.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            inheritedPanel2.ContentPanel.Location = new System.Drawing.Point(0, 20);
            inheritedPanel2.ContentPanel.Name = "pnlContent";
            inheritedPanel2.ContentPanel.Size = new System.Drawing.Size(580, 100);
            inheritedPanel2.ContentPanel.TabIndex = 1;
            inheritedPanel2.Location = new System.Drawing.Point(3, 129);
            inheritedPanel2.Name = "inheritedPanel2";
            inheritedPanel2.Size = new System.Drawing.Size(580, 120);
            inheritedPanel2.TabIndex = 1;
            inheritedPanel2.TitleBottomColor = System.Drawing.Color.FromArgb(196, 193, 210);
            inheritedPanel2.TitleText = "Inherited Panel 2";
            inheritedPanel2.TitleTopColor = System.Drawing.Color.FromArgb(221, 220, 220);
            inheritedPanel2.TitleClick += inheritedPanel_TitleClick;
            // 
            // inheritedPanel3
            // 
            inheritedPanel3.ContentBottomColor = System.Drawing.Color.FromArgb(232, 230, 255);
            // 
            // 
            // 
            inheritedPanel3.ContentPanel.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            inheritedPanel3.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            inheritedPanel3.ContentPanel.Location = new System.Drawing.Point(0, 20);
            inheritedPanel3.ContentPanel.Name = "pnlContent";
            inheritedPanel3.ContentPanel.Size = new System.Drawing.Size(580, 100);
            inheritedPanel3.ContentPanel.TabIndex = 1;
            inheritedPanel3.Location = new System.Drawing.Point(3, 255);
            inheritedPanel3.Name = "inheritedPanel3";
            inheritedPanel3.Size = new System.Drawing.Size(580, 120);
            inheritedPanel3.TabIndex = 2;
            inheritedPanel3.TitleBottomColor = System.Drawing.Color.FromArgb(196, 193, 210);
            inheritedPanel3.TitleText = "Inherited Panel 3";
            inheritedPanel3.TitleTopColor = System.Drawing.Color.FromArgb(221, 220, 220);
            inheritedPanel3.TitleClick += inheritedPanel_TitleClick;
            // 
            // FrmSecond
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(612, 426);
            Controls.Add(flowLayoutPanel);
            Name = "FrmSecond";
            Text = "Second Page";
            flowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private GroupPanelSample.Controls.InheritedPanel inheritedPanel1;
        private GroupPanelSample.Controls.InheritedPanel inheritedPanel2;
        private GroupPanelSample.Controls.InheritedPanel inheritedPanel3;
    }
}