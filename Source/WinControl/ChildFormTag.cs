using System;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// Represents an object associated with a child form.
    /// <para>Представляет объект, связанный с дочерней формой.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010, 2018
    /// </remarks>
    public class ChildFormTag
    {
        private bool modified; // indicates that the child form data were modified


        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        public ChildFormTag()
        {
            modified = false;
            Title = "";
            TreeNode = null;
            TabPanel = null;
            ModifiedChanged = null;
        }


        /// <summary>
        /// Gets or sets a value indicating whether the child form data were modified.
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
                    OnModifiedChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets the title of the child form.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the tree node associated with the child form.
        /// </summary>
        public TreeNode TreeNode { get; set; }

        /// <summary>
        /// Gets or sets the panel that represents the tab of the child form.
        /// </summary>
        public Panel TabPanel { get; set; }


        /// <summary>
        /// Raises the ModifiedChanged event.
        /// </summary>
        protected virtual void OnModifiedChanged(EventArgs e)
        {
            ModifiedChanged?.Invoke(this, e);
        }


        /// <summary>
        /// Occurs when the Modified property changed.
        /// </summary>
        public event EventHandler ModifiedChanged;
    }
}
