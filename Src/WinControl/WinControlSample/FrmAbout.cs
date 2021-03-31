using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinControlSample
{
    /// <summary>
    /// The about form.
    /// <para>Форма о программе.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010, 2021
    /// </remarks>
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/2mik/wincontrol") { UseShellExecute = true });
            Close();
        }

        private void FrmAbout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAbout_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }
    }
}
