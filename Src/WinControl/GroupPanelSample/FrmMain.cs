using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GroupPanelSample
{
    /// <summary>
    /// The main form.
    /// <para>Главная форма приложения.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010, 2021
    /// </remarks>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            winControl.AddForm(new FrmSecond(), "", null, null);
            winControl.AddForm(new FrmFirst(), "", null, null);
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a fake button.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblStatusLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(lblStatusLink.Text) { UseShellExecute = true });
        }

        private void statusStrip_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new(Color.FromArgb(120, 120, 120));
            graphics.DrawLine(pen, 0, 1, statusStrip.Width, 1);
        }
    }
}
