using System;
using System.Collections.Generic;
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
        /// Gets or sets the form that contains the tag.
        /// </summary>
        public Form ChildForm { get; set; }


        /// <summary>
        /// Raises the ModifiedChanged event.
        /// </summary>
        protected void OnModifiedChanged(EventArgs e)
        {
            ModifiedChanged?.Invoke(this, e);
        }
        
        /// <summary>
        /// Raises the ChildFormMessage event.
        /// </summary>
        protected void OnChildFormMessage(FormMessageEventArgs e)
        {
            ChildFormMessage?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the MainFormMessage event.
        /// </summary>
        protected void OnMainFormMessage(FormMessageEventArgs e)
        {
            MainFormMessage?.Invoke(this, e);
        }

        /// <summary>
        /// Sends the message from a child form to a main form or vice versa.
        /// </summary>
        public bool SendMessage(Form source, string message, Dictionary<string, object> arguments = null)
        {
            FormMessageEventArgs eventArgs = new FormMessageEventArgs(source, message, arguments);

            if (source == ChildForm)
                OnChildFormMessage(eventArgs);
            else
                OnMainFormMessage(eventArgs);

            return !eventArgs.Cancel;
        }


        /// <summary>
        /// Occurs when the Modified property changed.
        /// </summary>
        public event EventHandler ModifiedChanged;

        /// <summary>
        /// Occurs when a child form sends a message.
        /// </summary>
        public event EventHandler<FormMessageEventArgs> ChildFormMessage;

        /// <summary>
        /// Occurs when a main form sends a message.
        /// </summary>
        public event EventHandler<FormMessageEventArgs> MainFormMessage;
    }
}
