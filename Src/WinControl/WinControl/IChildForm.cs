namespace WinControls
{
    /// <summary>
    /// Provides efficient way to control child form by a WinControl control.
    /// <para>Обеспечивает эффективное управление дочерней формой с помощью элемента управления WinControl.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010, 2018
    /// </remarks>
    public interface IChildForm
    {
        /// <summary>
        /// Получить или установить информацию о контролируемом окне
        /// </summary>
        ChildFormTag ChildFormTag { get; set; }

        /// <summary>
        /// Saves the changes of the child form data.
        /// </summary>
        void Save();
    }
}
