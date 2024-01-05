namespace WinControls
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
            pnlTabs = new Panel();
            flpnlTabsLeft = new FlowLayoutPanel();
            pnlTabsRight = new Panel();
            btnTabs = new Button();
            btnClose = new Button();
            pnlContent = new Panel();
            toolTip = new ToolTip(components);
            contextTabs = new ContextMenuStrip(components);
            pnlTabs.SuspendLayout();
            pnlTabsRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabs
            // 
            pnlTabs.Controls.Add(flpnlTabsLeft);
            pnlTabs.Controls.Add(pnlTabsRight);
            pnlTabs.Dock = DockStyle.Top;
            pnlTabs.Location = new Point(0, 0);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new Size(365, 20);
            pnlTabs.TabIndex = 1;
            pnlTabs.Visible = false;
            // 
            // flpnlTabsLeft
            // 
            flpnlTabsLeft.BackColor = SystemColors.Control;
            flpnlTabsLeft.Dock = DockStyle.Fill;
            flpnlTabsLeft.Location = new Point(0, 0);
            flpnlTabsLeft.Name = "flpnlTabsLeft";
            flpnlTabsLeft.Size = new Size(320, 20);
            flpnlTabsLeft.TabIndex = 1;
            flpnlTabsLeft.WrapContents = false;
            flpnlTabsLeft.Resize += flpnlTabsLeft_Resize;
            // 
            // pnlTabsRight
            // 
            pnlTabsRight.BackColor = SystemColors.Control;
            pnlTabsRight.Controls.Add(btnTabs);
            pnlTabsRight.Controls.Add(btnClose);
            pnlTabsRight.Dock = DockStyle.Right;
            pnlTabsRight.Location = new Point(320, 0);
            pnlTabsRight.Name = "pnlTabsRight";
            pnlTabsRight.Size = new Size(45, 20);
            pnlTabsRight.TabIndex = 0;
            // 
            // btnTabs
            // 
            btnTabs.FlatAppearance.BorderSize = 0;
            btnTabs.FlatStyle = FlatStyle.Flat;
            btnTabs.Image = Properties.Resources.btn_forms1;
            btnTabs.Location = new Point(9, 4);
            btnTabs.Name = "btnTabs";
            btnTabs.Size = new Size(13, 13);
            btnTabs.TabIndex = 0;
            btnTabs.TabStop = false;
            btnTabs.UseVisualStyleBackColor = true;
            btnTabs.Click += btnTabs_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.btn_close;
            btnClose.Location = new Point(25, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(13, 13);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 20);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(5);
            pnlContent.Size = new Size(365, 230);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            pnlContent.Resize += pnlContent_Resize;
            // 
            // contextTabs
            // 
            contextTabs.Name = "contextTabs";
            contextTabs.Size = new Size(61, 4);
            // 
            // WinControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContent);
            Controls.Add(pnlTabs);
            Name = "WinControl";
            Size = new Size(365, 250);
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



    }
}
