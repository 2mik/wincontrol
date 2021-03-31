/*
 * The form displayed the first page.
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Форма, отображающая первую страницу.
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
using WinControl;

namespace GroupPanelSample
{
    /// <summary>
    /// The form displayed the first page.
    /// </summary>
    /// <para>Форма, отображающая первую страницу.</para>
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
