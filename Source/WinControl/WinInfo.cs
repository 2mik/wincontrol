/*
 * Разработчик:
 * 2010, Ширяев Михаил
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// Информация о контролируемом окне
    /// </summary>
    public class WinInfo
    {
        private bool modified; // признак изменения данных контролируемого окна


        /// <summary>
        /// Получить или установить признак изменения данных контролируемого окна
        /// </summary>
        public bool Modified
        {
            get
            {
                return modified;
            }
            set
            {
                if (modified != value)
                {
                    modified = value;
                    if (ModifiedChanged != null)
                        ModifiedChanged(this, null);
                }
            }
        }

        /// <summary>
        /// Получить или установить узел дерева проводника, соответствующий контролируемому окну
        /// </summary>
        public TreeNode TreeNode { get; set; }

        /// <summary>
        /// Получить или установить панель, представляющую закладку контролируемого окна
        /// </summary>
        public Panel TabPanel { get; set; }

        /// <summary>
        /// Получить заголовок контролируемого окна
        /// </summary>
        public string Title
        {
            get
            {
                return TabPanel == null ? "" : TabPanel.Text.TrimEnd('*');
            }
        }

        /// <summary>
        /// Происходит при изменении свойства Modified
        /// </summary>
        public event EventHandler ModifiedChanged;


        /// <summary>
        /// Конструктор
        /// </summary>
        public WinInfo()
        {
            modified = false;
            TreeNode = null;
            TabPanel = null;
            ModifiedChanged = null;
        }
    }
}
