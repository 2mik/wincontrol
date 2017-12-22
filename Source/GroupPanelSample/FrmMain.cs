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

namespace GroupPanelSample
{
    /// <summary>
    /// The main form.
    /// <para>Главная форма приложения.</para>
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            winControl.AddForm(new FrmSecond(), "", null);
            winControl.AddForm(new FrmFirst(), "", null);
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a fake button.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblStatusLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wincontrol.rapidscada.ru");
        }

        private void statusStrip_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(120, 120, 120));
            graphics.DrawLine(pen, 0, 1, statusStrip.Width, 1);
        }
    }
}
