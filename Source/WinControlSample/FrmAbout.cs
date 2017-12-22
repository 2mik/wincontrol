/*
 * The about form.
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Форма о программе.
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

namespace WinControlSample
{
    /// <summary>
    /// The about form.
    /// <para>Форма о программе.</para>
    /// </summary>
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wincontrol.rapidscada.ru");
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
