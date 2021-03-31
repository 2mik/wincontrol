using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WinControl
{
    /// <summary>
    /// Represents a control used to group collections of controls.
    /// </summary>
    /// <para>Элемент управления, используемый для группировки наборов элементов.</para>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010
    /// </remarks>
    [Designer(typeof(GroupPanel.Designer))]
    public partial class GroupPanel : UserControl
    {
        /// <summary>
        /// Extends the design mode behavior of a GroupPanel.
        /// </summary>
        /// <para>Класс, задающий поведение GroupPanel в режиме дизайна.</para>
        public class Designer : ParentControlDesigner
        {
            /// <summary>
            /// Initializes the designer with the specified component.
            /// </summary>
            public override void Initialize(IComponent component)
            {
                base.Initialize(component);

                GroupPanel groupPanel = component as GroupPanel;
                EnableDesignMode(groupPanel.ContentPanel, groupPanel.ContentPanel.Name);
            }
        }


        private string titleText;
        private Color titleTopColor;
        private Color titleBottomColor;
        private Color titleFrameColor;

        private Color contentTopColor;
        private Color contentBottomColor;
        private Color contentFrameColor;

        private Pen titleFramePen;
        private Pen contentFramePen;


        /// <summary>
        /// Initializes a new instance of the GroupPanel class.
        /// <para>Конструктор.</para>
        /// </summary>
        public GroupPanel()
        {
            InitializeComponent();

            titleText = "";
            titleTopColor = Color.FromArgb(221, 220, 203);
            titleBottomColor = Color.FromArgb(196, 193, 176);
            titleFrameColor = Color.FromArgb(120, 120, 120);

            contentTopColor = Color.White;
            contentBottomColor = Color.FromArgb(232, 230, 215);
            contentFrameColor = Color.FromArgb(150, 150, 150);

            titleFramePen = new Pen(titleFrameColor);
            contentFramePen = new Pen(contentFrameColor);
        }


        /// <summary>
        /// Gets or sets a value indicating whether the panel is in the expanded state.
        /// </summary>
        /// <para>Получить или установить значение, определяющее, что панель развёрнута.</para>
        [Category("GroupPanel"), DefaultValue(true)]
        [Description("Indicates whether the panel is in the expanded state. Определяет, что панель развёрнута.")]
        public bool Expanded
        {
            get
            {
                return pnlContent.Visible;
            }
            set
            {
                if (value)
                    Expand();
                else
                    Collapse();
            }
        }

        /// <summary>
        /// Gets or sets the panel's title text. 
        /// </summary>
        /// <para>Получить или установить текст заголовка панели.</para>
        [Category("GroupPanel"), DefaultValue(""), Localizable(true)]
        [Description("The panel's title text. Текст заголовка панели.")]
        public string TitleText
        {
            get
            {
                return titleText;
            }
            set
            {
                titleText = value;
                pnlTitle.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the title's top part.
        /// </summary>
        /// <para>Получить или установить цвет верхней части заголовка.</para>
        [Category("GroupPanel"), DefaultValue(typeof(Color), "221, 220, 203")]
        [Description("The color of the title's top part. Цвет верхней части заголовка.")]
        public Color TitleTopColor
        {
            get
            {
                return titleTopColor;
            }
            set
            {
                titleTopColor = value;
                pnlTitle.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the title's bottom part.
        /// </summary>
        /// <para>Получить или установить цвет нижней части заголовка.</para>
        [Category("GroupPanel"), DefaultValue(typeof(Color), "196, 193, 176")]
        [Description("The color of the title's bottom part. Цвет нижней части заголовка.")]
        public Color TitleBottomColor
        {
            get
            {
                return titleBottomColor;
            }
            set
            {
                titleBottomColor = value;
                pnlTitle.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the title's frame.
        /// </summary>
        /// <para>Получить или установить цвет рамки заголовка.</para>
        [Category("GroupPanel"), DefaultValue(typeof(Color), "120, 120, 120")]
        [Description("The color of the title's frame. Цвет рамки заголовка.")]
        public Color TitleFrameColor
        {
            get
            {
                return titleFrameColor;
            }
            set
            {
                titleFrameColor = value;
                titleFramePen = new Pen(titleFrameColor);
                pnlTitle.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the content's top part.
        /// </summary>
        /// <para>Получить или установить цвет верхней части содержимого.</para>
        [Category("GroupPanel"), DefaultValue(typeof(Color), "White")]
        [Description("The color of the content's top part. Цвет верхней части содержимого.")]
        public Color ContentTopColor
        {
            get
            {
                return contentTopColor;
            }
            set
            {
                contentTopColor = value;
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the content's bottom part.
        /// </summary>
        /// <para>Получить или установить цвет нижней части содержимого.</para>
        [Category("GroupPanel"), DefaultValue(typeof(Color), "232, 230, 215")]
        [Description("The color of the content's bottom part. Цвет нижней части содержимого.")]
        public Color ContentBottomColor
        {
            get
            {
                return contentBottomColor;
            }
            set
            {
                contentBottomColor = value;
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the content's frame.
        /// </summary>
        /// <para>Получить или установить цвет рамки содержимого.</para>
        [Category("GroupPanel"), DefaultValue(typeof(Color), "150, 150, 150")]
        [Description("The color of the content's frame. Цвет рамки содержимого.")]
        public Color ContentFrameColor
        {
            get
            {
                return contentFrameColor;
            }
            set
            {
                contentFrameColor = value;
                contentFramePen = new Pen(contentFrameColor);
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the panel contains child controls.
        /// </summary>
        /// <para>Получить или установить панель, содержающую дочерние элементы.</para>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("The panel contains child controls. Панель, содержающая дочерние элементы.")]
        public Panel ContentPanel
        {
            get
            {
                return pnlContent;
            }
        }


        /// <summary>
        /// Raises the TitleClick event.
        /// <para>Вызвать событие TitleClick.</para>
        /// </summary>
        protected virtual void OnTitleClick(EventArgs e)
        {
            if (TitleClick != null)
                TitleClick(this, e);
        }

        /// <summary>
        /// Collapses the panel.
        /// </summary>
        /// <para>Свернуть панель.</para>
        public void Collapse()
        {
            pnlContent.Visible = false;
            Height = pnlTitle.Height;
        }

        /// <summary>
        /// Expands the panel.
        /// </summary>
        /// <para>Развернуть панель.</para>
        public void Expand()
        {
            if (!pnlContent.Visible)
            {
                Height = pnlTitle.Height + pnlContent.Height;
                pnlContent.Visible = true;
                pnlContent.Invalidate();
            }
        }


        /// <summary>
        /// Occurs when the panel's title is clicked.
        /// <para>Происходит при щелчке по заголовку панели.</para>
        /// </summary>
        [Category("GroupPanel")]
        [Description("Occurs when the panel's title is clicked. Происходит при щелчке по заголовку панели.")]
        public event EventHandler TitleClick;


        private void pnlTitle_Click(object sender, EventArgs e)
        {
            OnTitleClick(EventArgs.Empty);
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Control control = sender as Control;
            int width = pnlTitle.Width;
            int height = pnlTitle.Height;

            Rectangle rect = new Rectangle(0, 0, width - 1, height - 1);
            graphics.DrawRectangle(titleFramePen, rect);

            rect = new Rectangle(1, 1, width - 2, height - 2);
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, 
                titleTopColor, titleBottomColor, 90);
            graphics.FillRectangle(brush, rect);

            SizeF sizeF = graphics.MeasureString(titleText, control.Font);
            graphics.DrawString(titleText, control.Font, Brushes.Black,
                10, (height - sizeF.Height) / 2);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int width = pnlContent.Width;
            int height = pnlContent.Height;

            Rectangle rect = new Rectangle(0, -1, width - 1, height);
            graphics.DrawRectangle(contentFramePen, rect);

            rect = new Rectangle(1, 0, width - 2, height - 1);
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                rect, contentTopColor, contentBottomColor, 90);
            graphics.FillRectangle(brush, rect);
        }
    }
}