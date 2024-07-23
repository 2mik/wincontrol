namespace WinControls
{
    /// <summary>
    /// Represents a page with a tab.
    /// <para>Представляет страницу с закладкой.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2018, 2024
    /// </remarks>
    internal class TabPage
    {
        /// <summary>
        /// Gets the panel represents the tab page.
        /// </summary>
        public Panel TabPanel { get; init; }

        /// <summary>
        /// Gets the child form with the page content.
        /// </summary>
        public Form ChildForm { get; init; }

        /// <summary>
        /// Gets the page's icon.
        /// </summary>
        public Image Image { get; init; }
    }
}
