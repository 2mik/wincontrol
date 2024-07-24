namespace WinControls
{
    /// <summary>
    /// Represents child form display options.
    /// <para>Представляет параметры отображения дочерней формы.</para>
    /// </summary>
    public class ChildFormOptions
    {
        /// <summary>
        /// Gets the tooltip for the tab page.
        /// </summary>
        public string Hint { get; set; } = "";

        /// <summary>
        /// Gets the icon for the tab page.
        /// </summary>
        public Image Image { get; set; } = null;
    }
}
