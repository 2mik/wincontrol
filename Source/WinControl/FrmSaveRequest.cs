/*
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Разработчик:
 * 2010, Ширяев Михаил
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// The save request form.
    /// <para>Форма запроса на сохранение данных.</para>
    /// </summary>
    public partial class FrmSaveRequest : Form
    {
        /// <summary>
        /// Initializes a new instance of the FrmSaveRequest class.
        /// <para>Конструктор.</para>
        /// </summary>
        public FrmSaveRequest()
        {
            InitializeComponent();
            SavedItems = null;
        }

        /// <summary>
        /// Gets or sets the saved items list.
        /// <para>Получить или установить список сохраняемых элементов.</para>
        /// </summary>
        public List<IChildForm> SavedItems { get; set; }

        private void FrmSaveRequest_Shown(object sender, EventArgs e)
        {
            // fills the saved items ckecked list box
            // заполнение списка сохраняемых элементов на форме
            if (SavedItems != null)
            {
                clbTabPages.Items.Clear();
                foreach (IChildForm item in SavedItems)
                {
                    try { clbTabPages.Items.Add(item.ChildFormTag.ChildForm.Text, true); }
                    catch { }
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // removes the items that shouldn't be saved
            // удаление из списка тех элементов, которые не требуется сохранять
            if (SavedItems != null)
            {
                for (int i = clbTabPages.Items.Count - 1; i >= 0; i--)
                    if (!clbTabPages.GetItemChecked(i))
                        SavedItems.RemoveAt(i);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SavedItems.Clear();
        }
    }
}
