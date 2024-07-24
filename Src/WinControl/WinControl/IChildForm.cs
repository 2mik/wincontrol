namespace WinControls
{
    /// <summary>
    /// Provides efficient way to control child form by a WinControl control.
    /// <para>Обеспечивает эффективное управление дочерней формой с помощью элемента управления WinControl.</para>
    /// </summary>
    public interface IChildForm
    {
        /// <summary>
        /// Gets or sets the object associated with the form.
        /// </summary>
        ChildFormTag ChildFormTag { get; set; }

        /// <summary>
        /// Saves the changes of the child form data.
        /// </summary>
        void Save();
    }
}
