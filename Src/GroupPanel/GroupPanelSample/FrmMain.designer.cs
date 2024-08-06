namespace GroupPanelSample
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusLink = new System.Windows.Forms.ToolStripStatusLabel();
            toolStrip = new System.Windows.Forms.ToolStrip();
            btnNew = new System.Windows.Forms.ToolStripButton();
            btnOpen = new System.Windows.Forms.ToolStripButton();
            btnSave = new System.Windows.Forms.ToolStripButton();
            btnSep = new System.Windows.Forms.ToolStripSeparator();
            btnInfo = new System.Windows.Forms.ToolStripButton();
            winControl = new WinControls.WinControl();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatusText, lblStatusLink });
            statusStrip.Location = new System.Drawing.Point(0, 508);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(614, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 0;
            statusStrip.Paint += statusStrip_Paint;
            // 
            // lblStatusText
            // 
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new System.Drawing.Size(139, 17);
            lblStatusText.Text = "Look for new versions on";
            // 
            // lblStatusLink
            // 
            lblStatusLink.IsLink = true;
            lblStatusLink.Name = "lblStatusLink";
            lblStatusLink.Size = new System.Drawing.Size(202, 17);
            lblStatusLink.Text = "https://github.com/2mik/wincontrol";
            lblStatusLink.Click += lblStatusLink_Click;
            // 
            // toolStrip
            // 
            toolStrip.BackColor = System.Drawing.Color.Transparent;
            toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnNew, btnOpen, btnSave, btnSep, btnInfo });
            toolStrip.Location = new System.Drawing.Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip.Size = new System.Drawing.Size(614, 56);
            toolStrip.TabIndex = 8;
            toolStrip.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.AutoSize = false;
            btnNew.Image = (System.Drawing.Image)resources.GetObject("btnNew.Image");
            btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(60, 53);
            btnNew.Text = "New";
            btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnNew.Click += toolStripButton_Click;
            // 
            // btnOpen
            // 
            btnOpen.AutoSize = false;
            btnOpen.Image = (System.Drawing.Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(60, 53);
            btnOpen.Text = "Open";
            btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnOpen.Click += toolStripButton_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(60, 53);
            btnSave.Text = "Save";
            btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSave.Click += toolStripButton_Click;
            // 
            // btnSep
            // 
            btnSep.Name = "btnSep";
            btnSep.Size = new System.Drawing.Size(6, 56);
            // 
            // btnInfo
            // 
            btnInfo.AutoSize = false;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(60, 53);
            btnInfo.Text = "Info";
            btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnInfo.Click += toolStripButton_Click;
            // 
            // winControl
            // 
            winControl.AllowToOrderTabs = false;
            winControl.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            winControl.ButtonsVisible = false;
            winControl.Image = null;
            winControl.Location = new System.Drawing.Point(0, 56);
            winControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            winControl.MessageFont = new System.Drawing.Font("Segoe UI", 9F);
            winControl.Name = "winControl";
            winControl.SaveReqCancel = "Cancel";
            winControl.SaveReqCaption = "Save changes";
            winControl.SaveReqNo = "&No";
            winControl.SaveReqQuestion = "Save changes to the following items?";
            winControl.SaveReqYes = "&Yes";
            winControl.Size = new System.Drawing.Size(614, 452);
            winControl.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            ClientSize = new System.Drawing.Size(614, 530);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(winControl);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GroupPanel Demo";
            Load += FrmMain_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private WinControls.WinControl winControl;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator btnSep;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLink;
    }
}

