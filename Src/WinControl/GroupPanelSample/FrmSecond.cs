/*
 * The form displayed the second page.
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Форма, отображающая вторую страницу.
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
using GroupPanelSample.Controls;

namespace GroupPanelSample
{
    /// <summary>
    /// The form displayed the second page.
    /// </summary>
    /// <para>Форма, отображающая вторую страницу.</para>
    public partial class FrmSecond : Form
    {
        public FrmSecond()
        {
            InitializeComponent();
        }

        private void inheritedPanel_TitleClick(object sender, EventArgs e)
        {
            flowLayoutPanel.SuspendLayout();
            InheritedPanel inheritedPanel = sender as InheritedPanel;
            inheritedPanel.Expanded = !inheritedPanel.Expanded;
            flowLayoutPanel.ResumeLayout();
        }
    }
}
