namespace WinControls
{
    /// <summary>
    /// Represents a tab page containing a form.
    /// <para>Представляет вкладку, содержащую форму.</para>
    /// </summary>
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
        /// Gets the icon for the tab page.
        /// </summary>
        public Image Image { get; init; }
    }
}
