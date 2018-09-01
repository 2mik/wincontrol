using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace WinControl
{
    /// <summary>
    /// Represents a control that contains multiple forms that share the same space on the screen.
    /// <para>Элемент управления, содержащий набор форм, которые используют общее пространство на экране.</para>
    /// </summary>
    /// <remarks>
    /// Author: Mikhail Shiryaev, 2010, 2018
    /// </remarks>
    public partial class WinControl : UserControl
    {
        /// <summary>
        /// Version of the control.
        /// <para>Версия элемента управления.</para>
        /// </summary>
        public const string Version = "1.0.1.0";

        private List<TabPage> tabPageList; // list of tab pages (список страниц)
        private TabPage selectedTab;       // selected tab page (выбранная страница)
        private bool formClosing;          // form is closing on one's own (форма закрывается самостоятельно)

        #region Objects for painting tabs and border
        // Объекты для отображения закладок и рамки страницы
        private Font tabFont;
        private Font tabSelectedFont;
        private Font messageFont;
        private Color messageColor;
        private Brush messageBrush;
        private StringFormat messageFormat;
        private string messageText;
        private Image image;

        private ColorScheme colorScheme;
        private Pen frameExtPen;
        private Pen frameIntPen;
        private Pen frameLightPen;
        private Pen tabFramePen;
        private Pen tabBackPen;
        #endregion


        /// <summary>
        /// Initializes a new instance of the WinControl class.
        /// <para>Конструктор.</para>
        /// </summary>
        public WinControl()
        {
            InitializeComponent();

            tabPageList = new List<TabPage>();
            selectedTab = null;
            formClosing = false;

            tabFont = (Font)Font.Clone();
            tabSelectedFont = new Font(tabFont, FontStyle.Bold);
            messageFont = (Font)Font.Clone();
            messageColor = Color.Gray;
            messageBrush = new SolidBrush(messageColor);
            messageFormat = new StringFormat(StringFormat.GenericDefault);
            messageFormat.Alignment = StringAlignment.Center;
            messageText = "";
            image = null;

            AllowToOrderTabs = true;
            ButtonsVisible = true;
            ControlColorScheme = ColorScheme.Blue;
            SaveReqCaption = "Save changes";
            SaveReqQuestion = "Save changes to the following items?";
            SaveReqYes = "&Yes";
            SaveReqNo = "&No";
            SaveReqCancel = "Cancel";
        }


        /// <summary>
        /// Gets the active form.
        /// <para>Получить активную форму.</para>
        /// </summary>
        public Form ActiveForm
        {
            get
            {
                return selectedTab == null ? null : selectedTab.ChildForm;
            }
        }

        /// <summary>
        /// Gets the list of forms contained within the control.
        /// <para>Получить список форм, которые содержит элемент управления.</para>
        /// </summary>
        public List<Form> Forms
        {
            get
            {
                List<Form> forms = new List<Form>();
                foreach (TabPage tabPage in tabPageList)
                {
                    Form form = tabPage.ChildForm;
                    if (form != null)
                        forms.Add(form);
                }
                return forms;
            }
        }

        /// <summary>
        /// Gets the number of forms in the tab strip.
        /// <para>Получить количество форм (закладок).</para>
        /// </summary>
        public int FormCount
        {
            get
            {
                return tabPageList.Count;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether manual tab repositioning is enabled.
        /// <para>Получить или установить значение, определяющее возможность перестановки закладок.</para>
        /// </summary>
        [Category("WinControl"), DefaultValue(true)]
        [Description("Indicates whether manual tab repositioning is enabled. Определяет возможность перестановки закладок.")]
        public bool AllowToOrderTabs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the buttons are displayed.
        /// <para>Получить или установить значение, определяющее видимость кнопок.</para>
        /// </summary>
        [Category("WinControl"), DefaultValue(true)]
        [Description("Indicates whether the buttons are displayed. Определяет видимость кнопок.")]
        public bool ButtonsVisible
        {
            get
            {
                return pnlTabsRight.Width > 1;
            }
            set
            {
                pnlTabsRight.Width = value ? 45 : 1;
                btnTabs.Visible = btnClose.Visible = value;
            }
        }

        /// <summary>
        /// Gets or sets the color scheme of the control.
        /// <para>Получить или установить цветовую схему элемента управления.</para>
        /// </summary>
        [Category("WinControl"), DefaultValue(ColorScheme.Blue)]
        [Description("The color scheme of the control. Цветовая схема элемента управления.")]
        public ColorScheme ControlColorScheme
        {
            get
            {
                return colorScheme;
            }
            set
            {
                colorScheme = value;
                switch (value)
                {
                    case ColorScheme.Blue:
                        frameExtPen = new Pen(Color.FromArgb(152, 181, 226));
                        frameIntPen = new Pen(Color.FromArgb(193, 210, 238));
                        frameLightPen = new Pen(Color.FromArgb(225, 230, 232));
                        tabFramePen = new Pen(Color.FromArgb(172, 168, 153));
                        tabBackPen = new Pen(Color.FromArgb(236, 233, 216));
                        break;
                    case ColorScheme.Green:
                        frameExtPen = new Pen(Color.FromArgb(156, 226, 152));
                        frameIntPen = new Pen(Color.FromArgb(195, 238, 193));
                        frameLightPen = new Pen(Color.FromArgb(228, 232, 225));
                        tabFramePen = new Pen(Color.FromArgb(172, 168, 153));
                        tabBackPen = new Pen(Color.FromArgb(236, 233, 216));
                        break;
                    case ColorScheme.Gray:
                        frameExtPen = new Pen(Color.FromArgb(179, 179, 179));
                        frameIntPen = new Pen(Color.FromArgb(208, 208, 208));
                        frameLightPen = new Pen(Color.FromArgb(228, 228, 228));
                        tabFramePen = new Pen(Color.FromArgb(168, 168, 168));
                        tabBackPen = new Pen(Color.FromArgb(232, 232, 232));
                        break;
                }

                foreach (TabPage tabPage in tabPageList)
                    tabPage.TabPanel.Invalidate();
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the image displayed by the control when pages don't exist.
        /// <para>Получить или установить рисунок, отображаемый элементом управления, когда страницы отсутствуют.</para>
        /// </summary>
        [Category("WinControl")]
        [Description("The image displayed by the control when pages don't exist. Рисунок, отображаемый элементом управления, когда страницы отсутствуют.")]
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the message text displayed by the control when pages don't exists.
        /// <para>Получить или установить текст сообщения, отображаемый элементом управления, когда страницы отсутствуют.</para>
        /// </summary>
        [Category("WinControl"), DefaultValue(""), Localizable(true)]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        [Description("The message text displayed by the control when pages don't exists. Текст сообщения, отображаемый элементом управления, когда страницы отсутствуют.")]
        public string MessageText
        {
            get
            {
                return messageText;
            }
            set
            {
                messageText = value;
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the font of the message displayed by the control.
        /// <para>Получить или установить шрифт текста сообщения.</para>
        /// </summary>
        [Category("WinControl")]
        [Description("The font of the message displayed by the control. Шрифт текста сообщения.")]
        public Font MessageFont
        {
            get
            {
                return messageFont;
            }
            set
            {
                messageFont = value == null ? (Font)Font.Clone() : value;
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the message.
        /// <para>Получить или установить цвет текста сообщения.</para>
        /// </summary>
        [Category("WinControl"), DefaultValue(typeof(Color), "Gray")]
        [Description("The color of the message. Цвет текста сообщения.")]
        public Color MessageColor
        {
            get
            {
                return messageColor;
            }
            set
            {
                messageColor = value.IsEmpty ? Color.Gray : value;
                messageBrush = new SolidBrush(messageColor);
                pnlContent.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text to display in the title bar of the save request form.
        /// <para>Получить или установить текст заголовка формы запроса на сохранение данных.</para>
        /// </summary>
        [Category("WinControl Strings"), Localizable(true)]
        [Description("The text to display in the title bar of the save request form. Текст заголовка формы запроса на сохранение данных.")]
        public string SaveReqCaption { get; set; }

        /// <summary>
        /// Gets or sets the question text to display in the save request form.
        /// <para>Получить или установить текст вопроса на сохранение данных.</para>
        /// </summary>
        [Category("WinControl Strings"), Localizable(true)]
        [Description("The question text to display in the save request form. Текст вопроса на сохранение данных.")]
        public string SaveReqQuestion { get; set; }

        /// <summary>
        /// Gets or sets the 'Yes' button text to display in the save request form.
        /// <para>Получить или установить текст кнопки 'Да' на форме запроса на сохранение данных.</para>
        /// </summary>
        [Category("WinControl Strings"), Localizable(true)]
        [Description("The 'Yes' button text to display in the save request form. Текст кнопки 'Да' на форме запроса на сохранение данных")]
        public string SaveReqYes { get; set; }
        
        /// <summary>
        /// Gets or sets the 'No' button text to display in the save request form.
        /// <para>Получить или установить текст кнопки 'Нет' на форме запроса на сохранение данных.</para>
        /// </summary>
        [Category("WinControl Strings"), Localizable(true)]
        [Description("The 'No' button text to display in the save request form. Текст кнопки 'Нет' на форме запроса на сохранение данных")]
        public string SaveReqNo { get; set; }

        /// <summary>
        /// Gets or sets the 'Cancel' button text to display in the save request form.
        /// <para>Получить или установить текст кнопки 'Отмена' на форме запроса на сохранение данных.</para>
        /// </summary>
        [Category("WinControl Strings"), Localizable(true)]
        [Description("The 'Cancel' button text to display in the save request form. Текст кнопки 'Отмена' на форме запроса на сохранение данных")]
        public string SaveReqCancel { get; set; }
            

        /// <summary>
        /// Tunes heights and margins of the tabs.
        /// <para>Настроить высоту и поля закладок.</para>
        /// </summary>
        private void TuneTabPanels()
        {
            int num = 0;
            int height1 = flpnlTabsLeft.Height - 3; // 17, if desktop font size is default (17 при обычном размере шрифта экрана)
            int height2 = height1 - 2;              // 15, if desktop font size is default (15 при обычном размере шрифта экрана)

            foreach (Control control in flpnlTabsLeft.Controls)
            {
                Panel pnlTab = control as Panel;
                if (pnlTab != null)
                {
                    bool first = num == 0;
                    bool selected = selectedTab != null && selectedTab.TabPanel == pnlTab;
                    pnlTab.Margin = new Padding(first ? 3 : 1, selected ? 3 : 5, 0, 0);
                    pnlTab.Height = selected ? height1 : height2;
                    pnlTab.Invalidate();
                    num++;
                }
            }
            pnlContent.Invalidate();
        }

        /// <summary>
        /// Sets the tab's panels visibility depends on the control width.
        /// <para>Установить видимость панелей закладок в зависимости от ширины элемента управления.</para>
        /// </summary>
        private void SetTabPanelsVisible()
        {
            int i = 0;
            int width = 0;
            int pnlWidth = flpnlTabsLeft.Width;
            int controlCnt = flpnlTabsLeft.Controls.Count;

            while (width <= pnlWidth && i < controlCnt)
            {
                Control control = flpnlTabsLeft.Controls[i];
                width += control.Width + control.Margin.Horizontal;
                if (width <= pnlWidth)
                    control.Visible = true;
                i++;
            }

            if (width <= pnlWidth)
                btnTabs.ImageIndex = 0;
            else
            {
                btnTabs.ImageIndex = 1;
                while (i <= controlCnt)
                {
                    flpnlTabsLeft.Controls[i - 1].Visible = false;
                    i++;
                }
            }

            // sets the tab's panel visibility
            // установка видимости всей панели с закладками
            bool visible = tabPageList != null && tabPageList.Count > 0;
            if (pnlTabs.Visible != visible)
                pnlTabs.Visible = visible;
        }

        /// <summary>
        /// Selects a tab by the specified panel.
        /// <para>Выбрать закладку, соответствующую панели.</para>
        /// </summary>
        private void SelectTab(Panel pnlTab)
        {
            if (pnlTab != null)
                SelectTabPage(pnlTab.Tag as TabPage);
        }

        /// <summary>
        /// Moves the tab on another's place.
        /// <para>Переместить одну закладку на место другой.</para>
        /// </summary>
        private void MoveTab(Panel movedTab, Panel shiftedTab)
        {
            TabPage movedTabPage = movedTab.Tag as TabPage;
            TabPage shiftedTabPage = shiftedTab.Tag as TabPage;

            if (movedTabPage != null && shiftedTabPage != null)
            {
                // moves the tab page in the list
                // перемещение в списке страниц
                int i = tabPageList.IndexOf(shiftedTabPage);
                tabPageList.Remove(movedTabPage);
                tabPageList.Insert(i, movedTabPage);

                // moves the panel
                // перемещение элементов панелей закладок
                flpnlTabsLeft.Controls.SetChildIndex(movedTab, flpnlTabsLeft.Controls.IndexOf(shiftedTab));
                TuneTabPanels();
            }
        }

        /// <summary>
        /// Finds a tab page associated with the specified form.
        /// <para>Найти страницу, соответствующую заданной форме.</para>
        /// </summary>
        private TabPage FindTabPage(Form form)
        {
            for (int i = 0; i < tabPageList.Count; i++)
            {
                TabPage tabPage = tabPageList[i];
                if (tabPage.ChildForm == form)
                    return tabPage;
            }
            return null;
        }

        /// <summary>
        /// Finds a tab page associated with the specified form and retrieves page index.
        /// <para>Найти страницу, соответствующую заданной форме, и извлечь индекс страницы.</para>
        /// </summary>
        private TabPage FindTabPage(Form form, out int index)
        {
            for (int i = 0; i < tabPageList.Count; i++)
            {
                TabPage tabPage = tabPageList[i];
                if (tabPage.ChildForm == form)
                {
                    index = i;
                    return tabPage;
                }
            }
            index = -1;
            return null;
        }

        /// <summary>
        /// Selects the tab page.
        /// <para>Выбрать страницу.</para>
        /// </summary>
        private void SelectTabPage(TabPage tabPage)
        {
            if (tabPage != null)
            {
                bool tune = false;
                bool raiseEvent = false;

                if (tabPage != selectedTab)
                {
                    // shows the selected child form
                    // отображение выбранной дочерней формы
                    if (tabPage.ChildForm != null)
                        tabPage.ChildForm.Show();

                    // hides the child form that was selected
                    // hiding should occur after showing to decrease flickering
                    // сокрытие дочерней формы, которая была выбрана ранее
                    // сокрытие должно происходить после отображения, чтобы уменьшить мерцание
                    if (selectedTab != null && selectedTab.ChildForm != null)
                        selectedTab.ChildForm.Hide();

                    selectedTab = tabPage;

                    tune = true;
                    raiseEvent = true;
                }

                // moves the selected tab to the first position if it's invisible
                // перемещение страницы в начало, если она не видна
                if (!tabPage.TabPanel.Visible && tabPage != tabPageList[0])
                {
                    tabPageList.Remove(tabPage);
                    tabPageList.Insert(0, tabPage);
                    flpnlTabsLeft.Controls.SetChildIndex(tabPage.TabPanel, 0);
                    SetTabPanelsVisible();

                    tune = true;
                }

                if (tune)
                    TuneTabPanels();

                // raises the ActiveFormChanged event
                // вызов события ActiveFormChanged
                if (raiseEvent)
                    OnActiveFormChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Closes the tab page. The specified non negative index speed ups the method.
        /// <para>Закрыть страницу. Заданный неотрицательный индекс ускоряет метод.</para>
        /// </summary>
        private void CloseTabPage(TabPage tabPage, int tabPageIndex)
        {
            if (tabPage != null)
            {
                bool raiseEvent = false;

                // defines the tab page index
                // определение индекса страницы
                if (tabPageIndex < 0)
                {
                    tabPageIndex = tabPageList.IndexOf(tabPage);
                }

                // closes the form and removes the tab page
                // зарытие формы и удаление страницы
                Form form = tabPage.ChildForm;
                if (form != null && !formClosing)
                {
                    form.FormClosing -= Form_FormClosing;
                    form.Close();
                    if (form.Visible) // the form hasn't closed (форма не закрылась)
                        form.Hide();
                }
                flpnlTabsLeft.Controls.Remove(tabPage.TabPanel);
                tabPageList.RemoveAt(tabPageIndex);

                // selects the tab page
                // выбор новой страницы
                if (tabPage == selectedTab)
                {
                    int selInd = tabPageIndex > 0 ? tabPageIndex - 1 : 0;
                    selectedTab = tabPageList.Count > 0 ? tabPageList[selInd] : null;
                    raiseEvent = true;
                }

                // shows the child form
                // отображение дочерней формы
                if (selectedTab != null && selectedTab.ChildForm != null)
                    selectedTab.ChildForm.Show();

                TuneTabPanels();
                SetTabPanelsVisible();

                // raises the ActiveFormChanged event
                // вызов события ActiveFormChanged
                if (raiseEvent)
                    OnActiveFormChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Closes all tab pages.
        /// <para>Закрыть все страницы.</para>
        /// </summary>
        private void CloseAllTabPages()
        {
            if (tabPageList.Count > 0)
            {
                foreach (TabPage tabPage in tabPageList)
                {
                    Form form = tabPage.ChildForm;
                    if (form != null)
                    {
                        form.FormClosing -= Form_FormClosing;
                        form.Close();
                        if (form.Visible) // the form hasn't closed (форма не закрылась)
                            form.Hide();
                    }
                    flpnlTabsLeft.Controls.Remove(tabPage.TabPanel);
                }

                tabPageList.Clear();
                selectedTab = null;
                pnlTabs.Visible = false;

                // raises the ActiveFormChanged event
                // вызов события ActiveFormChanged
                OnActiveFormChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Shows the save request form.
        /// <para>Показать форму запроса на сохранение данных.</para>
        /// </summary>
        private void ShowSaveRequest(List<IChildForm> savedItems, out bool cancel)
        {
            FrmSaveRequest frmSaveRequest = new FrmSaveRequest();
            frmSaveRequest.Text = SaveReqCaption;
            frmSaveRequest.lblQuestion.Text = SaveReqQuestion;
            frmSaveRequest.btnYes.Text = SaveReqYes;
            frmSaveRequest.btnNo.Text = SaveReqNo;
            frmSaveRequest.btnCancel.Text = SaveReqCancel;

            cancel = false;
            if (savedItems.Count > 0)
            {
                frmSaveRequest.SavedItems = savedItems;
                switch (frmSaveRequest.ShowDialog())
                {
                    case DialogResult.Yes:
                        foreach (IChildForm item in frmSaveRequest.SavedItems)
                        {
                            try
                            {
                                item.Save();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, SaveReqCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        cancel = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Raises the ActiveFormChanged event.
        /// <para>Вызвать событие ActiveFormChanged.</para>
        /// </summary>
        protected void OnActiveFormChanged(EventArgs e)
        {
            ActiveFormChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the ChildFormClosed event.
        /// <para>Вызвать событие ChildFormClosed.</para>
        /// </summary>
        protected void OnChildFormClosed(ChildFormClosedEventArgs e)
        {
            ChildFormClosed?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the ChildFormMessage event.
        /// <para>Вызвать событие ChildFormMessage.</para>
        /// </summary>
        protected void OnChildFormMessage(FormMessageEventArgs e)
        {
            ChildFormMessage?.Invoke(this, e);
        }


        /// <summary>
        /// Adds a form to the control.
        /// <para>Добавить форму.</para>
        /// </summary>
        public void AddForm(Form form, string hint, Image image, TreeNode treeNode)
        {
            // tests the form for duplicating
            // проверка дублирования формы
            foreach (TabPage tab in tabPageList)
                if (tab.ChildForm != null && tab.ChildForm == form)
                    throw new ArgumentException("The form is duplicated.");

            // hides the child form that was selected
            // сокрытие дочерней формы, которая была выбрана ранее
            if (selectedTab != null && selectedTab.ChildForm != null)
                selectedTab.ChildForm.Hide();

            // measures the form's caption text length
            // измерение длины текста заголовка формы
            Graphics graphics = CreateGraphics();
            string text = form == null ? "null" : form.Text.Trim();
            SizeF sizeF = graphics.MeasureString(text, tabSelectedFont);
            graphics.Dispose();

            // creates the tab's panel
            // создание панели закладки
            Panel pnlNewTab = new Panel()
            {
                Margin = new Padding(3, 3, 0, 0),
                Size = new Size((int)sizeF.Width + 14, 17),
                Text = text,
                AllowDrop = true,
            };
            pnlNewTab.Paint += new PaintEventHandler(pnlTab_Paint);
            pnlNewTab.MouseDown += new MouseEventHandler(pnlTab_MouseDown);
            pnlNewTab.GiveFeedback += new GiveFeedbackEventHandler(pnlTab_GiveFeedback);
            pnlNewTab.DragEnter += new DragEventHandler(pnlTab_DragEnter);

            if (!string.IsNullOrEmpty(hint))
                toolTip.SetToolTip(pnlNewTab, hint);

            // creates the tab page
            // создание страницы с закладкой
            TabPage tabPage = new TabPage()
            {
                TabPanel = pnlNewTab,
                ChildForm = form,
                Image = image
            };
            tabPageList.Insert(0, tabPage);
            pnlNewTab.Tag = tabPage;
            selectedTab = tabPage;

            // adds the tab's panel to the control
            // добавление панели закладки к элементу управления
            Control[] controls = new Control[flpnlTabsLeft.Controls.Count];
            flpnlTabsLeft.Controls.CopyTo(controls, 0);

            flpnlTabsLeft.SuspendLayout();
            flpnlTabsLeft.Controls.Clear();
            flpnlTabsLeft.Controls.Add(pnlNewTab);
            flpnlTabsLeft.Controls.AddRange(controls);

            TuneTabPanels();
            SetTabPanelsVisible();

            flpnlTabsLeft.ResumeLayout(false);
            flpnlTabsLeft.PerformLayout();

            if (form != null)
            {
                // sets up the form
                // настройка формы
                if (form is IChildForm childForm)
                {
                    childForm.ChildFormTag = new ChildFormTag()
                    {
                        Title = form.Text,
                        TreeNode = treeNode,
                        TabPanel = pnlNewTab,
                        ChildForm = form
                    };
                    childForm.ChildFormTag.ModifiedChanged += ChildFormTag_ModifiedChanged;
                    childForm.ChildFormTag.ChildFormMessage += ChildFormTag_ChildFormMessage;
                }

                // shows the form
                // отображение формы
                form.TopLevel = false;
                form.Parent = pnlContent;
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.TextChanged += Form_TextChanged;
                form.FormClosing += Form_FormClosing;
                form.FormClosed += Form_FormClosed;
                form.Show();
            }

            // raises the ActiveFormChanged event
            // вызов события ActiveFormChanged
            OnActiveFormChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Closes a form.
        /// <para>Закрыть форму.</para>
        /// </summary>
        public void CloseForm(Form form, out bool cancel)
        {
            // shows the save request form if the changes are not saved
            // отображение формы запроса на сохранение данных, если изменения не сохранены
            if (form is IChildForm childForm && childForm.ChildFormTag != null && childForm.ChildFormTag.Modified)
            {
                List<IChildForm> savedItems = new List<IChildForm>
                {
                    childForm
                };
                ShowSaveRequest(savedItems, out cancel);
            }
            else
            {
                cancel = false;
            }

            // closes the tab page
            // закрытие страницы
            if (!cancel)
                CloseTabPage(FindTabPage(form, out int index), index);
        }

        /// <summary>
        /// Closes all the forms.
        /// <para>Закрыть все формы.</para>
        /// </summary>
        public void CloseAllForms(out bool cancel)
        {
            // fills the list of the items for saving
            // заполнение списка сохраняемых элементов
            List<IChildForm> savedItems = new List<IChildForm>();
            foreach (TabPage tabPage in tabPageList)
            {
                if (tabPage.ChildForm is IChildForm childForm &&
                    childForm.ChildFormTag != null && childForm.ChildFormTag.Modified)
                {
                    savedItems.Add(childForm);
                }
            }

            // shows the save request form
            // отображение формы запроса на сохранение данных
            ShowSaveRequest(savedItems, out cancel);

            // closes all tab pages
            // закрытие страниц
            if (!cancel)
                CloseAllTabPages();
        }

        /// <summary>
        /// Closes all the forms except the active form.
        /// <para>Закрыть все формы, кроме активной.</para>
        /// </summary>
        public void CloseAllButActive(out bool cancel)
        {
            // fills the list of the items for saving
            // заполнение списка сохраняемых элементов
            List<IChildForm> savedItems = new List<IChildForm>();
            foreach (TabPage tabPage in tabPageList)
            {
                if (tabPage != selectedTab)
                {
                    if (tabPage.ChildForm is IChildForm childForm &&
                        childForm.ChildFormTag != null && childForm.ChildFormTag.Modified)
                    {
                        savedItems.Add(childForm);
                    }
                }
            }

            // shows the save request form
            // отображение формы запроса на сохранение данных
            ShowSaveRequest(savedItems, out cancel);

            // closes the tab pages
            // закрытие страниц
            if (!cancel)
            {
                for (int i = tabPageList.Count - 1; i >= 0; i--)
                {
                    TabPage tabPage = tabPageList[i];
                    if (tabPage != selectedTab)
                        CloseTabPage(tabPage, i);
                }
            }
        }

        /// <summary>
        /// Activates a form.
        /// <para>Активировать форму.</para>
        /// </summary>
        public void ActivateForm(Form form)
        {
            IChildForm childForm = form as IChildForm;
            ChildFormTag childFormTag = childForm?.ChildFormTag;
            if (childFormTag == null)
                SelectTabPage(FindTabPage(form));
            else
                SelectTab(childForm.ChildFormTag.TabPanel);
        }

        /// <summary>
        /// Activates the next form.
        /// <para>Активировать следующую форму.</para>
        /// </summary>
        public void ActivateNext()
        {
            if (tabPageList.Count > 1)
            {
                int ind = selectedTab == null ? -1 : tabPageList.IndexOf(selectedTab);
                if (++ind == tabPageList.Count)
                    ind = 0;
                SelectTabPage(tabPageList[ind]);
            }
        }

        /// <summary>
        /// Activates the previous form.
        /// <para>Активировать предыдущую форму.</para>
        /// </summary>
        public void ActivatePrevious()
        {
            if (tabPageList.Count > 1)
            {
                int ind = selectedTab == null ? -1 : tabPageList.IndexOf(selectedTab);
                if (--ind < 0)
                    ind = tabPageList.Count - 1;
                SelectTabPage(tabPageList[ind]);
            }
        }

        /// <summary>
        /// Updates a hint of a tab page that corresponds to the specified form.
        /// <para>Обновляет подсказку закладки, соответствующей указанной форме.</para>
        /// </summary>
        public void UpdateHint(Form form, string hint)
        {
            Panel tabPanel;

            if (form is IChildForm childForm)
            {
                tabPanel = childForm.ChildFormTag.TabPanel;
            }
            else
            {
                TabPage tabPage = FindTabPage(form);
                tabPanel = tabPage?.TabPanel;
            }

            if (tabPanel != null)
                toolTip.SetToolTip(tabPanel, hint);
        }


        /// <summary>
        /// Occurs when the active form has changed.
        /// <para>Происходит, когда изменяется значение свойства ActiveForm.</para>
        /// </summary>
        [Category("WinControl")]
        [Description("Occurs when the active form has changed. Происходит, когда изменяется значение свойства ActiveForm.")]
        public event EventHandler ActiveFormChanged;

        /// <summary>
        /// Occurs when a child form is closed.
        /// <para>Происходит, когда закрывается дочерняя форма.</para>
        /// </summary>
        [Category("WinControl")]
        [Description("Occurs when a child form is closed. Происходит, когда закрывается дочерняя форма.")]
        public event EventHandler<ChildFormClosedEventArgs> ChildFormClosed;

        /// <summary>
        /// Occurs when a child form sends a message.
        /// <para>Происходит, когда дочерняя форма отправляет сообщение.</para>
        /// </summary>
        [Category("WinControl")]
        [Description("Occurs when a child form sends a message. Происходит, когда дочерняя форма отправляет сообщение.")]
        public event EventHandler<FormMessageEventArgs> ChildFormMessage;


        private void WinControl_BackColorChanged(object sender, EventArgs e)
        {
            flpnlTabsLeft.BackColor = BackColor;
            pnlTabsRight.BackColor = BackColor;
        }

        private void WinControl_FontChanged(object sender, EventArgs e)
        {
            tabFont = (Font)Font.Clone();
            tabSelectedFont = new Font(tabFont, FontStyle.Bold);
            messageFont = (Font)Font.Clone();
        }


        private void flpnlTabsLeft_Resize(object sender, EventArgs e)
        {
            SetTabPanelsVisible();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
            // control's border
            // рамка вокруг элемента управления
            Graphics graphics = e.Graphics;
            int width = pnlContent.Width;
            int height = pnlContent.Height;

            Rectangle rect = new Rectangle(1, 1, width - 3, height - 3);
            graphics.DrawRectangle(frameLightPen, rect);
            rect.Inflate(-1, -1);
            graphics.DrawRectangle(frameIntPen, rect);
            rect.Inflate(-1, -1);
            graphics.DrawRectangle(frameIntPen, rect);
            rect.Inflate(-1, -1);
            graphics.DrawRectangle(frameExtPen, rect);

            graphics.DrawLines(frameExtPen, new Point[]{ new Point(2, 0), new Point(width - 3, 0), 
                new Point(width - 1, 2), new Point(width - 1, height - 3), new Point(width - 3, height - 1), 
                new Point(2, height - 1), new Point(0, height - 3), new Point(0, 2), new Point(2, 0)});

            // clears border at the selected tab
            // удаление границы с выбранной закладкой
            if (selectedTab != null && selectedTab.TabPanel.Visible)
                graphics.DrawRectangle(frameIntPen, selectedTab.TabPanel.Left + 1, 0, 
                    selectedTab.TabPanel.Width - 3, 1);

            // image and message text
            // рисунок и текст сообщения
            if (tabPageList.Count == 0)
            {
                // defines the sizes
                // определение размеров
                int imgWidth = image == null ? 0 : image.Width;
                int imgHeight = image == null ? 0 : image.Height;

                int msgHeight;
                int msgWidth;
                if (string.IsNullOrEmpty(messageText))
                {
                    msgHeight = 0;
                    msgWidth = 0;
                }
                else
                {
                    SizeF sizeF = graphics.MeasureString(messageText, MessageFont);
                    msgHeight = (int)sizeF.Height;
                    msgWidth = (int)sizeF.Width;
                }
                int totalHeight = imgHeight + msgHeight;
                if (imgHeight > 0)
                    totalHeight += (int)graphics.MeasureString("ABC", MessageFont).Height;

                // drawing
                // отображение
                if (image != null)
                    graphics.DrawImageUnscaled(image, (width - imgWidth) / 2, (height - totalHeight) / 2);

                if (!string.IsNullOrEmpty(messageText))
                    graphics.DrawString(MessageText, MessageFont, messageBrush, width / 2,
                        (height + totalHeight) / 2 - msgHeight, messageFormat);
            }
        }

        private void pnlContent_Resize(object sender, EventArgs e)
        {
            pnlContent.Invalidate();
        }


        private void pnlTab_Paint(object sender, PaintEventArgs e)
        {
            // draws the tab
            // отображение закладки
            Graphics graphics = e.Graphics;
            Control control = sender as Control;
            int width = control.Width;
            int height = control.Height;
            bool selected = selectedTab != null && selectedTab.TabPanel == sender;

            graphics.DrawLines(selected ? frameExtPen : tabFramePen, new Point[]{ 
                new Point(0, height - 1), new Point(0, 2), new Point(2, 0), new Point(width - 3, 0), 
                new Point(width - 1, 2), new Point(width - 1, height - 1) });

            graphics.DrawLine(Pens.White, 1, 2, 1, height - 1);
            graphics.DrawLine(selected ? Pens.White : tabBackPen, width - 2, 2, width - 2, height - 1);

            Rectangle rect = new Rectangle(2, 1, width - 4, height - 1);
            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.White,
                selected ? frameIntPen.Color : tabBackPen.Color, 90);
            graphics.FillRectangle(brush, rect);

            Font font = selected ? tabSelectedFont : tabFont;
            SizeF sizeF = graphics.MeasureString(control.Text, font);
            graphics.DrawString(control.Text, font, Brushes.Black, (width - sizeF.Width) / 2, 
                (height - sizeF.Height) / 2);
        }

        private void pnlTab_MouseDown(object sender, MouseEventArgs e)
        {
            Panel pnlTab = (Panel)sender;
            SelectTab(pnlTab);
            if (AllowToOrderTabs)
                pnlTab.DoDragDrop(pnlTab, DragDropEffects.None);
        }

        private void pnlTab_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
            Cursor.Current = Cursors.Default;
        }

        private void pnlTab_DragEnter(object sender, DragEventArgs e)
        {
            Panel movedTab = e.Data.GetData(typeof(Panel)) as Panel;
            if (movedTab != null && movedTab != sender)
                MoveTab(movedTab, (Panel)sender);
        }


        private void btnTabs_Click(object sender, EventArgs e)
        {
            pnlTabsRight.Focus();

            // fills the popup menu
            // заполнение выпадающего меню
            contextTabs.Items.Clear();
            foreach (TabPage tabPage in tabPageList)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = tabPage;
                item.Image = tabPage.Image;
                if (tabPage == selectedTab)
                    item.Font = new Font(item.Font, FontStyle.Bold);
                item.Text = tabPage.ChildForm == null ? "null" : tabPage.ChildForm.Text;
                item.Click += new EventHandler(miTab_Click);

                contextTabs.Items.Add(item);
            }

            // shows the popup menu
            // отображение выпадающего меню
            contextTabs.Show(btnTabs, 0, btnTabs.Height);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlTabsRight.Focus();

            if (selectedTab != null)
            {
                // shows the save request form if the changes are not saved
                // отображение формы запроса на сохранение данных, если изменения не сохранены
                IChildForm itfWin = selectedTab.ChildForm as IChildForm;
                bool cancel;
                if (itfWin != null && itfWin.ChildFormTag != null && itfWin.ChildFormTag.Modified)
                {
                    List<IChildForm> savedItems = new List<IChildForm>();
                    savedItems.Add(itfWin);
                    ShowSaveRequest(savedItems, out cancel);
                }
                else
                    cancel = false;

                // closes the tab page
                // закрытие страницы
                if (!cancel)
                    CloseTabPage(selectedTab, -1);
            }
        }

        private void miTab_Click(object sender, EventArgs e)
        {
            SelectTabPage((TabPage)((ToolStripMenuItem)sender).Tag);
        }


        private void Form_TextChanged(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            TabPage tabPage = FindTabPage(form);
            if (form != null && tabPage != null)
            {
                Graphics graphics = CreateGraphics();
                string text = form.Text.Trim();
                SizeF sizeF = graphics.MeasureString(text, tabSelectedFont);
                graphics.Dispose();

                Panel pnlTab = tabPage.TabPanel;
                pnlTab.Width = (int)sizeF.Width + 14;
                pnlTab.Text = text;

                TuneTabPanels();
                SetTabPanelsVisible();

                if (tabPage == selectedTab)
                    SelectTabPage(tabPage);
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bool cancel;
                formClosing = true;
                CloseForm(sender as Form, out cancel);
                e.Cancel = cancel;
            }
            finally
            {
                formClosing = false;
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnChildFormClosed(new ChildFormClosedEventArgs(e.CloseReason, (Form)sender));
        }

        private void ChildFormTag_ModifiedChanged(object sender, EventArgs e)
        {
            // displays "*" on the tab if the form's data changed
            // отображение "*" на панели закаладки при изменении данных
            if (sender is ChildFormTag childFormTag)
            {
                childFormTag.TabPanel.Text = childFormTag.Title + (childFormTag.Modified ? "*" : "");
                childFormTag.TabPanel.Invalidate();
            }
        }

        private void ChildFormTag_ChildFormMessage(object sender, FormMessageEventArgs e)
        {
            OnChildFormMessage(e);
        }
    }
}
