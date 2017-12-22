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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miDB = new System.Windows.Forms.ToolStripMenuItem();
            this.miConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.miDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewGray = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewSep = new System.Windows.Forms.ToolStripSeparator();
            this.miViewEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewRussian = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCloseActive = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCloseAllButActive = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowNext = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.sepFirst = new System.Windows.Forms.ToolStripSeparator();
            this.btnBlue = new System.Windows.Forms.ToolStripButton();
            this.btnGreen = new System.Windows.Forms.ToolStripButton();
            this.btnGray = new System.Windows.Forms.ToolStripButton();
            this.sepSecond = new System.Windows.Forms.ToolStripSeparator();
            this.btnEnglish = new System.Windows.Forms.ToolStripButton();
            this.btnRussian = new System.Windows.Forms.ToolStripButton();
            this.sepThird = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.ilTree = new System.Windows.Forms.ImageList(this.components);
            this.splitterVert = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.winControl = new WinControl.WinControl();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDB,
            this.miView,
            this.miWindow,
            this.miHelp});
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Name = "menuMain";
            // 
            // miDB
            // 
            this.miDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConnect,
            this.miDisconnect,
            this.toolStripSeparator1,
            this.miExit});
            this.miDB.Name = "miDB";
            resources.ApplyResources(this.miDB, "miDB");
            // 
            // miConnect
            // 
            resources.ApplyResources(this.miConnect, "miConnect");
            this.miConnect.Name = "miConnect";
            this.miConnect.Click += new System.EventHandler(this.miConnect_Click);
            // 
            // miDisconnect
            // 
            resources.ApplyResources(this.miDisconnect, "miDisconnect");
            this.miDisconnect.Name = "miDisconnect";
            this.miDisconnect.Click += new System.EventHandler(this.miDisconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewBlue,
            this.miViewGreen,
            this.miViewGray,
            this.miViewSep,
            this.miViewEnglish,
            this.miViewRussian});
            this.miView.Name = "miView";
            resources.ApplyResources(this.miView, "miView");
            // 
            // miViewBlue
            // 
            resources.ApplyResources(this.miViewBlue, "miViewBlue");
            this.miViewBlue.Name = "miViewBlue";
            this.miViewBlue.Click += new System.EventHandler(this.miViewBlue_Click);
            // 
            // miViewGreen
            // 
            resources.ApplyResources(this.miViewGreen, "miViewGreen");
            this.miViewGreen.Name = "miViewGreen";
            this.miViewGreen.Click += new System.EventHandler(this.miViewGreen_Click);
            // 
            // miViewGray
            // 
            resources.ApplyResources(this.miViewGray, "miViewGray");
            this.miViewGray.Name = "miViewGray";
            this.miViewGray.Click += new System.EventHandler(this.miViewGray_Click);
            // 
            // miViewSep
            // 
            this.miViewSep.Name = "miViewSep";
            resources.ApplyResources(this.miViewSep, "miViewSep");
            // 
            // miViewEnglish
            // 
            resources.ApplyResources(this.miViewEnglish, "miViewEnglish");
            this.miViewEnglish.Name = "miViewEnglish";
            this.miViewEnglish.Click += new System.EventHandler(this.miViewEnglish_Click);
            // 
            // miViewRussian
            // 
            resources.ApplyResources(this.miViewRussian, "miViewRussian");
            this.miViewRussian.Name = "miViewRussian";
            this.miViewRussian.Click += new System.EventHandler(this.miViewRussian_Click);
            // 
            // miWindow
            // 
            this.miWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWindowCloseActive,
            this.miWindowCloseAll,
            this.miWindowCloseAllButActive,
            this.miWindowPrevious,
            this.miWindowNext});
            this.miWindow.Name = "miWindow";
            resources.ApplyResources(this.miWindow, "miWindow");
            // 
            // miWindowCloseActive
            // 
            resources.ApplyResources(this.miWindowCloseActive, "miWindowCloseActive");
            this.miWindowCloseActive.Name = "miWindowCloseActive";
            this.miWindowCloseActive.Click += new System.EventHandler(this.miWindowCloseActive_Click);
            // 
            // miWindowCloseAll
            // 
            resources.ApplyResources(this.miWindowCloseAll, "miWindowCloseAll");
            this.miWindowCloseAll.Name = "miWindowCloseAll";
            this.miWindowCloseAll.Click += new System.EventHandler(this.miWindowCloseAll_Click);
            // 
            // miWindowCloseAllButActive
            // 
            resources.ApplyResources(this.miWindowCloseAllButActive, "miWindowCloseAllButActive");
            this.miWindowCloseAllButActive.Name = "miWindowCloseAllButActive";
            this.miWindowCloseAllButActive.Click += new System.EventHandler(this.miWindowCloseAllButActive_Click);
            // 
            // miWindowPrevious
            // 
            this.miWindowPrevious.Name = "miWindowPrevious";
            resources.ApplyResources(this.miWindowPrevious, "miWindowPrevious");
            this.miWindowPrevious.Click += new System.EventHandler(this.miWindowPrevious_Click);
            // 
            // miWindowNext
            // 
            this.miWindowNext.Name = "miWindowNext";
            resources.ApplyResources(this.miWindowNext, "miWindowNext");
            this.miWindowNext.Click += new System.EventHandler(this.miWindowNext_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
            this.miHelp.Name = "miHelp";
            resources.ApplyResources(this.miHelp, "miHelp");
            // 
            // miHelpAbout
            // 
            resources.ApplyResources(this.miHelpAbout, "miHelpAbout");
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.btnDisconnect,
            this.sepFirst,
            this.btnBlue,
            this.btnGreen,
            this.btnGray,
            this.sepSecond,
            this.btnEnglish,
            this.btnRussian,
            this.sepThird,
            this.btnAbout});
            resources.ApplyResources(this.toolMain, "toolMain");
            this.toolMain.Name = "toolMain";
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Click += new System.EventHandler(this.miConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnDisconnect, "btnDisconnect");
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.miDisconnect_Click);
            // 
            // sepFirst
            // 
            this.sepFirst.Name = "sepFirst";
            resources.ApplyResources(this.sepFirst, "sepFirst");
            // 
            // btnBlue
            // 
            this.btnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnBlue, "btnBlue");
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Click += new System.EventHandler(this.miViewBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnGreen, "btnGreen");
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Click += new System.EventHandler(this.miViewGreen_Click);
            // 
            // btnGray
            // 
            this.btnGray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnGray, "btnGray");
            this.btnGray.Name = "btnGray";
            this.btnGray.Click += new System.EventHandler(this.miViewGray_Click);
            // 
            // sepSecond
            // 
            this.sepSecond.Name = "sepSecond";
            resources.ApplyResources(this.sepSecond, "sepSecond");
            // 
            // btnEnglish
            // 
            this.btnEnglish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnEnglish, "btnEnglish");
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Click += new System.EventHandler(this.miViewEnglish_Click);
            // 
            // btnRussian
            // 
            this.btnRussian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnRussian, "btnRussian");
            this.btnRussian.Name = "btnRussian";
            this.btnRussian.Click += new System.EventHandler(this.miViewRussian_Click);
            // 
            // sepThird
            // 
            this.sepThird.Name = "sepThird";
            resources.ApplyResources(this.sepThird, "sepThird");
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusText,
            this.lblStatusLink});
            resources.ApplyResources(this.statusMain, "statusMain");
            this.statusMain.Name = "statusMain";
            // 
            // lblStatusText
            // 
            this.lblStatusText.Name = "lblStatusText";
            resources.ApplyResources(this.lblStatusText, "lblStatusText");
            // 
            // lblStatusLink
            // 
            this.lblStatusLink.IsLink = true;
            this.lblStatusLink.Name = "lblStatusLink";
            resources.ApplyResources(this.lblStatusLink, "lblStatusLink");
            this.lblStatusLink.Click += new System.EventHandler(this.lblStatusLink_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.treeView);
            resources.ApplyResources(this.pnlLeft, "pnlLeft");
            this.pnlLeft.MinimumSize = new System.Drawing.Size(150, 0);
            this.pnlLeft.Name = "pnlLeft";
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView.ImageList = this.ilTree;
            this.treeView.Name = "treeView";
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCollapse);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
            // 
            // ilTree
            // 
            this.ilTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTree.ImageStream")));
            this.ilTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTree.Images.SetKeyName(0, "db.gif");
            this.ilTree.Images.SetKeyName(1, "db_gray.gif");
            this.ilTree.Images.SetKeyName(2, "folder_open.gif");
            this.ilTree.Images.SetKeyName(3, "folder_closed.gif");
            this.ilTree.Images.SetKeyName(4, "table.gif");
            this.ilTree.Images.SetKeyName(5, "object.gif");
            this.ilTree.Images.SetKeyName(6, "kp.gif");
            // 
            // splitterVert
            // 
            resources.ApplyResources(this.splitterVert, "splitterVert");
            this.splitterVert.Name = "splitterVert";
            this.splitterVert.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.winControl);
            resources.ApplyResources(this.pnlRight, "pnlRight");
            this.pnlRight.Name = "pnlRight";
            // 
            // winControl
            // 
            resources.ApplyResources(this.winControl, "winControl");
            this.winControl.Image = ((System.Drawing.Image)(resources.GetObject("winControl.Image")));
            this.winControl.MessageFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winControl.Name = "winControl";
            this.winControl.ActiveFormChanged += new System.EventHandler(this.winControl_ActiveFormChanged);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitterVert);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

