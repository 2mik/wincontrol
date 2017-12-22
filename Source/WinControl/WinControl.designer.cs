namespace WinControl
{
    partial class WinControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinControl));
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.flpnlTabsLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTabsRight = new System.Windows.Forms.Panel();
            this.btnTabs = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlTabs.SuspendLayout();
            this.pnlTabsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.Controls.Add(this.flpnlTabsLeft);
            this.pnlTabs.Controls.Add(this.pnlTabsRight);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(365, 20);
            this.pnlTabs.TabIndex = 1;
            this.pnlTabs.Visible = false;
            // 
            // flpnlTabsLeft
            // 
            this.flpnlTabsLeft.BackColor = System.Drawing.SystemColors.Control;
            this.flpnlTabsLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlTabsLeft.Location = new System.Drawing.Point(0, 0);
            this.flpnlTabsLeft.Name = "flpnlTabsLeft";
            this.flpnlTabsLeft.Size = new System.Drawing.Size(320, 20);
            this.flpnlTabsLeft.TabIndex = 1;
            this.flpnlTabsLeft.WrapContents = false;
            this.flpnlTabsLeft.Resize += new System.EventHandler(this.flpnlTabsLeft_Resize);
            // 
            // pnlTabsRight
            // 
            this.pnlTabsRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTabsRight.Controls.Add(this.btnTabs);
            this.pnlTabsRight.Controls.Add(this.btnClose);
            this.pnlTabsRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTabsRight.Location = new System.Drawing.Point(320, 0);
            this.pnlTabsRight.Name = "pnlTabsRight";
            this.pnlTabsRight.Size = new System.Drawing.Size(45, 20);
            this.pnlTabsRight.TabIndex = 0;
            // 
            // btnTabs
            // 
            this.btnTabs.FlatAppearance.BorderSize = 0;
            this.btnTabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabs.ImageIndex = 0;
            this.btnTabs.ImageList = this.imageList;
            this.btnTabs.Location = new System.Drawing.Point(9, 4);
            this.btnTabs.Name = "btnTabs";
            this.btnTabs.Size = new System.Drawing.Size(13, 13);
            this.btnTabs.TabIndex = 0;
            this.btnTabs.TabStop = false;
            this.btnTabs.UseVisualStyleBackColor = true;
            this.btnTabs.Click += new System.EventHandler(this.btnTabs_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "files1.gif");
            this.imageList.Images.SetKeyName(1, "files2.gif");
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(25, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(13, 13);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 20);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContent.Size = new System.Drawing.Size(365, 230);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            this.pnlContent.Resize += new System.EventHandler(this.pnlContent_Resize);
            // 
            // contextTabs
            // 
            this.contextTabs.Name = "contextTabs";
            this.contextTabs.Size = new System.Drawing.Size(61, 4);
            // 
            // WinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTabs);
            this.Name = "WinControl";
            this.Size = new System.Drawing.Size(365, 250);
            this.BackColorChanged += new System.EventHandler(this.WinControl_BackColorChanged);
            this.FontChanged += new System.EventHandler(this.WinControl_FontChanged);
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabsRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.FlowLayoutPanel flpnlTabsLeft;
        private System.Windows.Forms.Panel pnlTabsRight;
        private System.Windows.Forms.Button btnTabs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextTabs;
        private System.Windows.Forms.ImageList imageList;



    }
}
