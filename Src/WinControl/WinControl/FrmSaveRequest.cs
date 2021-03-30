using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// Represents a form that requests saving.
    /// <para>Представляет форму запроса на сохранение данных.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010, 2021
    /// </remarks>
    public partial class FrmSaveRequest : Form
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public FrmSaveRequest()
        {
            InitializeComponent();
            SavedItems = null;
        }

        /// <summary>
        /// Gets or sets the list of items to save.
        /// </summary>
        public List<IChildForm> SavedItems { get; set; }

        private void FrmSaveRequest_Shown(object sender, EventArgs e)
        {
            // show the item list
            if (SavedItems != null)
            {
                clbTabPages.Items.Clear();
                foreach (IChildForm item in SavedItems)
                {
                    if (item?.ChildFormTag?.ChildForm is Form form)
                        clbTabPages.Items.Add(form.Text, true);
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // removes the items that should not be saved
            if (SavedItems != null)
            {
                for (int i = clbTabPages.Items.Count - 1; i >= 0; i--)
                {
                    if (!clbTabPages.GetItemChecked(i))
                        SavedItems.RemoveAt(i);
                }
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SavedItems.Clear();
        }
    }
}
