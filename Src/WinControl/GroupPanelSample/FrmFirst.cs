using System;
using System.Windows.Forms;
using WinControl;

namespace GroupPanelSample
{
    /// <summary>
    /// The form displayed the first page.
    /// </summary>
    /// <para>Форма, отображающая первую страницу.</para>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010
    /// </remarks>
    public partial class FrmFirst : Form
    {
        public FrmFirst()
        {
            InitializeComponent();
        }

        private void groupPanel_TitleClick(object sender, EventArgs e)
        {
            flowLayoutPanel.SuspendLayout();

            GroupPanel groupPanel = sender as GroupPanel;
            groupPanel.Expand();

            if (groupPanel1 != groupPanel)
                groupPanel1.Collapse();
            if (groupPanel2 != groupPanel)
                groupPanel2.Collapse();

            flowLayoutPanel.ResumeLayout();
        }
    }
}
