/*
 * The main form.
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Главная форма приложения.
 * Разработчик:
 * 2010, Ширяев Михаил
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using WinControl;

namespace WinControlSample
{
    /// <summary>
    /// The main form.
    /// <para>Главная форма приложения.</para>
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Actions associated with tree nodes.
        /// <para>Действия, связанные с узлами дерева.</para>
        /// </summary>
        private enum NodeAction
        {
            None, Action1, Action2, Action3, Action4, Action5, Action6, Action7, Action8, Action9, Action10
        }

        /// <summary>
        /// Tree node information.
        /// <para>Информация, связанная с узлом дерева.</para>
        /// </summary>
        private class NodeInfo
        {
            /// <summary>
            /// Получить или установить действие, связанное с узлом дерева
            /// </summary>
            public NodeAction NodeAction { get; set; }
            /// <summary>
            /// Получить или установить параметры действия
            /// </summary>
            public object[] Params { get; set; }
            /// <summary>
            /// Получить или установить форму, связанную с узлом дерева
            /// </summary>
            public Form Form { get; set; }


            /// <summary>
            /// Конструктор
            /// </summary>
            public NodeInfo()
            {
                NodeAction = NodeAction.None;
                Params = null;
                Form = null;
            }

            /// <summary>
            /// Конструктор
            /// </summary>
            public NodeInfo(NodeAction nodeAction)
            {
                NodeAction = nodeAction;
                Params = null;
                Form = null;
            }
        }

        
        // The nodes of the explorer tree
        // Узлы дерева проводника
        private TreeNode nodDB;          // database node (узел базы данных)
        private TreeNode nodGroup1;      // group 1 node (узел группы 1)
        private TreeNode nodGroup2;      // group 2 node (узел группы 2)
        private List<TreeNode> allNodes; // list of all nodes (список всех узлов дерева)

        private string cultureName;      // culture name (наименование культуры)
        private string caption;          // form caption (заголовок формы)


        public FrmMain()
        {
            InitializeComponent();
            allNodes = new List<TreeNode>();
            cultureName = CultureInfo.CurrentCulture.Name;
            caption = Text;
        }


        /// <summary>
        /// Initializes the explorer tree.
        /// <para>Инициализировать дерево проводника.</para>
        /// </summary>
        private void InitTreeView(CultureInfo culture)
        {
            ResourceManager resManager = new ResourceManager("WinControlSample.Strings", typeof(FrmMain).Assembly);
            string nodeDBText = resManager.GetString("nodeDBText", culture);
            string nodeGroupText = resManager.GetString("nodeGroupText", culture);
            string nodeElemText = resManager.GetString("nodeElemText", culture);

            treeView.Nodes.Clear();
            allNodes.Clear();

            nodDB = treeView.Nodes.Add("DB", nodeDBText, "db_gray.gif", "db_gray.gif");
            allNodes.Add(nodDB);

            // group 1
            // группа 1
            nodGroup1 = nodDB.Nodes.Add("Group1", nodeGroupText + " 1", "folder_closed.gif", "folder_closed.gif");
            allNodes.Add(nodGroup1);

            TreeNode nodTable = nodGroup1.Nodes.Add("Elem1", nodeElemText + " 1", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action1);
            allNodes.Add(nodTable);

            nodTable = nodGroup1.Nodes.Add("Elem2", nodeElemText + " 2", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action2);
            allNodes.Add(nodTable);

            nodTable = nodGroup1.Nodes.Add("Elem3", nodeElemText + " 3", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action3);
            allNodes.Add(nodTable);

            nodTable = nodGroup1.Nodes.Add("Elem4", nodeElemText + " 4", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action4);
            allNodes.Add(nodTable);

            nodTable = nodGroup1.Nodes.Add("Elem5", nodeElemText + " 5", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action5);
            allNodes.Add(nodTable);

            // group 2
            // группа 2
            nodGroup2 = nodDB.Nodes.Add("Group2", nodeGroupText + " 2", "folder_closed.gif", "folder_closed.gif");
            allNodes.Add(nodGroup2);

            nodTable = nodGroup2.Nodes.Add("Elem6", nodeElemText + " 6", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action6);
            allNodes.Add(nodTable);

            nodTable = nodGroup2.Nodes.Add("Elem7", nodeElemText + " 7", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action7);
            allNodes.Add(nodTable);

            nodTable = nodGroup2.Nodes.Add("Elem8", nodeElemText + " 8", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action8);
            allNodes.Add(nodTable);

            nodTable = nodGroup2.Nodes.Add("Elem9", nodeElemText + " 9", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action9);
            allNodes.Add(nodTable);

            nodTable = nodGroup2.Nodes.Add("Elem10", nodeElemText + " 10", "table.gif", "table.gif");
            nodTable.Tag = new NodeInfo(NodeAction.Action10);
            allNodes.Add(nodTable);
        }

        /// <summary>
        /// Executes the action assocoated with the specified node.
        /// <para>Выполнить действие, связанное с заданным узлом дерева.</para>
        /// </summary>
        private void ExecNodeAction(TreeNode node)
        {
            NodeInfo nodeInfo = node.Tag as NodeInfo;
            if (nodeInfo != null)
            {
                Form form = nodeInfo.Form;
                if (form == null)
                {
                    switch (nodeInfo.NodeAction)
                    {
                        case NodeAction.Action1:
                        case NodeAction.Action2:
                        case NodeAction.Action3:
                        case NodeAction.Action4:
                        case NodeAction.Action5:
                        case NodeAction.Action6:
                        case NodeAction.Action7:
                        case NodeAction.Action8:
                        case NodeAction.Action9:
                        case NodeAction.Action10:
                            FrmChild frmChild = new FrmChild();
                            frmChild.Text = node.Text;
                            frmChild.CultureName = cultureName;
                            form = frmChild;
                            break;
                    }

                    if (form != null)
                    {
                        IWinControllable itfWin = form as IWinControllable;
                        if (itfWin != null)
                        {
                            itfWin.WinInfo = new WinInfo();
                            itfWin.WinInfo.TreeNode = node;
                        }

                        form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                        nodeInfo.Form = form;

                        winControl.AddForm(form, "", ilTree.Images["table.gif"]);
                    }
                }
                else
                {
                    winControl.ActivateForm(form);
                }
                SetWindowItemsEnabled();
            }
        }

        /// <summary>
        /// Processes event that raised when a child form closes.
        /// <para>Обработать событие при закрытии дочерней формы.</para>
        /// </summary>
        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            // removes the link to the form associated with a tree node
            // очистка ссылки на форму, связанную с узлом дерева
            IWinControllable itfWin = sender as IWinControllable;
            TreeNode treeNode = itfWin == null || itfWin.WinInfo == null ? null : itfWin.WinInfo.TreeNode;
            if (treeNode == null)
            {
                foreach (TreeNode node in allNodes)
                {
                    NodeInfo nodeInfo = node.Tag as NodeInfo;
                    if (nodeInfo != null && nodeInfo.Form == sender)
                    {
                        nodeInfo.Form = null;
                        break;
                    }
                }
            }
            else
            {
                NodeInfo nodeInfo = treeNode.Tag as NodeInfo;
                if (nodeInfo != null)
                    nodeInfo.Form = null;
            }
        }

        /// <summary>
        /// Connects.
        /// <para>Соединиться с БД.</para>
        /// </summary>
        private void Connect(bool expandTree)
        {
            nodDB.ImageKey = nodDB.SelectedImageKey = "db.gif";
            nodGroup1.Expand();
            nodGroup2.Expand();

            btnConnect.Enabled = miConnect.Enabled = false;
            btnDisconnect.Enabled = miDisconnect.Enabled = true;

            if (expandTree)
                nodDB.Expand();
        }

        /// <summary>
        /// Disconnects.
        /// <para>Разъединиться с БД.</para>
        /// </summary>
        private void Disconnect()
        {
            nodDB.ImageKey = nodDB.SelectedImageKey = "db_gray.gif";
            treeView.CollapseAll();
            btnConnect.Enabled = miConnect.Enabled = true;
            btnDisconnect.Enabled = miDisconnect.Enabled = false;
        }

        /// <summary>
        /// Applies a culture parameters.
        /// <para>Применить параметры культуры.</para>
        /// </summary>
        private void ApplyCulture(string cultureName)
        {
            ComponentResourceManager compResManager = new ComponentResourceManager(GetType());
            CultureInfo culture = new CultureInfo(cultureName);

            // the form
            // форма
            caption = compResManager.GetString("$this.Text", culture);
            Text = winControl.ActiveForm == null ? caption : caption + " - " + winControl.ActiveForm.Text;
            compResManager.ApplyResources(winControl, winControl.Name, culture);
            compResManager.ApplyResources(lblStatusText, lblStatusText.Name, culture);

            // menu
            // меню
            foreach (ToolStripMenuItem item in menuMain.Items)
            {
                compResManager.ApplyResources(item, item.Name, culture);
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    bool enabled = subItem.Enabled;
                    compResManager.ApplyResources(subItem, subItem.Name, culture);
                    subItem.Enabled = enabled;
                }
            }

            // toolbar
            // панель инструментов
            foreach (ToolStripItem item in toolMain.Items)
            {
                bool enabled = item.Enabled;
                compResManager.ApplyResources(item, item.Name, culture);
                item.Enabled = enabled;
            }

            // tree nodes
            // узлы дерева
            ResourceManager resManager = new ResourceManager("WinControlSample.Strings", typeof(FrmMain).Assembly);
            string nodeDBText = resManager.GetString("nodeDBText", culture);
            string nodeGroupText = resManager.GetString("nodeGroupText", culture);
            string nodeElemText = resManager.GetString("nodeElemText", culture);
            int cntr1 = 1;
            int cntr2 = 1;

            foreach (TreeNode node in allNodes)
            {
                if (node.Name == "DB")
                    node.Text = nodeDBText;
                else if (node.Name.StartsWith("Group"))
                {
                    node.Text = nodeGroupText + " " + cntr1;
                    cntr1++;
                }
                else if (node.Name.StartsWith("Elem"))
                {
                    node.Text = nodeElemText + " " + cntr2;
                    cntr2++;
                }
            }
        }

        /// <summary>
        /// Sets "Window" menu items enabled.
        /// <para>Устновить разрешения для элементов пункта меню "Окно".</para>
        /// </summary>
        private void SetWindowItemsEnabled()
        {
            miWindowCloseActive.Enabled = miWindowCloseAll.Enabled = miWindowCloseAllButActive.Enabled =
                winControl.FormCount > 0;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitTreeView(CultureInfo.CurrentCulture);
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Connect(true);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool cancel;
            winControl.CloseAllForms(out cancel);

            if (cancel)
                e.Cancel = true;
        }


        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ExecNodeAction(e.Node);
        }

        private void treeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeNode selNode = treeView.SelectedNode;
                NodeInfo nodeInfo = selNode == null ? null : selNode.Tag as NodeInfo;

                if (nodeInfo == null)
                {
                    // collapses or expands tree node
                    // свернуть или развернуть узел дерева
                    if (selNode.Nodes.Count > 0)
                        if (selNode.IsExpanded)
                            selNode.Collapse(true);
                        else
                            selNode.Expand();
                }
                else
                {
                    // shows the form associated with the tree node
                    // открыть связанную с узлом дерева форму
                    ExecNodeAction(selNode);
                }
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node == nodDB)
                Connect(false);
            else if (node == nodGroup1 || node == nodGroup2)
                node.ImageKey = node.SelectedImageKey = "folder_open.gif";
        }

        private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node == nodGroup1 || node == nodGroup2)
                node.ImageKey = node.SelectedImageKey = "folder_closed.gif";
        }


        private void miConnect_Click(object sender, EventArgs e)
        {
            Connect(true);
        }

        private void miDisconnect_Click(object sender, EventArgs e)
        {
            bool cancel;
            winControl.CloseAllForms(out cancel);
            if (!cancel)
                Disconnect();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miViewBlue_Click(object sender, EventArgs e)
        {
            winControl.ControlColorScheme = WinControl.WinControl.ColorScheme.Blue;
        }

        private void miViewGreen_Click(object sender, EventArgs e)
        {
            winControl.ControlColorScheme = WinControl.WinControl.ColorScheme.Green;
        }

        private void miViewGray_Click(object sender, EventArgs e)
        {
            winControl.ControlColorScheme = WinControl.WinControl.ColorScheme.Gray;
        }

        private void miViewEnglish_Click(object sender, EventArgs e)
        {
            cultureName = "";
            ApplyCulture(cultureName);
        }

        private void miViewRussian_Click(object sender, EventArgs e)
        {
            cultureName = "ru-RU";
            ApplyCulture(cultureName);
        }

        private void miWindowCloseActive_Click(object sender, EventArgs e)
        {
            Form form = winControl.ActiveForm as Form;
            if (form != null)
            {
                bool cancel;
                winControl.CloseForm(form, out cancel);
                if (!cancel)
                    SetWindowItemsEnabled();
            }
        }

        private void miWindowCloseAll_Click(object sender, EventArgs e)
        {
            bool cancel;
            winControl.CloseAllForms(out cancel);
            if (!cancel)
                SetWindowItemsEnabled();
        }

        private void miWindowCloseAllButActive_Click(object sender, EventArgs e)
        {
            bool cancel;
            winControl.CloseAllButActive(out cancel);
        }

        private void miWindowPrevious_Click(object sender, EventArgs e)
        {
            winControl.ActivatePrevious();
        }

        private void miWindowNext_Click(object sender, EventArgs e)
        {
            winControl.ActivateNext();
        }

        private void miHelpAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog(this);
        }


        private void lblStatusLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wincontrol.rapidscada.ru");
        }

        private void winControl_ActiveFormChanged(object sender, EventArgs e)
        {
            Text = winControl.ActiveForm == null ? caption : caption + " - " + winControl.ActiveForm.Text;
        }
    }
}
