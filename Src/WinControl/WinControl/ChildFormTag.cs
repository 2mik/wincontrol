namespace WinControls
{
    /// <summary>
    /// Represents an object associated with a child form.
    /// <para>Представляет объект, связанный с дочерней формой.</para>
    /// </summary>
    public class ChildFormTag
    {
        private bool modified; // indicates that the child form data were modified


        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        public ChildFormTag()
        {
            modified = false;
            TreeNode = null;
            TabPanel = null;
            ChildForm = null;
            Options = null;
        }

        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        public ChildFormTag(ChildFormOptions options)
            : this()
        {
            Options = options;
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
        /// Gets or sets the child form diplay options.
        /// </summary>
        public ChildFormOptions Options { get; set; }


        /// <summary>
        /// Raises a ModifiedChanged event.
        /// </summary>
        protected void OnModifiedChanged(EventArgs e)
        {
            ModifiedChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Raises a MessageFromChildForm event.
        /// </summary>
        protected void OnMessageFromChildForm(FormMessageEventArgs e)
        {
            MessageFromChildForm?.Invoke(this, e);
            ChildFormMessage?.Invoke(this, e);
        }

        /// <summary>
        /// Raises a MessageToChildForm event.
        /// </summary>
        protected void OnMessageToChildForm(FormMessageEventArgs e)
        {
            MessageToChildForm?.Invoke(this, e);
            MainFormMessage?.Invoke(this, e);
        }

        /// <summary>
        /// Sends the message from a child form to other forms or vice versa.
        /// </summary>
        public bool SendMessage(Control source, string message, Dictionary<string, object> arguments = null)
        {
            FormMessageEventArgs eventArgs = new(source, message, arguments);

            if (source == ChildForm)
                OnMessageFromChildForm(eventArgs);
            else
                OnMessageToChildForm(eventArgs);

            return !eventArgs.Cancel;
        }


        /// <summary>
        /// Occurs when the Modified property changed.
        /// </summary>
        public event EventHandler ModifiedChanged;

        /// <summary>
        /// Occurs when the child form sends a message to another form that subscribed to this event.
        /// </summary>
        public event EventHandler<FormMessageEventArgs> MessageFromChildForm;

        /// <summary>
        /// Occurs when another form sends a message to the child form.
        /// </summary>
        public event EventHandler<FormMessageEventArgs> MessageToChildForm;

        /// <summary>
        /// Occurs when a child form sends a message.
        /// </summary>
        [Obsolete("Use the MessageFromChildForm event.")]
        public event EventHandler<FormMessageEventArgs> ChildFormMessage;

        /// <summary>
        /// Occurs when the main form or another child form sends a message.
        /// </summary>
        [Obsolete("Use the MessageToChildForm event.")]
        public event EventHandler<FormMessageEventArgs> MainFormMessage;
    }
}
