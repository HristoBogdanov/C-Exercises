namespace CarShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manufacturerSearchPage = new System.Windows.Forms.TabPage();
            this.manufacturerSearchResult = new System.Windows.Forms.ListBox();
            this.manufacturerSearch = new System.Windows.Forms.Button();
            this.manufacturerSearchInput = new System.Windows.Forms.TextBox();
            this.manufacturerSearchInputLabel = new System.Windows.Forms.Label();
            this.outputPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.inputPage = new System.Windows.Forms.TabPage();
            this.manufacturerInputTitle = new System.Windows.Forms.Label();
            this.partInputTitle = new System.Windows.Forms.Label();
            this.partInputPanel = new System.Windows.Forms.Panel();
            this.partCategoryInput = new System.Windows.Forms.ComboBox();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partDeliveryLabel = new System.Windows.Forms.Label();
            this.partPriceInput = new System.Windows.Forms.TextBox();
            this.partDeliveryInput = new System.Windows.Forms.TextBox();
            this.partCodeInput = new System.Windows.Forms.TextBox();
            this.partNameInput = new System.Windows.Forms.TextBox();
            this.partCategoryLabel = new System.Windows.Forms.Label();
            this.partCodeLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.manufacturerInputPanel = new System.Windows.Forms.Panel();
            this.manufacturerFaxInput = new System.Windows.Forms.TextBox();
            this.manufacturerPhoneInput = new System.Windows.Forms.TextBox();
            this.manufacturerAddressInput = new System.Windows.Forms.TextBox();
            this.manufacturerCountryInput = new System.Windows.Forms.TextBox();
            this.manufacturerNameInput = new System.Windows.Forms.TextBox();
            this.manufacturerFaxLabel = new System.Windows.Forms.Label();
            this.manufacturerPhoneLabel = new System.Windows.Forms.Label();
            this.manufacturerAddressLabel = new System.Windows.Forms.Label();
            this.manufacturerCountryLabel = new System.Windows.Forms.Label();
            this.manufacturerNameLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.shopsPage = new System.Windows.Forms.TabPage();
            this.shopsList = new System.Windows.Forms.ListBox();
            this.brandSearchPage = new System.Windows.Forms.TabPage();
            this.brandSearchPartNameLabel = new System.Windows.Forms.Label();
            this.brandSearchPartNameInput = new System.Windows.Forms.TextBox();
            this.brandSearchResult = new System.Windows.Forms.ListBox();
            this.brandSearch = new System.Windows.Forms.Button();
            this.brandSearchInput = new System.Windows.Forms.TextBox();
            this.brandSearchLabel = new System.Windows.Forms.Label();
            this.shopNameInputLabel = new System.Windows.Forms.Label();
            this.shopAdd = new System.Windows.Forms.Button();
            this.shopNameInput = new System.Windows.Forms.TextBox();
            this.manufacturerSearchPage.SuspendLayout();
            this.outputPage.SuspendLayout();
            this.inputPage.SuspendLayout();
            this.partInputPanel.SuspendLayout();
            this.manufacturerInputPanel.SuspendLayout();
            this.tabs.SuspendLayout();
            this.shopsPage.SuspendLayout();
            this.brandSearchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // manufacturerSearchPage
            // 
            this.manufacturerSearchPage.Controls.Add(this.manufacturerSearchResult);
            this.manufacturerSearchPage.Controls.Add(this.manufacturerSearch);
            this.manufacturerSearchPage.Controls.Add(this.manufacturerSearchInput);
            this.manufacturerSearchPage.Controls.Add(this.manufacturerSearchInputLabel);
            this.manufacturerSearchPage.Location = new System.Drawing.Point(4, 31);
            this.manufacturerSearchPage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerSearchPage.Name = "manufacturerSearchPage";
            this.manufacturerSearchPage.Size = new System.Drawing.Size(1026, 458);
            this.manufacturerSearchPage.TabIndex = 3;
            this.manufacturerSearchPage.Text = "Търсене по име на фирма";
            this.manufacturerSearchPage.UseVisualStyleBackColor = true;
            // 
            // manufacturerSearchResult
            // 
            this.manufacturerSearchResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manufacturerSearchResult.FormattingEnabled = true;
            this.manufacturerSearchResult.ItemHeight = 22;
            this.manufacturerSearchResult.Location = new System.Drawing.Point(0, 146);
            this.manufacturerSearchResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerSearchResult.Name = "manufacturerSearchResult";
            this.manufacturerSearchResult.Size = new System.Drawing.Size(1026, 312);
            this.manufacturerSearchResult.TabIndex = 3;
            // 
            // manufacturerSearch
            // 
            this.manufacturerSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturerSearch.BackColor = System.Drawing.Color.Tan;
            this.manufacturerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manufacturerSearch.Location = new System.Drawing.Point(413, 74);
            this.manufacturerSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerSearch.Name = "manufacturerSearch";
            this.manufacturerSearch.Size = new System.Drawing.Size(400, 48);
            this.manufacturerSearch.TabIndex = 2;
            this.manufacturerSearch.Text = "Изведи";
            this.manufacturerSearch.UseVisualStyleBackColor = false;
            this.manufacturerSearch.Click += new System.EventHandler(this.manufacturerSearch_Click);
            // 
            // manufacturerSearchInput
            // 
            this.manufacturerSearchInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturerSearchInput.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerSearchInput.Location = new System.Drawing.Point(413, 35);
            this.manufacturerSearchInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerSearchInput.Name = "manufacturerSearchInput";
            this.manufacturerSearchInput.Size = new System.Drawing.Size(400, 29);
            this.manufacturerSearchInput.TabIndex = 1;
            // 
            // manufacturerSearchInputLabel
            // 
            this.manufacturerSearchInputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturerSearchInputLabel.AutoSize = true;
            this.manufacturerSearchInputLabel.Location = new System.Drawing.Point(214, 38);
            this.manufacturerSearchInputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacturerSearchInputLabel.Name = "manufacturerSearchInputLabel";
            this.manufacturerSearchInputLabel.Size = new System.Drawing.Size(185, 22);
            this.manufacturerSearchInputLabel.TabIndex = 0;
            this.manufacturerSearchInputLabel.Text = "Въведи име на фирма";
            // 
            // outputPage
            // 
            this.outputPage.Controls.Add(this.listBox1);
            this.outputPage.Location = new System.Drawing.Point(4, 31);
            this.outputPage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.outputPage.Name = "outputPage";
            this.outputPage.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.outputPage.Size = new System.Drawing.Size(1026, 458);
            this.outputPage.TabIndex = 1;
            this.outputPage.Text = "Налична стока";
            this.outputPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(6, 5);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1014, 448);
            this.listBox1.TabIndex = 0;
            // 
            // inputPage
            // 
            this.inputPage.Controls.Add(this.manufacturerInputTitle);
            this.inputPage.Controls.Add(this.partInputTitle);
            this.inputPage.Controls.Add(this.partInputPanel);
            this.inputPage.Controls.Add(this.manufacturerInputPanel);
            this.inputPage.Controls.Add(this.inputButton);
            this.inputPage.Controls.Add(this.clearButton);
            this.inputPage.Location = new System.Drawing.Point(4, 31);
            this.inputPage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputPage.Name = "inputPage";
            this.inputPage.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputPage.Size = new System.Drawing.Size(1026, 458);
            this.inputPage.TabIndex = 0;
            this.inputPage.Text = " Информация за авточастите";
            this.inputPage.UseVisualStyleBackColor = true;
            // 
            // manufacturerInputTitle
            // 
            this.manufacturerInputTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.manufacturerInputTitle.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerInputTitle.Location = new System.Drawing.Point(518, 24);
            this.manufacturerInputTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerInputTitle.Name = "manufacturerInputTitle";
            this.manufacturerInputTitle.Size = new System.Drawing.Size(496, 30);
            this.manufacturerInputTitle.TabIndex = 18;
            this.manufacturerInputTitle.Text = "Въвеждане на фирма\r\n";
            this.manufacturerInputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partInputTitle
            // 
            this.partInputTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.partInputTitle.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInputTitle.Location = new System.Drawing.Point(8, 26);
            this.partInputTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partInputTitle.Name = "partInputTitle";
            this.partInputTitle.Size = new System.Drawing.Size(498, 30);
            this.partInputTitle.TabIndex = 17;
            this.partInputTitle.Text = "Въвеждане на част";
            this.partInputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partInputPanel
            // 
            this.partInputPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.partInputPanel.Controls.Add(this.partCategoryInput);
            this.partInputPanel.Controls.Add(this.partPriceLabel);
            this.partInputPanel.Controls.Add(this.partDeliveryLabel);
            this.partInputPanel.Controls.Add(this.partPriceInput);
            this.partInputPanel.Controls.Add(this.partDeliveryInput);
            this.partInputPanel.Controls.Add(this.partCodeInput);
            this.partInputPanel.Controls.Add(this.partNameInput);
            this.partInputPanel.Controls.Add(this.partCategoryLabel);
            this.partInputPanel.Controls.Add(this.partCodeLabel);
            this.partInputPanel.Controls.Add(this.partNameLabel);
            this.partInputPanel.Location = new System.Drawing.Point(13, 60);
            this.partInputPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.partInputPanel.MaximumSize = new System.Drawing.Size(620, 348);
            this.partInputPanel.Name = "partInputPanel";
            this.partInputPanel.Size = new System.Drawing.Size(494, 348);
            this.partInputPanel.TabIndex = 16;
            // 
            // partCategoryInput
            // 
            this.partCategoryInput.BackColor = System.Drawing.Color.LightGray;
            this.partCategoryInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCategoryInput.FormattingEnabled = true;
            this.partCategoryInput.Items.AddRange(new object[] {
            "Engine",
            "Tires",
            "Exhaust",
            "Suspention",
            "Brake"});
            this.partCategoryInput.Location = new System.Drawing.Point(206, 157);
            this.partCategoryInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.partCategoryInput.Name = "partCategoryInput";
            this.partCategoryInput.Size = new System.Drawing.Size(196, 30);
            this.partCategoryInput.TabIndex = 14;
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Location = new System.Drawing.Point(65, 262);
            this.partPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(130, 22);
            this.partPriceLabel.TabIndex = 9;
            this.partPriceLabel.Text = "Цена за клиент";
            // 
            // partDeliveryLabel
            // 
            this.partDeliveryLabel.AutoSize = true;
            this.partDeliveryLabel.Location = new System.Drawing.Point(46, 211);
            this.partDeliveryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.partDeliveryLabel.Name = "partDeliveryLabel";
            this.partDeliveryLabel.Size = new System.Drawing.Size(149, 22);
            this.partDeliveryLabel.TabIndex = 8;
            this.partDeliveryLabel.Text = "Цена на доставка";
            // 
            // partPriceInput
            // 
            this.partPriceInput.BackColor = System.Drawing.Color.LightGray;
            this.partPriceInput.Location = new System.Drawing.Point(206, 262);
            this.partPriceInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.partPriceInput.Name = "partPriceInput";
            this.partPriceInput.Size = new System.Drawing.Size(196, 29);
            this.partPriceInput.TabIndex = 7;
            // 
            // partDeliveryInput
            // 
            this.partDeliveryInput.BackColor = System.Drawing.Color.LightGray;
            this.partDeliveryInput.Location = new System.Drawing.Point(206, 210);
            this.partDeliveryInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.partDeliveryInput.Name = "partDeliveryInput";
            this.partDeliveryInput.Size = new System.Drawing.Size(196, 29);
            this.partDeliveryInput.TabIndex = 6;
            // 
            // partCodeInput
            // 
            this.partCodeInput.BackColor = System.Drawing.Color.LightGray;
            this.partCodeInput.Location = new System.Drawing.Point(206, 107);
            this.partCodeInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.partCodeInput.Name = "partCodeInput";
            this.partCodeInput.Size = new System.Drawing.Size(196, 29);
            this.partCodeInput.TabIndex = 4;
            // 
            // partNameInput
            // 
            this.partNameInput.BackColor = System.Drawing.Color.LightGray;
            this.partNameInput.Location = new System.Drawing.Point(206, 52);
            this.partNameInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.partNameInput.Name = "partNameInput";
            this.partNameInput.Size = new System.Drawing.Size(196, 29);
            this.partNameInput.TabIndex = 3;
            // 
            // partCategoryLabel
            // 
            this.partCategoryLabel.AutoSize = true;
            this.partCategoryLabel.Location = new System.Drawing.Point(106, 160);
            this.partCategoryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.partCategoryLabel.Name = "partCategoryLabel";
            this.partCategoryLabel.Size = new System.Drawing.Size(90, 22);
            this.partCategoryLabel.TabIndex = 2;
            this.partCategoryLabel.Text = "Категория";
            // 
            // partCodeLabel
            // 
            this.partCodeLabel.AutoSize = true;
            this.partCodeLabel.Location = new System.Drawing.Point(157, 110);
            this.partCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.partCodeLabel.Name = "partCodeLabel";
            this.partCodeLabel.Size = new System.Drawing.Size(40, 22);
            this.partCodeLabel.TabIndex = 1;
            this.partCodeLabel.Text = "Код";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(155, 56);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(41, 22);
            this.partNameLabel.TabIndex = 0;
            this.partNameLabel.Text = "Име";
            // 
            // manufacturerInputPanel
            // 
            this.manufacturerInputPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.manufacturerInputPanel.Controls.Add(this.manufacturerFaxInput);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerPhoneInput);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerAddressInput);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerCountryInput);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerNameInput);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerFaxLabel);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerPhoneLabel);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerAddressLabel);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerCountryLabel);
            this.manufacturerInputPanel.Controls.Add(this.manufacturerNameLabel);
            this.manufacturerInputPanel.Location = new System.Drawing.Point(523, 60);
            this.manufacturerInputPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerInputPanel.MaximumSize = new System.Drawing.Size(620, 348);
            this.manufacturerInputPanel.Name = "manufacturerInputPanel";
            this.manufacturerInputPanel.Size = new System.Drawing.Size(491, 348);
            this.manufacturerInputPanel.TabIndex = 13;
            // 
            // manufacturerFaxInput
            // 
            this.manufacturerFaxInput.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerFaxInput.Location = new System.Drawing.Point(209, 265);
            this.manufacturerFaxInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerFaxInput.Name = "manufacturerFaxInput";
            this.manufacturerFaxInput.Size = new System.Drawing.Size(196, 29);
            this.manufacturerFaxInput.TabIndex = 9;
            // 
            // manufacturerPhoneInput
            // 
            this.manufacturerPhoneInput.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerPhoneInput.Location = new System.Drawing.Point(209, 211);
            this.manufacturerPhoneInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerPhoneInput.Name = "manufacturerPhoneInput";
            this.manufacturerPhoneInput.Size = new System.Drawing.Size(196, 29);
            this.manufacturerPhoneInput.TabIndex = 8;
            // 
            // manufacturerAddressInput
            // 
            this.manufacturerAddressInput.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerAddressInput.Location = new System.Drawing.Point(209, 163);
            this.manufacturerAddressInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerAddressInput.Name = "manufacturerAddressInput";
            this.manufacturerAddressInput.Size = new System.Drawing.Size(196, 29);
            this.manufacturerAddressInput.TabIndex = 7;
            // 
            // manufacturerCountryInput
            // 
            this.manufacturerCountryInput.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerCountryInput.Location = new System.Drawing.Point(209, 111);
            this.manufacturerCountryInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerCountryInput.Name = "manufacturerCountryInput";
            this.manufacturerCountryInput.Size = new System.Drawing.Size(196, 29);
            this.manufacturerCountryInput.TabIndex = 6;
            // 
            // manufacturerNameInput
            // 
            this.manufacturerNameInput.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerNameInput.Location = new System.Drawing.Point(209, 56);
            this.manufacturerNameInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.manufacturerNameInput.Name = "manufacturerNameInput";
            this.manufacturerNameInput.Size = new System.Drawing.Size(196, 29);
            this.manufacturerNameInput.TabIndex = 5;
            // 
            // manufacturerFaxLabel
            // 
            this.manufacturerFaxLabel.AutoSize = true;
            this.manufacturerFaxLabel.Location = new System.Drawing.Point(146, 268);
            this.manufacturerFaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacturerFaxLabel.Name = "manufacturerFaxLabel";
            this.manufacturerFaxLabel.Size = new System.Drawing.Size(50, 22);
            this.manufacturerFaxLabel.TabIndex = 4;
            this.manufacturerFaxLabel.Text = "Факс";
            // 
            // manufacturerPhoneLabel
            // 
            this.manufacturerPhoneLabel.AutoSize = true;
            this.manufacturerPhoneLabel.Location = new System.Drawing.Point(118, 214);
            this.manufacturerPhoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacturerPhoneLabel.Name = "manufacturerPhoneLabel";
            this.manufacturerPhoneLabel.Size = new System.Drawing.Size(80, 22);
            this.manufacturerPhoneLabel.TabIndex = 3;
            this.manufacturerPhoneLabel.Text = "Телефон";
            // 
            // manufacturerAddressLabel
            // 
            this.manufacturerAddressLabel.AutoSize = true;
            this.manufacturerAddressLabel.Location = new System.Drawing.Point(140, 167);
            this.manufacturerAddressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacturerAddressLabel.Name = "manufacturerAddressLabel";
            this.manufacturerAddressLabel.Size = new System.Drawing.Size(58, 22);
            this.manufacturerAddressLabel.TabIndex = 2;
            this.manufacturerAddressLabel.Text = "Адрес";
            // 
            // manufacturerCountryLabel
            // 
            this.manufacturerCountryLabel.AutoSize = true;
            this.manufacturerCountryLabel.Location = new System.Drawing.Point(134, 114);
            this.manufacturerCountryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacturerCountryLabel.Name = "manufacturerCountryLabel";
            this.manufacturerCountryLabel.Size = new System.Drawing.Size(66, 22);
            this.manufacturerCountryLabel.TabIndex = 1;
            this.manufacturerCountryLabel.Text = "Страна";
            // 
            // manufacturerNameLabel
            // 
            this.manufacturerNameLabel.AutoSize = true;
            this.manufacturerNameLabel.Location = new System.Drawing.Point(157, 59);
            this.manufacturerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manufacturerNameLabel.Name = "manufacturerNameLabel";
            this.manufacturerNameLabel.Size = new System.Drawing.Size(41, 22);
            this.manufacturerNameLabel.TabIndex = 0;
            this.manufacturerNameLabel.Text = "Име";
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputButton.BackColor = System.Drawing.Color.Tan;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputButton.Location = new System.Drawing.Point(341, 416);
            this.inputButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputButton.MaximumSize = new System.Drawing.Size(166, 79);
            this.inputButton.MinimumSize = new System.Drawing.Size(166, 37);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(166, 37);
            this.inputButton.TabIndex = 12;
            this.inputButton.Text = "Въведи";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clearButton.BackColor = System.Drawing.Color.Tan;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(523, 416);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.clearButton.MaximumSize = new System.Drawing.Size(166, 79);
            this.clearButton.MinimumSize = new System.Drawing.Size(166, 37);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(166, 37);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Следващ артикул";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.shopsPage);
            this.tabs.Controls.Add(this.inputPage);
            this.tabs.Controls.Add(this.outputPage);
            this.tabs.Controls.Add(this.manufacturerSearchPage);
            this.tabs.Controls.Add(this.brandSearchPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1034, 493);
            this.tabs.TabIndex = 0;
            // 
            // shopsPage
            // 
            this.shopsPage.Controls.Add(this.shopNameInput);
            this.shopsPage.Controls.Add(this.shopAdd);
            this.shopsPage.Controls.Add(this.shopNameInputLabel);
            this.shopsPage.Controls.Add(this.shopsList);
            this.shopsPage.Location = new System.Drawing.Point(4, 31);
            this.shopsPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.shopsPage.Name = "shopsPage";
            this.shopsPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.shopsPage.Size = new System.Drawing.Size(1026, 458);
            this.shopsPage.TabIndex = 5;
            this.shopsPage.Text = "Магазини";
            this.shopsPage.UseVisualStyleBackColor = true;
            // 
            // shopsList
            // 
            this.shopsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shopsList.FormattingEnabled = true;
            this.shopsList.ItemHeight = 22;
            this.shopsList.Location = new System.Drawing.Point(2, 121);
            this.shopsList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.shopsList.Name = "shopsList";
            this.shopsList.Size = new System.Drawing.Size(1022, 334);
            this.shopsList.TabIndex = 0;
            this.shopsList.SelectedIndexChanged += new System.EventHandler(this.shopsList_SelectedIndexChanged);
            // 
            // brandSearchPage
            // 
            this.brandSearchPage.Controls.Add(this.brandSearchPartNameLabel);
            this.brandSearchPage.Controls.Add(this.brandSearchPartNameInput);
            this.brandSearchPage.Controls.Add(this.brandSearchResult);
            this.brandSearchPage.Controls.Add(this.brandSearch);
            this.brandSearchPage.Controls.Add(this.brandSearchInput);
            this.brandSearchPage.Controls.Add(this.brandSearchLabel);
            this.brandSearchPage.Location = new System.Drawing.Point(4, 31);
            this.brandSearchPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brandSearchPage.Name = "brandSearchPage";
            this.brandSearchPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brandSearchPage.Size = new System.Drawing.Size(1026, 458);
            this.brandSearchPage.TabIndex = 4;
            this.brandSearchPage.Text = "Търсене по марка";
            this.brandSearchPage.UseVisualStyleBackColor = true;
            // 
            // brandSearchPartNameLabel
            // 
            this.brandSearchPartNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandSearchPartNameLabel.AutoSize = true;
            this.brandSearchPartNameLabel.Location = new System.Drawing.Point(235, 53);
            this.brandSearchPartNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.brandSearchPartNameLabel.Name = "brandSearchPartNameLabel";
            this.brandSearchPartNameLabel.Size = new System.Drawing.Size(167, 22);
            this.brandSearchPartNameLabel.TabIndex = 9;
            this.brandSearchPartNameLabel.Text = "Въведи име на част";
            // 
            // brandSearchPartNameInput
            // 
            this.brandSearchPartNameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandSearchPartNameInput.BackColor = System.Drawing.Color.LightGray;
            this.brandSearchPartNameInput.Location = new System.Drawing.Point(413, 50);
            this.brandSearchPartNameInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.brandSearchPartNameInput.Name = "brandSearchPartNameInput";
            this.brandSearchPartNameInput.Size = new System.Drawing.Size(400, 29);
            this.brandSearchPartNameInput.TabIndex = 8;
            // 
            // brandSearchResult
            // 
            this.brandSearchResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.brandSearchResult.FormattingEnabled = true;
            this.brandSearchResult.ItemHeight = 22;
            this.brandSearchResult.Location = new System.Drawing.Point(2, 143);
            this.brandSearchResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.brandSearchResult.Name = "brandSearchResult";
            this.brandSearchResult.Size = new System.Drawing.Size(1022, 312);
            this.brandSearchResult.TabIndex = 7;
            // 
            // brandSearch
            // 
            this.brandSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandSearch.BackColor = System.Drawing.Color.Tan;
            this.brandSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brandSearch.Location = new System.Drawing.Point(413, 90);
            this.brandSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.brandSearch.Name = "brandSearch";
            this.brandSearch.Size = new System.Drawing.Size(400, 32);
            this.brandSearch.TabIndex = 6;
            this.brandSearch.Text = "Изведи";
            this.brandSearch.UseVisualStyleBackColor = false;
            this.brandSearch.Click += new System.EventHandler(this.brandSearch_Click);
            // 
            // brandSearchInput
            // 
            this.brandSearchInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandSearchInput.BackColor = System.Drawing.Color.LightGray;
            this.brandSearchInput.Location = new System.Drawing.Point(413, 19);
            this.brandSearchInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.brandSearchInput.Name = "brandSearchInput";
            this.brandSearchInput.Size = new System.Drawing.Size(400, 29);
            this.brandSearchInput.TabIndex = 5;
            // 
            // brandSearchLabel
            // 
            this.brandSearchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandSearchLabel.AutoSize = true;
            this.brandSearchLabel.Location = new System.Drawing.Point(214, 22);
            this.brandSearchLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.brandSearchLabel.Name = "brandSearchLabel";
            this.brandSearchLabel.Size = new System.Drawing.Size(185, 22);
            this.brandSearchLabel.TabIndex = 4;
            this.brandSearchLabel.Text = "Въведи марка на кола";
            // 
            // shopNameInputLabel
            // 
            this.shopNameInputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopNameInputLabel.AutoSize = true;
            this.shopNameInputLabel.Location = new System.Drawing.Point(210, 23);
            this.shopNameInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopNameInputLabel.Name = "shopNameInputLabel";
            this.shopNameInputLabel.Size = new System.Drawing.Size(194, 22);
            this.shopNameInputLabel.TabIndex = 2;
            this.shopNameInputLabel.Text = "Въведи име на магазин";
            // 
            // shopAdd
            // 
            this.shopAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopAdd.BackColor = System.Drawing.Color.Tan;
            this.shopAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shopAdd.Location = new System.Drawing.Point(416, 60);
            this.shopAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.shopAdd.Name = "shopAdd";
            this.shopAdd.Size = new System.Drawing.Size(400, 48);
            this.shopAdd.TabIndex = 3;
            this.shopAdd.Text = "Добави";
            this.shopAdd.UseVisualStyleBackColor = false;
            this.shopAdd.Click += new System.EventHandler(this.shopAdd_Click);
            // 
            // shopNameInput
            // 
            this.shopNameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopNameInput.BackColor = System.Drawing.Color.LightGray;
            this.shopNameInput.Location = new System.Drawing.Point(416, 20);
            this.shopNameInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.shopNameInput.Name = "shopNameInput";
            this.shopNameInput.Size = new System.Drawing.Size(400, 29);
            this.shopNameInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 493);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1050, 532);
            this.Name = "Form1";
            this.Text = "Авто Магазин";
            this.manufacturerSearchPage.ResumeLayout(false);
            this.manufacturerSearchPage.PerformLayout();
            this.outputPage.ResumeLayout(false);
            this.inputPage.ResumeLayout(false);
            this.partInputPanel.ResumeLayout(false);
            this.partInputPanel.PerformLayout();
            this.manufacturerInputPanel.ResumeLayout(false);
            this.manufacturerInputPanel.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.shopsPage.ResumeLayout(false);
            this.shopsPage.PerformLayout();
            this.brandSearchPage.ResumeLayout(false);
            this.brandSearchPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage manufacturerSearchPage;
        private System.Windows.Forms.ListBox manufacturerSearchResult;
        private System.Windows.Forms.Button manufacturerSearch;
        private System.Windows.Forms.TextBox manufacturerSearchInput;
        private System.Windows.Forms.Label manufacturerSearchInputLabel;
        private System.Windows.Forms.TabPage outputPage;
        private System.Windows.Forms.TabPage inputPage;
        private System.Windows.Forms.ComboBox partCategoryInput;
        private System.Windows.Forms.Panel manufacturerInputPanel;
        private System.Windows.Forms.TextBox manufacturerFaxInput;
        private System.Windows.Forms.TextBox manufacturerPhoneInput;
        private System.Windows.Forms.TextBox manufacturerAddressInput;
        private System.Windows.Forms.TextBox manufacturerCountryInput;
        private System.Windows.Forms.TextBox manufacturerNameInput;
        private System.Windows.Forms.Label manufacturerFaxLabel;
        private System.Windows.Forms.Label manufacturerPhoneLabel;
        private System.Windows.Forms.Label manufacturerAddressLabel;
        private System.Windows.Forms.Label manufacturerCountryLabel;
        private System.Windows.Forms.Label manufacturerNameLabel;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Label partDeliveryLabel;
        private System.Windows.Forms.TextBox partPriceInput;
        private System.Windows.Forms.TextBox partDeliveryInput;
        private System.Windows.Forms.TextBox partCodeInput;
        private System.Windows.Forms.TextBox partNameInput;
        private System.Windows.Forms.Label partCategoryLabel;
        private System.Windows.Forms.Label partCodeLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Label partInputTitle;
        private System.Windows.Forms.Panel partInputPanel;
        private System.Windows.Forms.Label manufacturerInputTitle;
        private System.Windows.Forms.TabPage brandSearchPage;
        private System.Windows.Forms.Label brandSearchPartNameLabel;
        private System.Windows.Forms.TextBox brandSearchPartNameInput;
        private System.Windows.Forms.ListBox brandSearchResult;
        private System.Windows.Forms.Button brandSearch;
        private System.Windows.Forms.TextBox brandSearchInput;
        private System.Windows.Forms.Label brandSearchLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage shopsPage;
        private System.Windows.Forms.ListBox shopsList;
        private System.Windows.Forms.TextBox shopNameInput;
        private System.Windows.Forms.Button shopAdd;
        private System.Windows.Forms.Label shopNameInputLabel;
    }
}

