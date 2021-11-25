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
    /// Author: Mikhail Shiryaev, 2018-2019, 2021
    /// </remarks>
    public class FormMessageEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public FormMessageEventArgs(Control source, string message, Dictionary<string, object> arguments)
        {
            Source = source;
            Message = message;
            Arguments = arguments;
            Cancel = false;
        }


        /// <summary>
        /// Gets the control or form initiated the event.
        /// </summary>
        public Control Source { get; }

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


        /// <summary>
        /// Gets an argument by key if present, otherwise returns null.
        /// </summary>
        public object GetArgument(string key)
        {
            return Arguments != null && Arguments.TryGetValue(key, out object value) ? value : null;
        }
    }
}
