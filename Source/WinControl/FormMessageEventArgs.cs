using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// Provides data for a form message event.
    /// <para>Предоставляет данные для события сообщения формы.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2018
    /// </remarks>
    public class FormMessageEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public FormMessageEventArgs(Form source, string message, Dictionary<string, object> arguments)
        {
            Source = source;
            Message = message;
            Arguments = arguments;
            Cancel = false;
        }


        /// <summary>
        /// Gets the form initiated the event.
        /// </summary>
        public Form Source { get; }

        /// <summary>
        /// Gets the message to send.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets the arguments of the message.
        /// </summary>
        public Dictionary<string, object> Arguments { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the event should be canceled.
        /// </summary>
        public bool Cancel { get; set; }
    }
}
