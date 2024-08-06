using System;
using System.Windows.Forms;
using GroupPanelSample.Controls;

namespace GroupPanelSample
{
    /// <summary>
    /// The form displayed the second page.
    /// </summary>
    /// <para>Форма, отображающая вторую страницу.</para>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010
    /// </remarks>
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
