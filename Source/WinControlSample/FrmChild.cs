/*
 * The child form.
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Дочерняя форма.
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
    /// The child form.
    /// <para>Дочерняя форма</para>
    /// </summary>
    public partial class FrmChild : Form, IWinControllable
    {
        private string saveComplete;

        public FrmChild()
        {
            InitializeComponent();
            CultureName = "";
            saveComplete = "";
        }

        #region IWinControllable Members

        public WinInfo WinInfo { get; set; }

        public void Save()
        {
            if (WinInfo != null && WinInfo.Modified)
            {
                WinInfo.Modified = false;
                MessageBox.Show(string.Format(saveComplete, "\"" + Text + "\""), Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        public string CultureName { get; set; }


        private void SetModified()
        {
            if (WinInfo != null)
                WinInfo.Modified = true;
        }


        private void FrmChild_Load(object sender, EventArgs e)
        {
            ResourceManager resManager = new ResourceManager("WinControlSample.Strings", typeof(FrmMain).Assembly);
            CultureInfo culture = new CultureInfo(CultureName);
            string colName = resManager.GetString("colName", culture);
            string colAddress = resManager.GetString("colAddress", culture);
            string colComment = resManager.GetString("colComment", culture);
            string colNameVal = resManager.GetString("colNameVal", culture);
            string colAddressVal = resManager.GetString("colAddressVal", culture);
            saveComplete = resManager.GetString("saveComplete", culture);

            DataTable table = new DataTable();
            table.Columns.Add(colName, typeof(string));
            table.Columns.Add(colAddress, typeof(string));
            table.Columns.Add(colComment, typeof(string));
            table.Rows.Add(colNameVal, colAddressVal, Text);

            bindingSource.DataSource = table;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AutoResizeColumns();
        }

        private void FrmChild_Shown(object sender, EventArgs e)
        {
            dataGridView.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            dataGridView.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SetModified();
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetModified();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SetModified();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text += "!";
        }
    }
}
