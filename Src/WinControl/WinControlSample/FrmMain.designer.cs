namespace WinControlSample
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuMain = new System.Windows.Forms.MenuStrip();
            miDB = new System.Windows.Forms.ToolStripMenuItem();
            miConnect = new System.Windows.Forms.ToolStripMenuItem();
            miDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            miExit = new System.Windows.Forms.ToolStripMenuItem();
            miView = new System.Windows.Forms.ToolStripMenuItem();
            miViewBlue = new System.Windows.Forms.ToolStripMenuItem();
            miViewGreen = new System.Windows.Forms.ToolStripMenuItem();
            miViewGray = new System.Windows.Forms.ToolStripMenuItem();
            miViewSep = new System.Windows.Forms.ToolStripSeparator();
            miViewEnglish = new System.Windows.Forms.ToolStripMenuItem();
            miViewRussian = new System.Windows.Forms.ToolStripMenuItem();
            miWindow = new System.Windows.Forms.ToolStripMenuItem();
            miWindowCloseActive = new System.Windows.Forms.ToolStripMenuItem();
            miWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            miWindowCloseAllButActive = new System.Windows.Forms.ToolStripMenuItem();
            miWindowPrevious = new System.Windows.Forms.ToolStripMenuItem();
            miWindowNext = new System.Windows.Forms.ToolStripMenuItem();
            miHelp = new System.Windows.Forms.ToolStripMenuItem();
            miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            toolMain = new System.Windows.Forms.ToolStrip();
            btnConnect = new System.Windows.Forms.ToolStripButton();
            btnDisconnect = new System.Windows.Forms.ToolStripButton();
            sepFirst = new System.Windows.Forms.ToolStripSeparator();
            btnBlue = new System.Windows.Forms.ToolStripButton();
            btnGreen = new System.Windows.Forms.ToolStripButton();
            btnGray = new System.Windows.Forms.ToolStripButton();
            sepSecond = new System.Windows.Forms.ToolStripSeparator();
            btnEnglish = new System.Windows.Forms.ToolStripButton();
            btnRussian = new System.Windows.Forms.ToolStripButton();
            sepThird = new System.Windows.Forms.ToolStripSeparator();
            btnAbout = new System.Windows.Forms.ToolStripButton();
            statusMain = new System.Windows.Forms.StatusStrip();
            lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusLink = new System.Windows.Forms.ToolStripStatusLabel();
            pnlLeft = new System.Windows.Forms.Panel();
            treeView = new System.Windows.Forms.TreeView();
            ilTree = new System.Windows.Forms.ImageList(components);
            splitterVert = new System.Windows.Forms.Splitter();
            pnlRight = new System.Windows.Forms.Panel();
            winControl = new WinControl.WinControl();
            menuMain.SuspendLayout();
            toolMain.SuspendLayout();
            statusMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miDB, miView, miWindow, miHelp });
            resources.ApplyResources(menuMain, "menuMain");
            menuMain.Name = "menuMain";
            // 
            // miDB
            // 
            miDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miConnect, miDisconnect, toolStripSeparator1, miExit });
            miDB.Name = "miDB";
            resources.ApplyResources(miDB, "miDB");
            // 
            // miConnect
            // 
            resources.ApplyResources(miConnect, "miConnect");
            miConnect.Name = "miConnect";
            miConnect.Click += miConnect_Click;
            // 
            // miDisconnect
            // 
            resources.ApplyResources(miDisconnect, "miDisconnect");
            miDisconnect.Name = "miDisconnect";
            miDisconnect.Click += miDisconnect_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            resources.ApplyResources(miExit, "miExit");
            miExit.Click += miExit_Click;
            // 
            // miView
            // 
            miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miViewBlue, miViewGreen, miViewGray, miViewSep, miViewEnglish, miViewRussian });
            miView.Name = "miView";
            resources.ApplyResources(miView, "miView");
            // 
            // miViewBlue
            // 
            resources.ApplyResources(miViewBlue, "miViewBlue");
            miViewBlue.Name = "miViewBlue";
            miViewBlue.Click += miViewBlue_Click;
            // 
            // miViewGreen
            // 
            resources.ApplyResources(miViewGreen, "miViewGreen");
            miViewGreen.Name = "miViewGreen";
            miViewGreen.Click += miViewGreen_Click;
            // 
            // miViewGray
            // 
            resources.ApplyResources(miViewGray, "miViewGray");
            miViewGray.Name = "miViewGray";
            miViewGray.Click += miViewGray_Click;
            // 
            // miViewSep
            // 
            miViewSep.Name = "miViewSep";
            resources.ApplyResources(miViewSep, "miViewSep");
            // 
            // miViewEnglish
            // 
            resources.ApplyResources(miViewEnglish, "miViewEnglish");
            miViewEnglish.Name = "miViewEnglish";
            miViewEnglish.Click += miViewEnglish_Click;
            // 
            // miViewRussian
            // 
            resources.ApplyResources(miViewRussian, "miViewRussian");
            miViewRussian.Name = "miViewRussian";
            miViewRussian.Click += miViewRussian_Click;
            // 
            // miWindow
            // 
            miWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miWindowCloseActive, miWindowCloseAll, miWindowCloseAllButActive, miWindowPrevious, miWindowNext });
            miWindow.Name = "miWindow";
            resources.ApplyResources(miWindow, "miWindow");
            // 
            // miWindowCloseActive
            // 
            resources.ApplyResources(miWindowCloseActive, "miWindowCloseActive");
            miWindowCloseActive.Name = "miWindowCloseActive";
            miWindowCloseActive.Click += miWindowCloseActive_Click;
            // 
            // miWindowCloseAll
            // 
            resources.ApplyResources(miWindowCloseAll, "miWindowCloseAll");
            miWindowCloseAll.Name = "miWindowCloseAll";
            miWindowCloseAll.Click += miWindowCloseAll_Click;
            // 
            // miWindowCloseAllButActive
            // 
            resources.ApplyResources(miWindowCloseAllButActive, "miWindowCloseAllButActive");
            miWindowCloseAllButActive.Name = "miWindowCloseAllButActive";
            miWindowCloseAllButActive.Click += miWindowCloseAllButActive_Click;
            // 
            // miWindowPrevious
            // 
            miWindowPrevious.Name = "miWindowPrevious";
            resources.ApplyResources(miWindowPrevious, "miWindowPrevious");
            miWindowPrevious.Click += miWindowPrevious_Click;
            // 
            // miWindowNext
            // 
            miWindowNext.Name = "miWindowNext";
            resources.ApplyResources(miWindowNext, "miWindowNext");
            miWindowNext.Click += miWindowNext_Click;
            // 
            // miHelp
            // 
            miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miHelpAbout });
            miHelp.Name = "miHelp";
            resources.ApplyResources(miHelp, "miHelp");
            // 
            // miHelpAbout
            // 
            resources.ApplyResources(miHelpAbout, "miHelpAbout");
            miHelpAbout.Name = "miHelpAbout";
            miHelpAbout.Click += miHelpAbout_Click;
            // 
            // toolMain
            // 
            toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnConnect, btnDisconnect, sepFirst, btnBlue, btnGreen, btnGray, sepSecond, btnEnglish, btnRussian, sepThird, btnAbout });
            resources.ApplyResources(toolMain, "toolMain");
            toolMain.Name = "toolMain";
            // 
            // btnConnect
            // 
            btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnConnect, "btnConnect");
            btnConnect.Name = "btnConnect";
            btnConnect.Click += miConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnDisconnect, "btnDisconnect");
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Click += miDisconnect_Click;
            // 
            // sepFirst
            // 
            sepFirst.Name = "sepFirst";
            resources.ApplyResources(sepFirst, "sepFirst");
            // 
            // btnBlue
            // 
            btnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnBlue, "btnBlue");
            btnBlue.Name = "btnBlue";
            btnBlue.Click += miViewBlue_Click;
            // 
            // btnGreen
            // 
            btnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnGreen, "btnGreen");
            btnGreen.Name = "btnGreen";
            btnGreen.Click += miViewGreen_Click;
            // 
            // btnGray
            // 
            btnGray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnGray, "btnGray");
            btnGray.Name = "btnGray";
            btnGray.Click += miViewGray_Click;
            // 
            // sepSecond
            // 
            sepSecond.Name = "sepSecond";
            resources.ApplyResources(sepSecond, "sepSecond");
            // 
            // btnEnglish
            // 
            btnEnglish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnEnglish, "btnEnglish");
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Click += miViewEnglish_Click;
            // 
            // btnRussian
            // 
            btnRussian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnRussian, "btnRussian");
            btnRussian.Name = "btnRussian";
            btnRussian.Click += miViewRussian_Click;
            // 
            // sepThird
            // 
            sepThird.Name = "sepThird";
            resources.ApplyResources(sepThird, "sepThird");
            // 
            // btnAbout
            // 
            btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(btnAbout, "btnAbout");
            btnAbout.Name = "btnAbout";
            btnAbout.Click += miHelpAbout_Click;
            // 
            // statusMain
            // 
            statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatusText, lblStatusLink });
            resources.ApplyResources(statusMain, "statusMain");
            statusMain.Name = "statusMain";
            // 
            // lblStatusText
            // 
            lblStatusText.Name = "lblStatusText";
            resources.ApplyResources(lblStatusText, "lblStatusText");
            // 
            // lblStatusLink
            // 
            lblStatusLink.IsLink = true;
            lblStatusLink.Name = "lblStatusLink";
            resources.ApplyResources(lblStatusLink, "lblStatusLink");
            lblStatusLink.Click += lblStatusLink_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(treeView);
            resources.ApplyResources(pnlLeft, "pnlLeft");
            pnlLeft.Name = "pnlLeft";
            // 
            // treeView
            // 
            resources.ApplyResources(treeView, "treeView");
            treeView.ForeColor = System.Drawing.SystemColors.WindowText;
            treeView.ImageList = ilTree;
            treeView.Name = "treeView";
            treeView.BeforeCollapse += treeView_BeforeCollapse;
            treeView.BeforeExpand += treeView_BeforeExpand;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            treeView.KeyDown += treeView_KeyDown;
            // 
            // ilTree
            // 
            ilTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            ilTree.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilTree.ImageStream");
            ilTree.TransparentColor = System.Drawing.Color.Transparent;
            ilTree.Images.SetKeyName(0, "db.gif");
            ilTree.Images.SetKeyName(1, "db_gray.gif");
            ilTree.Images.SetKeyName(2, "folder_open.gif");
            ilTree.Images.SetKeyName(3, "folder_closed.gif");
            ilTree.Images.SetKeyName(4, "table.gif");
            ilTree.Images.SetKeyName(5, "object.gif");
            ilTree.Images.SetKeyName(6, "kp.gif");
            // 
            // splitterVert
            // 
            resources.ApplyResources(splitterVert, "splitterVert");
            splitterVert.Name = "splitterVert";
            splitterVert.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(winControl);
            resources.ApplyResources(pnlRight, "pnlRight");
            pnlRight.Name = "pnlRight";
            // 
            // winControl
            // 
            winControl.ButtonsVisible = false;
            resources.ApplyResources(winControl, "winControl");
            winControl.Image = (System.Drawing.Image)resources.GetObject("winControl.Image");
            winControl.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            winControl.Name = "winControl";
            winControl.ActiveFormChanged += winControl_ActiveFormChanged;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlRight);
            Controls.Add(splitterVert);
            Controls.Add(pnlLeft);
            Controls.Add(statusMain);
            Controls.Add(toolMain);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "FrmMain";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            Shown += FrmMain_Shown;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miDB;
        private System.Windows.Forms.ToolStripMenuItem miConnect;
        private System.Windows.Forms.ToolStripMenuItem miDisconnect;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Splitter splitterVert;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private WinControl.WinControl winControl;
        private System.Windows.Forms.ImageList ilTree;
        private System.Windows.Forms.ToolStripButton btnDisconnect;
        private System.Windows.Forms.ToolStripSeparator sepFirst;
        private System.Windows.Forms.ToolStripButton btnBlue;
        private System.Windows.Forms.ToolStripButton btnGreen;
        private System.Windows.Forms.ToolStripButton btnGray;
        private System.Windows.Forms.ToolStripSeparator sepSecond;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusLink;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miViewBlue;
        private System.Windows.Forms.ToolStripMenuItem miViewGreen;
        private System.Windows.Forms.ToolStripMenuItem miViewGray;
        private System.Windows.Forms.ToolStripSeparator miViewSep;
        private System.Windows.Forms.ToolStripMenuItem miViewEnglish;
        private System.Windows.Forms.ToolStripMenuItem miViewRussian;
        private System.Windows.Forms.ToolStripButton btnEnglish;
        private System.Windows.Forms.ToolStripButton btnRussian;
        private System.Windows.Forms.ToolStripSeparator sepThird;
        private System.Windows.Forms.ToolStripMenuItem miWindow;
        private System.Windows.Forms.ToolStripMenuItem miWindowCloseActive;
        private System.Windows.Forms.ToolStripMenuItem miWindowCloseAll;
        private System.Windows.Forms.ToolStripMenuItem miWindowCloseAllButActive;
        private System.Windows.Forms.ToolStripMenuItem miWindowPrevious;
        private System.Windows.Forms.ToolStripMenuItem miWindowNext;
    }
}

