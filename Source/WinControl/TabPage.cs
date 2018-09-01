using System.Drawing;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// Page with a tab.
    /// <para>Страница с закладкой.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2018
    /// </remarks>
    internal class TabPage
    {
        /// <summary>
        /// Gets or sets the panel represents the tab page.
        /// <para>Получить или установить панель, представляющую закладку.</para>
        /// </summary>
        public Panel TabPanel { get; set; }

        /// <summary>
        /// Gets or sets the child form with the page content.
        /// <para>Получить или установить дочернюю форму с содержимым страницы.</para>
        /// </summary>
        public Form ChildForm { get; set; }

        /// <summary>
        /// Gets or sets the page's image.
        /// <para>Получить или установить пиктограмму страницы.</para>
        /// </summary>
        public Image Image { get; set; }
    }
}
