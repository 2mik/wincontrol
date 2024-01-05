namespace WinControls
{
    /// <summary>
    /// Provides data for the ChildFormClosed event.
    /// <para>Предоставляет данные для события ChildFormClosed.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2018
    /// </remarks>
    public class ChildFormClosedEventArgs : FormClosedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ChildFormClosedEventArgs(CloseReason closeReason, Form childForm)
            : base(closeReason)
        {
            ChildForm = childForm;
        }

        /// <summary>
        /// Gets the child form that is closed.
        /// </summary>
        public Form ChildForm { get; }
    }
}
