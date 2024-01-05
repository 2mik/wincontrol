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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinControl));
            pnlTabs = new System.Windows.Forms.Panel();
            flpnlTabsLeft = new System.Windows.Forms.FlowLayoutPanel();
            pnlTabsRight = new System.Windows.Forms.Panel();
            btnTabs = new System.Windows.Forms.Button();
            imageList = new System.Windows.Forms.ImageList(components);
            btnClose = new System.Windows.Forms.Button();
            pnlContent = new System.Windows.Forms.Panel();
            toolTip = new System.Windows.Forms.ToolTip(components);
            contextTabs = new System.Windows.Forms.ContextMenuStrip(components);
            pnlTabs.SuspendLayout();
            pnlTabsRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabs
            // 
            pnlTabs.Controls.Add(flpnlTabsLeft);
            pnlTabs.Controls.Add(pnlTabsRight);
            pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTabs.Location = new System.Drawing.Point(0, 0);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new System.Drawing.Size(365, 20);
            pnlTabs.TabIndex = 1;
            pnlTabs.Visible = false;
            // 
            // flpnlTabsLeft
            // 
            flpnlTabsLeft.BackColor = System.Drawing.SystemColors.Control;
            flpnlTabsLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            flpnlTabsLeft.Location = new System.Drawing.Point(0, 0);
            flpnlTabsLeft.Name = "flpnlTabsLeft";
            flpnlTabsLeft.Size = new System.Drawing.Size(320, 20);
            flpnlTabsLeft.TabIndex = 1;
            flpnlTabsLeft.WrapContents = false;
            flpnlTabsLeft.Resize += flpnlTabsLeft_Resize;
            // 
            // pnlTabsRight
            // 
            pnlTabsRight.BackColor = System.Drawing.SystemColors.Control;
            pnlTabsRight.Controls.Add(btnTabs);
            pnlTabsRight.Controls.Add(btnClose);
            pnlTabsRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlTabsRight.Location = new System.Drawing.Point(320, 0);
            pnlTabsRight.Name = "pnlTabsRight";
            pnlTabsRight.Size = new System.Drawing.Size(45, 20);
            pnlTabsRight.TabIndex = 0;
            // 
            // btnTabs
            // 
            btnTabs.FlatAppearance.BorderSize = 0;
            btnTabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabs.ImageIndex = 0;
            btnTabs.ImageList = imageList;
            btnTabs.Location = new System.Drawing.Point(9, 4);
            btnTabs.Name = "btnTabs";
            btnTabs.Size = new System.Drawing.Size(13, 13);
            btnTabs.TabIndex = 0;
            btnTabs.TabStop = false;
            btnTabs.UseVisualStyleBackColor = true;
            btnTabs.Click += btnTabs_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = System.Drawing.Color.Transparent;
            imageList.Images.SetKeyName(0, "files1.gif");
            imageList.Images.SetKeyName(1, "files2.gif");
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(25, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(13, 13);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 20);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(5);
            pnlContent.Size = new System.Drawing.Size(365, 230);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            pnlContent.Resize += pnlContent_Resize;
            // 
            // contextTabs
            // 
            contextTabs.Name = "contextTabs";
            contextTabs.Size = new System.Drawing.Size(61, 4);
            // 
            // WinControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlContent);
            Controls.Add(pnlTabs);
            Name = "WinControl";
            Size = new System.Drawing.Size(365, 250);
            BackColorChanged += WinControl_BackColorChanged;
            FontChanged += WinControl_FontChanged;
            pnlTabs.ResumeLayout(false);
            pnlTabsRight.ResumeLayout(false);
            ResumeLayout(false);
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
