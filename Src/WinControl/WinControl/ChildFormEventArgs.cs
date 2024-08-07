﻿namespace WinControls
{
    /// <summary>
    /// Provides data for the event related to a child form.
    /// <para>Предоставляет данные для события, относящегося к дочерней форме.</para>
    /// </summary>
    public class ChildFormEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ChildFormEventArgs(Form childForm)
            : base()
        {
            ChildForm = childForm;
        }

        /// <summary>
        /// Gets the corresponding child form.
        /// </summary>
        public Form ChildForm { get; }
    }
}
