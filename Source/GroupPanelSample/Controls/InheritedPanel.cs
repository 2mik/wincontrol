/*
 * The sample of the user control derived from GroupPanel.
 * Developer:
 * 2010, Mikhail Shiryaev
 * 
 * Пример пользовательского элемента управления, унаследованного от GroupPanel.
 * Разработчик:
 * 2010, Ширяев Михаил
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupPanelSample.Controls
{
    /// <summary>
    /// The sample of the user control derived from GroupPanel.
    /// </summary>
    /// <para>Пример пользовательского элемента управления, унаследованного от GroupPanel.</para>
    public partial class InheritedPanel : WinControl.GroupPanel
    {
        public InheritedPanel()
        {
            InitializeComponent();
        }
    }
}
