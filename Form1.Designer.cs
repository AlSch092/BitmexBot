namespace BitMexBot
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_GetPositions = new System.Windows.Forms.Button();
            this.label_OrderMargin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_GetRecentTrades = new System.Windows.Forms.Button();
            this.button_GetAccountOrders = new System.Windows.Forms.Button();
            this.label_AvailableBalance = new System.Windows.Forms.Label();
            this.label_UNPL = new System.Windows.Forms.Label();
            this.label_WalletBalance = new System.Windows.Forms.Label();
            this.comboBox_SelectedCurrency = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip_UserTrades = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip_Options = new System.Windows.Forms.MenuStrip();
            this.priceAlarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xBTUSDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xBTU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xBTZ19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xBT7DD95ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xBT7DU105ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDAU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bCHU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eOSU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eTHUSDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eTH19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lTCU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tRXU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xRPU19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.announcementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyingVolumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetch2hChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetch5hChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetch24hChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatIsCRAB17ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoIsSnimenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_Orderbook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Orderbook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_MarketOrder = new System.Windows.Forms.CheckBox();
            this.button_SetLeverage = new System.Windows.Forms.Button();
            this.button_Long = new System.Windows.Forms.Button();
            this.label_TransactionOrderValue = new System.Windows.Forms.Label();
            this.label_TransactionOrderCost = new System.Windows.Forms.Label();
            this.numericUpDown_TransactionLimitPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TransactionQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TransactionLeverage = new System.Windows.Forms.NumericUpDown();
            this.label_TransactionLeverage = new System.Windows.Forms.Label();
            this.checkBox_TransactionReduceOnly = new System.Windows.Forms.CheckBox();
            this.checkBox_TransactionHidden = new System.Windows.Forms.CheckBox();
            this.checkBox_TransactionPostOnly = new System.Windows.Forms.CheckBox();
            this.label_TransactionLimitPrice = new System.Windows.Forms.Label();
            this.label_TransactionQuantity = new System.Windows.Forms.Label();
            this.button_Short = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listView_Positions = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Liq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_Beep = new System.Windows.Forms.TextBox();
            this.radioButton_Beep = new System.Windows.Forms.RadioButton();
            this.radioButton_Sell = new System.Windows.Forms.RadioButton();
            this.radioButton_Buy = new System.Windows.Forms.RadioButton();
            this.textBox_AutoBuySellProfit = new System.Windows.Forms.TextBox();
            this.textBox_AntiLiquidation = new System.Windows.Forms.TextBox();
            this.checkBox_AntiLiquidation = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoPurchase = new System.Windows.Forms.CheckBox();
            this.checkBox_TrackPrice = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_BogMarketOrder = new System.Windows.Forms.CheckBox();
            this.numericUpDown_BogCycleDelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_BogCycles = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_BogRandomBot = new System.Windows.Forms.CheckBox();
            this.checkBox_BogUseAllBots = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown_BogPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BogSymbol = new System.Windows.Forms.ComboBox();
            this.button_BogWasteTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_BogQuantity = new System.Windows.Forms.NumericUpDown();
            this.button_BogPump = new System.Windows.Forms.Button();
            this.button_BogDump = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox_LogChats = new System.Windows.Forms.CheckBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_PostTrollbox = new System.Windows.Forms.Button();
            this.textBox_TrollboxText = new System.Windows.Forms.TextBox();
            this.button_GetTrollbox = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox_RunBot = new System.Windows.Forms.CheckBox();
            this.comboBox_botType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip_Options.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip_Orderbook.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TransactionLimitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TransactionQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TransactionLeverage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogCycleDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogQuantity)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_GetPositions);
            this.groupBox1.Controls.Add(this.label_OrderMargin);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_GetRecentTrades);
            this.groupBox1.Controls.Add(this.button_GetAccountOrders);
            this.groupBox1.Controls.Add(this.label_AvailableBalance);
            this.groupBox1.Controls.Add(this.label_UNPL);
            this.groupBox1.Controls.Add(this.label_WalletBalance);
            this.groupBox1.Location = new System.Drawing.Point(6, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // button_GetPositions
            // 
            this.button_GetPositions.Location = new System.Drawing.Point(6, 111);
            this.button_GetPositions.Name = "button_GetPositions";
            this.button_GetPositions.Size = new System.Drawing.Size(153, 23);
            this.button_GetPositions.TabIndex = 2;
            this.button_GetPositions.Text = "Get Open Positions";
            this.button_GetPositions.UseVisualStyleBackColor = true;
            this.button_GetPositions.Click += new System.EventHandler(this.button_GetPositions_Click);
            // 
            // label_OrderMargin
            // 
            this.label_OrderMargin.AutoSize = true;
            this.label_OrderMargin.Location = new System.Drawing.Point(6, 61);
            this.label_OrderMargin.Name = "label_OrderMargin";
            this.label_OrderMargin.Size = new System.Drawing.Size(74, 13);
            this.label_OrderMargin.TabIndex = 5;
            this.label_OrderMargin.Text = "Order Margin: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Orderbook";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_GetRecentTrades
            // 
            this.button_GetRecentTrades.Location = new System.Drawing.Point(6, 169);
            this.button_GetRecentTrades.Name = "button_GetRecentTrades";
            this.button_GetRecentTrades.Size = new System.Drawing.Size(153, 23);
            this.button_GetRecentTrades.TabIndex = 0;
            this.button_GetRecentTrades.Text = "Get Recent Trades";
            this.button_GetRecentTrades.UseVisualStyleBackColor = true;
            this.button_GetRecentTrades.Click += new System.EventHandler(this.button_GetRecentTrades_Click);
            // 
            // button_GetAccountOrders
            // 
            this.button_GetAccountOrders.Location = new System.Drawing.Point(6, 198);
            this.button_GetAccountOrders.Name = "button_GetAccountOrders";
            this.button_GetAccountOrders.Size = new System.Drawing.Size(153, 23);
            this.button_GetAccountOrders.TabIndex = 0;
            this.button_GetAccountOrders.Text = "Get Account Orders";
            this.button_GetAccountOrders.UseVisualStyleBackColor = true;
            this.button_GetAccountOrders.Click += new System.EventHandler(this.button_GetAccountOrders_Click);
            // 
            // label_AvailableBalance
            // 
            this.label_AvailableBalance.AutoSize = true;
            this.label_AvailableBalance.Location = new System.Drawing.Point(6, 82);
            this.label_AvailableBalance.Name = "label_AvailableBalance";
            this.label_AvailableBalance.Size = new System.Drawing.Size(98, 13);
            this.label_AvailableBalance.TabIndex = 4;
            this.label_AvailableBalance.Text = "Available Balance: ";
            // 
            // label_UNPL
            // 
            this.label_UNPL.AutoSize = true;
            this.label_UNPL.Location = new System.Drawing.Point(6, 42);
            this.label_UNPL.Name = "label_UNPL";
            this.label_UNPL.Size = new System.Drawing.Size(42, 13);
            this.label_UNPL.TabIndex = 2;
            this.label_UNPL.Text = "UPNL: ";
            // 
            // label_WalletBalance
            // 
            this.label_WalletBalance.AutoSize = true;
            this.label_WalletBalance.Location = new System.Drawing.Point(6, 21);
            this.label_WalletBalance.Name = "label_WalletBalance";
            this.label_WalletBalance.Size = new System.Drawing.Size(85, 13);
            this.label_WalletBalance.TabIndex = 2;
            this.label_WalletBalance.Text = "Wallet Balance: ";
            // 
            // comboBox_SelectedCurrency
            // 
            this.comboBox_SelectedCurrency.FormattingEnabled = true;
            this.comboBox_SelectedCurrency.Items.AddRange(new object[] {
            "XBTUSD",
            "XBTH20",
            "XBTM20",
            "ADAH20",
            "BCHH20",
            "EOSH20",
            "ETHUSD",
            "ETHH20",
            "LTCH20",
            "TRXH20",
            "XRPH20"});
            this.comboBox_SelectedCurrency.Location = new System.Drawing.Point(6, 12);
            this.comboBox_SelectedCurrency.Name = "comboBox_SelectedCurrency";
            this.comboBox_SelectedCurrency.Size = new System.Drawing.Size(165, 21);
            this.comboBox_SelectedCurrency.TabIndex = 7;
            this.comboBox_SelectedCurrency.Text = "XBTUSD";
            // 
            // contextMenuStrip_UserTrades
            // 
            this.contextMenuStrip_UserTrades.Name = "contextMenuStrip_UserTrades";
            this.contextMenuStrip_UserTrades.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip_Options
            // 
            this.menuStrip_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceAlarmsToolStripMenuItem,
            this.advancedStatisticsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_Options.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Options.Name = "menuStrip_Options";
            this.menuStrip_Options.Size = new System.Drawing.Size(652, 24);
            this.menuStrip_Options.TabIndex = 2;
            this.menuStrip_Options.Text = "menuStrip1";
            // 
            // priceAlarmsToolStripMenuItem
            // 
            this.priceAlarmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAlarmToolStripMenuItem,
            this.announcementsToolStripMenuItem});
            this.priceAlarmsToolStripMenuItem.Name = "priceAlarmsToolStripMenuItem";
            this.priceAlarmsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.priceAlarmsToolStripMenuItem.Text = "Price Alarms";
            // 
            // setAlarmToolStripMenuItem
            // 
            this.setAlarmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xBTUSDToolStripMenuItem1,
            this.xBTU19ToolStripMenuItem1,
            this.xBTZ19ToolStripMenuItem1,
            this.xBT7DD95ToolStripMenuItem1,
            this.xBT7DU105ToolStripMenuItem1,
            this.aDAU19ToolStripMenuItem1,
            this.bCHU19ToolStripMenuItem1,
            this.eOSU19ToolStripMenuItem1,
            this.eTHUSDToolStripMenuItem1,
            this.eTH19ToolStripMenuItem1,
            this.lTCU19ToolStripMenuItem1,
            this.tRXU19ToolStripMenuItem1,
            this.xRPU19ToolStripMenuItem1});
            this.setAlarmToolStripMenuItem.Name = "setAlarmToolStripMenuItem";
            this.setAlarmToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.setAlarmToolStripMenuItem.Text = "Set Alarm";
            // 
            // xBTUSDToolStripMenuItem1
            // 
            this.xBTUSDToolStripMenuItem1.Name = "xBTUSDToolStripMenuItem1";
            this.xBTUSDToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.xBTUSDToolStripMenuItem1.Text = "XBTUSD";
            // 
            // xBTU19ToolStripMenuItem1
            // 
            this.xBTU19ToolStripMenuItem1.Name = "xBTU19ToolStripMenuItem1";
            this.xBTU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.xBTU19ToolStripMenuItem1.Text = "XBTH20";
            // 
            // xBTZ19ToolStripMenuItem1
            // 
            this.xBTZ19ToolStripMenuItem1.Name = "xBTZ19ToolStripMenuItem1";
            this.xBTZ19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.xBTZ19ToolStripMenuItem1.Text = "XBTZ19";
            // 
            // xBT7DD95ToolStripMenuItem1
            // 
            this.xBT7DD95ToolStripMenuItem1.Name = "xBT7DD95ToolStripMenuItem1";
            this.xBT7DD95ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.xBT7DD95ToolStripMenuItem1.Text = "XBT7D_D95";
            // 
            // xBT7DU105ToolStripMenuItem1
            // 
            this.xBT7DU105ToolStripMenuItem1.Name = "xBT7DU105ToolStripMenuItem1";
            this.xBT7DU105ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.xBT7DU105ToolStripMenuItem1.Text = "XBT7D_U105";
            // 
            // aDAU19ToolStripMenuItem1
            // 
            this.aDAU19ToolStripMenuItem1.Name = "aDAU19ToolStripMenuItem1";
            this.aDAU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aDAU19ToolStripMenuItem1.Text = "ADAU19";
            // 
            // bCHU19ToolStripMenuItem1
            // 
            this.bCHU19ToolStripMenuItem1.Name = "bCHU19ToolStripMenuItem1";
            this.bCHU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.bCHU19ToolStripMenuItem1.Text = "BCHU19";
            // 
            // eOSU19ToolStripMenuItem1
            // 
            this.eOSU19ToolStripMenuItem1.Name = "eOSU19ToolStripMenuItem1";
            this.eOSU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.eOSU19ToolStripMenuItem1.Text = "EOSU19";
            // 
            // eTHUSDToolStripMenuItem1
            // 
            this.eTHUSDToolStripMenuItem1.Name = "eTHUSDToolStripMenuItem1";
            this.eTHUSDToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.eTHUSDToolStripMenuItem1.Text = "ETHUSD";
            // 
            // eTH19ToolStripMenuItem1
            // 
            this.eTH19ToolStripMenuItem1.Name = "eTH19ToolStripMenuItem1";
            this.eTH19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.eTH19ToolStripMenuItem1.Text = "ETH19";
            // 
            // lTCU19ToolStripMenuItem1
            // 
            this.lTCU19ToolStripMenuItem1.Name = "lTCU19ToolStripMenuItem1";
            this.lTCU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.lTCU19ToolStripMenuItem1.Text = "LTCU19";
            // 
            // tRXU19ToolStripMenuItem1
            // 
            this.tRXU19ToolStripMenuItem1.Name = "tRXU19ToolStripMenuItem1";
            this.tRXU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.tRXU19ToolStripMenuItem1.Text = "TRXU19";
            // 
            // xRPU19ToolStripMenuItem1
            // 
            this.xRPU19ToolStripMenuItem1.Name = "xRPU19ToolStripMenuItem1";
            this.xRPU19ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.xRPU19ToolStripMenuItem1.Text = "XRPU19";
            // 
            // announcementsToolStripMenuItem
            // 
            this.announcementsToolStripMenuItem.Name = "announcementsToolStripMenuItem";
            this.announcementsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.announcementsToolStripMenuItem.Text = "Announcements";
            // 
            // advancedStatisticsToolStripMenuItem
            // 
            this.advancedStatisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyingVolumesToolStripMenuItem,
            this.depthToolStripMenuItem,
            this.fetch2hChartToolStripMenuItem,
            this.fetch5hChartToolStripMenuItem,
            this.fetch24hChartToolStripMenuItem});
            this.advancedStatisticsToolStripMenuItem.Name = "advancedStatisticsToolStripMenuItem";
            this.advancedStatisticsToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.advancedStatisticsToolStripMenuItem.Text = "Advanced Statistics";
            // 
            // buyingVolumesToolStripMenuItem
            // 
            this.buyingVolumesToolStripMenuItem.Name = "buyingVolumesToolStripMenuItem";
            this.buyingVolumesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buyingVolumesToolStripMenuItem.Text = "Buying Volumes";
            // 
            // depthToolStripMenuItem
            // 
            this.depthToolStripMenuItem.Name = "depthToolStripMenuItem";
            this.depthToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.depthToolStripMenuItem.Text = "Depth";
            // 
            // fetch2hChartToolStripMenuItem
            // 
            this.fetch2hChartToolStripMenuItem.Name = "fetch2hChartToolStripMenuItem";
            this.fetch2hChartToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fetch2hChartToolStripMenuItem.Text = "Fetch 2h Chart";
            // 
            // fetch5hChartToolStripMenuItem
            // 
            this.fetch5hChartToolStripMenuItem.Name = "fetch5hChartToolStripMenuItem";
            this.fetch5hChartToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fetch5hChartToolStripMenuItem.Text = "Fetch 5h Chart";
            // 
            // fetch24hChartToolStripMenuItem
            // 
            this.fetch24hChartToolStripMenuItem.Name = "fetch24hChartToolStripMenuItem";
            this.fetch24hChartToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fetch24hChartToolStripMenuItem.Text = "Fetch 24h Chart";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.creditsToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.whatIsCRAB17ToolStripMenuItem,
            this.whoIsSnimenToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // whatIsCRAB17ToolStripMenuItem
            // 
            this.whatIsCRAB17ToolStripMenuItem.Name = "whatIsCRAB17ToolStripMenuItem";
            this.whatIsCRAB17ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.whatIsCRAB17ToolStripMenuItem.Text = "What is CRAB-17?";
            // 
            // whoIsSnimenToolStripMenuItem
            // 
            this.whoIsSnimenToolStripMenuItem.Name = "whoIsSnimenToolStripMenuItem";
            this.whoIsSnimenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.whoIsSnimenToolStripMenuItem.Text = "Who is Snimen?";
            this.whoIsSnimenToolStripMenuItem.Click += new System.EventHandler(this.whoIsSnimenToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buy/Sell";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_Orderbook);
            this.groupBox2.Location = new System.Drawing.Point(231, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pending Orders...";
            // 
            // listView_Orderbook
            // 
            this.listView_Orderbook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader4});
            this.listView_Orderbook.ContextMenuStrip = this.contextMenuStrip_Orderbook;
            this.listView_Orderbook.FullRowSelect = true;
            this.listView_Orderbook.GridLines = true;
            this.listView_Orderbook.HideSelection = false;
            this.listView_Orderbook.Location = new System.Drawing.Point(6, 19);
            this.listView_Orderbook.Name = "listView_Orderbook";
            this.listView_Orderbook.Size = new System.Drawing.Size(378, 198);
            this.listView_Orderbook.TabIndex = 0;
            this.listView_Orderbook.UseCompatibleStateImageBehavior = false;
            this.listView_Orderbook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Symbol";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Size";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "B/S";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Filled";
            // 
            // contextMenuStrip_Orderbook
            // 
            this.contextMenuStrip_Orderbook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.autoScrollToolStripMenuItem,
            this.copyLineToolStripMenuItem,
            this.logToFileToolStripMenuItem});
            this.contextMenuStrip_Orderbook.Name = "contextMenuStrip_Orderbook";
            this.contextMenuStrip_Orderbook.Size = new System.Drawing.Size(135, 92);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // autoScrollToolStripMenuItem
            // 
            this.autoScrollToolStripMenuItem.Name = "autoScrollToolStripMenuItem";
            this.autoScrollToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.autoScrollToolStripMenuItem.Text = "Auto-Scroll";
            // 
            // copyLineToolStripMenuItem
            // 
            this.copyLineToolStripMenuItem.Name = "copyLineToolStripMenuItem";
            this.copyLineToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyLineToolStripMenuItem.Text = "Copy Line";
            // 
            // logToFileToolStripMenuItem
            // 
            this.logToFileToolStripMenuItem.Name = "logToFileToolStripMenuItem";
            this.logToFileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.logToFileToolStripMenuItem.Text = "Log To File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_MarketOrder);
            this.groupBox3.Controls.Add(this.button_SetLeverage);
            this.groupBox3.Controls.Add(this.button_Long);
            this.groupBox3.Controls.Add(this.label_TransactionOrderValue);
            this.groupBox3.Controls.Add(this.label_TransactionOrderCost);
            this.groupBox3.Controls.Add(this.numericUpDown_TransactionLimitPrice);
            this.groupBox3.Controls.Add(this.numericUpDown_TransactionQuantity);
            this.groupBox3.Controls.Add(this.numericUpDown_TransactionLeverage);
            this.groupBox3.Controls.Add(this.label_TransactionLeverage);
            this.groupBox3.Controls.Add(this.checkBox_TransactionReduceOnly);
            this.groupBox3.Controls.Add(this.checkBox_TransactionHidden);
            this.groupBox3.Controls.Add(this.checkBox_TransactionPostOnly);
            this.groupBox3.Controls.Add(this.label_TransactionLimitPrice);
            this.groupBox3.Controls.Add(this.label_TransactionQuantity);
            this.groupBox3.Controls.Add(this.button_Short);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 227);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Transaction";
            // 
            // checkBox_MarketOrder
            // 
            this.checkBox_MarketOrder.AutoSize = true;
            this.checkBox_MarketOrder.Location = new System.Drawing.Point(127, 96);
            this.checkBox_MarketOrder.Name = "checkBox_MarketOrder";
            this.checkBox_MarketOrder.Size = new System.Drawing.Size(88, 17);
            this.checkBox_MarketOrder.TabIndex = 1;
            this.checkBox_MarketOrder.Text = "Market Order";
            this.checkBox_MarketOrder.UseVisualStyleBackColor = true;
            this.checkBox_MarketOrder.CheckedChanged += new System.EventHandler(this.checkBox_MarketOrder_CheckedChanged);
            // 
            // button_SetLeverage
            // 
            this.button_SetLeverage.Location = new System.Drawing.Point(5, 148);
            this.button_SetLeverage.Name = "button_SetLeverage";
            this.button_SetLeverage.Size = new System.Drawing.Size(208, 24);
            this.button_SetLeverage.TabIndex = 3;
            this.button_SetLeverage.Text = "Set Leverage";
            this.button_SetLeverage.UseVisualStyleBackColor = true;
            this.button_SetLeverage.Click += new System.EventHandler(this.button_SetLeverage_Click);
            // 
            // button_Long
            // 
            this.button_Long.Location = new System.Drawing.Point(5, 198);
            this.button_Long.Name = "button_Long";
            this.button_Long.Size = new System.Drawing.Size(89, 23);
            this.button_Long.TabIndex = 13;
            this.button_Long.Text = "Buy/Long";
            this.button_Long.UseVisualStyleBackColor = true;
            this.button_Long.Click += new System.EventHandler(this.button_Long_Click);
            // 
            // label_TransactionOrderValue
            // 
            this.label_TransactionOrderValue.AutoSize = true;
            this.label_TransactionOrderValue.Location = new System.Drawing.Point(114, 179);
            this.label_TransactionOrderValue.Name = "label_TransactionOrderValue";
            this.label_TransactionOrderValue.Size = new System.Drawing.Size(69, 13);
            this.label_TransactionOrderValue.TabIndex = 12;
            this.label_TransactionOrderValue.Text = "Order Value: ";
            // 
            // label_TransactionOrderCost
            // 
            this.label_TransactionOrderCost.AutoSize = true;
            this.label_TransactionOrderCost.Location = new System.Drawing.Point(6, 179);
            this.label_TransactionOrderCost.Name = "label_TransactionOrderCost";
            this.label_TransactionOrderCost.Size = new System.Drawing.Size(34, 13);
            this.label_TransactionOrderCost.TabIndex = 11;
            this.label_TransactionOrderCost.Text = "Cost: ";
            // 
            // numericUpDown_TransactionLimitPrice
            // 
            this.numericUpDown_TransactionLimitPrice.DecimalPlaces = 6;
            this.numericUpDown_TransactionLimitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDown_TransactionLimitPrice.Location = new System.Drawing.Point(104, 47);
            this.numericUpDown_TransactionLimitPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown_TransactionLimitPrice.Name = "numericUpDown_TransactionLimitPrice";
            this.numericUpDown_TransactionLimitPrice.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown_TransactionLimitPrice.TabIndex = 10;
            // 
            // numericUpDown_TransactionQuantity
            // 
            this.numericUpDown_TransactionQuantity.Location = new System.Drawing.Point(104, 23);
            this.numericUpDown_TransactionQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_TransactionQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TransactionQuantity.Name = "numericUpDown_TransactionQuantity";
            this.numericUpDown_TransactionQuantity.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown_TransactionQuantity.TabIndex = 9;
            this.numericUpDown_TransactionQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_TransactionLeverage
            // 
            this.numericUpDown_TransactionLeverage.DecimalPlaces = 2;
            this.numericUpDown_TransactionLeverage.Location = new System.Drawing.Point(108, 117);
            this.numericUpDown_TransactionLeverage.Name = "numericUpDown_TransactionLeverage";
            this.numericUpDown_TransactionLeverage.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown_TransactionLeverage.TabIndex = 8;
            this.numericUpDown_TransactionLeverage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_TransactionLeverage
            // 
            this.label_TransactionLeverage.AutoSize = true;
            this.label_TransactionLeverage.Location = new System.Drawing.Point(5, 120);
            this.label_TransactionLeverage.Name = "label_TransactionLeverage";
            this.label_TransactionLeverage.Size = new System.Drawing.Size(105, 13);
            this.label_TransactionLeverage.TabIndex = 7;
            this.label_TransactionLeverage.Text = "Leverage (0=Cross): ";
            // 
            // checkBox_TransactionReduceOnly
            // 
            this.checkBox_TransactionReduceOnly.AutoSize = true;
            this.checkBox_TransactionReduceOnly.Location = new System.Drawing.Point(6, 96);
            this.checkBox_TransactionReduceOnly.Name = "checkBox_TransactionReduceOnly";
            this.checkBox_TransactionReduceOnly.Size = new System.Drawing.Size(88, 17);
            this.checkBox_TransactionReduceOnly.TabIndex = 5;
            this.checkBox_TransactionReduceOnly.Text = "Reduce-Only";
            this.checkBox_TransactionReduceOnly.UseVisualStyleBackColor = true;
            // 
            // checkBox_TransactionHidden
            // 
            this.checkBox_TransactionHidden.AutoSize = true;
            this.checkBox_TransactionHidden.Location = new System.Drawing.Point(127, 73);
            this.checkBox_TransactionHidden.Name = "checkBox_TransactionHidden";
            this.checkBox_TransactionHidden.Size = new System.Drawing.Size(60, 17);
            this.checkBox_TransactionHidden.TabIndex = 4;
            this.checkBox_TransactionHidden.Text = "Hidden";
            this.checkBox_TransactionHidden.UseVisualStyleBackColor = true;
            // 
            // checkBox_TransactionPostOnly
            // 
            this.checkBox_TransactionPostOnly.AutoSize = true;
            this.checkBox_TransactionPostOnly.Checked = true;
            this.checkBox_TransactionPostOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TransactionPostOnly.Location = new System.Drawing.Point(6, 73);
            this.checkBox_TransactionPostOnly.Name = "checkBox_TransactionPostOnly";
            this.checkBox_TransactionPostOnly.Size = new System.Drawing.Size(115, 17);
            this.checkBox_TransactionPostOnly.TabIndex = 3;
            this.checkBox_TransactionPostOnly.Text = "Post-Only (Rebate)";
            this.checkBox_TransactionPostOnly.UseVisualStyleBackColor = true;
            // 
            // label_TransactionLimitPrice
            // 
            this.label_TransactionLimitPrice.AutoSize = true;
            this.label_TransactionLimitPrice.Location = new System.Drawing.Point(6, 49);
            this.label_TransactionLimitPrice.Name = "label_TransactionLimitPrice";
            this.label_TransactionLimitPrice.Size = new System.Drawing.Size(90, 13);
            this.label_TransactionLimitPrice.TabIndex = 2;
            this.label_TransactionLimitPrice.Text = "Limit Price (USD):";
            // 
            // label_TransactionQuantity
            // 
            this.label_TransactionQuantity.AutoSize = true;
            this.label_TransactionQuantity.Location = new System.Drawing.Point(6, 23);
            this.label_TransactionQuantity.Name = "label_TransactionQuantity";
            this.label_TransactionQuantity.Size = new System.Drawing.Size(49, 13);
            this.label_TransactionQuantity.TabIndex = 1;
            this.label_TransactionQuantity.Text = "Quantity:";
            // 
            // button_Short
            // 
            this.button_Short.Location = new System.Drawing.Point(116, 198);
            this.button_Short.Name = "button_Short";
            this.button_Short.Size = new System.Drawing.Size(91, 23);
            this.button_Short.TabIndex = 0;
            this.button_Short.Text = "Sell/Short";
            this.button_Short.UseVisualStyleBackColor = true;
            this.button_Short.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.comboBox_SelectedCurrency);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Overview";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView_Positions);
            this.groupBox6.Location = new System.Drawing.Point(177, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(439, 227);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current Positions";
            // 
            // listView_Positions
            // 
            this.listView_Positions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader_Liq,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Positions.ContextMenuStrip = this.contextMenuStrip_UserTrades;
            this.listView_Positions.FullRowSelect = true;
            this.listView_Positions.GridLines = true;
            this.listView_Positions.HideSelection = false;
            this.listView_Positions.Location = new System.Drawing.Point(6, 17);
            this.listView_Positions.Name = "listView_Positions";
            this.listView_Positions.Size = new System.Drawing.Size(427, 202);
            this.listView_Positions.TabIndex = 1;
            this.listView_Positions.UseCompatibleStateImageBehavior = false;
            this.listView_Positions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Symbol";
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Entry";
            this.columnHeader10.Width = 57;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Qty";
            this.columnHeader11.Width = 47;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Time";
            this.columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "B/S";
            this.columnHeader13.Width = 33;
            // 
            // columnHeader_Liq
            // 
            this.columnHeader_Liq.Text = "Liq. $";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UPNL";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RPNL";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(627, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Algorithms/Bots";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_Beep);
            this.groupBox10.Controls.Add(this.radioButton_Beep);
            this.groupBox10.Controls.Add(this.radioButton_Sell);
            this.groupBox10.Controls.Add(this.radioButton_Buy);
            this.groupBox10.Controls.Add(this.textBox_AutoBuySellProfit);
            this.groupBox10.Controls.Add(this.textBox_AntiLiquidation);
            this.groupBox10.Controls.Add(this.checkBox_AntiLiquidation);
            this.groupBox10.Controls.Add(this.checkBox_AutoPurchase);
            this.groupBox10.Controls.Add(this.checkBox_TrackPrice);
            this.groupBox10.Location = new System.Drawing.Point(9, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(267, 226);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Auto-Trader";
            // 
            // textBox_Beep
            // 
            this.textBox_Beep.Location = new System.Drawing.Point(185, 16);
            this.textBox_Beep.Name = "textBox_Beep";
            this.textBox_Beep.Size = new System.Drawing.Size(57, 20);
            this.textBox_Beep.TabIndex = 13;
            // 
            // radioButton_Beep
            // 
            this.radioButton_Beep.AutoSize = true;
            this.radioButton_Beep.Location = new System.Drawing.Point(88, 18);
            this.radioButton_Beep.Name = "radioButton_Beep";
            this.radioButton_Beep.Size = new System.Drawing.Size(91, 17);
            this.radioButton_Beep.TabIndex = 12;
            this.radioButton_Beep.TabStop = true;
            this.radioButton_Beep.Text = "Beep @ Price";
            this.radioButton_Beep.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sell
            // 
            this.radioButton_Sell.AutoSize = true;
            this.radioButton_Sell.Location = new System.Drawing.Point(165, 88);
            this.radioButton_Sell.Name = "radioButton_Sell";
            this.radioButton_Sell.Size = new System.Drawing.Size(42, 17);
            this.radioButton_Sell.TabIndex = 11;
            this.radioButton_Sell.TabStop = true;
            this.radioButton_Sell.Text = "Sell";
            this.radioButton_Sell.UseVisualStyleBackColor = true;
            // 
            // radioButton_Buy
            // 
            this.radioButton_Buy.AutoSize = true;
            this.radioButton_Buy.Location = new System.Drawing.Point(116, 88);
            this.radioButton_Buy.Name = "radioButton_Buy";
            this.radioButton_Buy.Size = new System.Drawing.Size(43, 17);
            this.radioButton_Buy.TabIndex = 10;
            this.radioButton_Buy.TabStop = true;
            this.radioButton_Buy.Text = "Buy";
            this.radioButton_Buy.UseVisualStyleBackColor = true;
            // 
            // textBox_AutoBuySellProfit
            // 
            this.textBox_AutoBuySellProfit.Location = new System.Drawing.Point(110, 62);
            this.textBox_AutoBuySellProfit.Name = "textBox_AutoBuySellProfit";
            this.textBox_AutoBuySellProfit.Size = new System.Drawing.Size(132, 20);
            this.textBox_AutoBuySellProfit.TabIndex = 9;
            this.textBox_AutoBuySellProfit.Text = "% Profit to Close";
            // 
            // textBox_AntiLiquidation
            // 
            this.textBox_AntiLiquidation.Location = new System.Drawing.Point(110, 39);
            this.textBox_AntiLiquidation.Name = "textBox_AntiLiquidation";
            this.textBox_AntiLiquidation.Size = new System.Drawing.Size(132, 20);
            this.textBox_AntiLiquidation.TabIndex = 8;
            this.textBox_AntiLiquidation.Text = "% To Close On";
            // 
            // checkBox_AntiLiquidation
            // 
            this.checkBox_AntiLiquidation.AutoSize = true;
            this.checkBox_AntiLiquidation.Location = new System.Drawing.Point(6, 42);
            this.checkBox_AntiLiquidation.Name = "checkBox_AntiLiquidation";
            this.checkBox_AntiLiquidation.Size = new System.Drawing.Size(98, 17);
            this.checkBox_AntiLiquidation.TabIndex = 7;
            this.checkBox_AntiLiquidation.Text = "Anti-Liquidation";
            this.checkBox_AntiLiquidation.UseVisualStyleBackColor = true;
            // 
            // checkBox_AutoPurchase
            // 
            this.checkBox_AutoPurchase.AutoSize = true;
            this.checkBox_AutoPurchase.Location = new System.Drawing.Point(6, 65);
            this.checkBox_AutoPurchase.Name = "checkBox_AutoPurchase";
            this.checkBox_AutoPurchase.Size = new System.Drawing.Size(91, 17);
            this.checkBox_AutoPurchase.TabIndex = 6;
            this.checkBox_AutoPurchase.Text = "Auto Buy/Sell";
            this.checkBox_AutoPurchase.UseVisualStyleBackColor = true;
            this.checkBox_AutoPurchase.CheckedChanged += new System.EventHandler(this.checkBox_AutoPurchase_CheckedChanged_1);
            // 
            // checkBox_TrackPrice
            // 
            this.checkBox_TrackPrice.AutoSize = true;
            this.checkBox_TrackPrice.Location = new System.Drawing.Point(6, 19);
            this.checkBox_TrackPrice.Name = "checkBox_TrackPrice";
            this.checkBox_TrackPrice.Size = new System.Drawing.Size(81, 17);
            this.checkBox_TrackPrice.TabIndex = 4;
            this.checkBox_TrackPrice.Text = "Track Price";
            this.checkBox_TrackPrice.UseVisualStyleBackColor = true;
            this.checkBox_TrackPrice.CheckedChanged += new System.EventHandler(this.checkBox_TrackPrice_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_BogMarketOrder);
            this.groupBox5.Controls.Add(this.numericUpDown_BogCycleDelay);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.numericUpDown_BogCycles);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.checkBox_BogRandomBot);
            this.groupBox5.Controls.Add(this.checkBox_BogUseAllBots);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.numericUpDown_BogPrice);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.comboBox_BogSymbol);
            this.groupBox5.Controls.Add(this.button_BogWasteTime);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.numericUpDown_BogQuantity);
            this.groupBox5.Controls.Add(this.button_BogPump);
            this.groupBox5.Controls.Add(this.button_BogDump);
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(282, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 221);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bogdanoff Controls";
            // 
            // checkBox_BogMarketOrder
            // 
            this.checkBox_BogMarketOrder.AutoSize = true;
            this.checkBox_BogMarketOrder.Location = new System.Drawing.Point(156, 70);
            this.checkBox_BogMarketOrder.Name = "checkBox_BogMarketOrder";
            this.checkBox_BogMarketOrder.Size = new System.Drawing.Size(137, 17);
            this.checkBox_BogMarketOrder.TabIndex = 24;
            this.checkBox_BogMarketOrder.Text = "Market Order (Bog Fee)";
            this.checkBox_BogMarketOrder.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_BogCycleDelay
            // 
            this.numericUpDown_BogCycleDelay.Location = new System.Drawing.Point(62, 99);
            this.numericUpDown_BogCycleDelay.Name = "numericUpDown_BogCycleDelay";
            this.numericUpDown_BogCycleDelay.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown_BogCycleDelay.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Delay:";
            // 
            // numericUpDown_BogCycles
            // 
            this.numericUpDown_BogCycles.Location = new System.Drawing.Point(62, 71);
            this.numericUpDown_BogCycles.Name = "numericUpDown_BogCycles";
            this.numericUpDown_BogCycles.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown_BogCycles.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cycles:";
            // 
            // checkBox_BogRandomBot
            // 
            this.checkBox_BogRandomBot.AutoSize = true;
            this.checkBox_BogRandomBot.Location = new System.Drawing.Point(8, 142);
            this.checkBox_BogRandomBot.Name = "checkBox_BogRandomBot";
            this.checkBox_BogRandomBot.Size = new System.Drawing.Size(152, 17);
            this.checkBox_BogRandomBot.TabIndex = 19;
            this.checkBox_BogRandomBot.Text = "Bog Random Bot From List";
            this.checkBox_BogRandomBot.UseVisualStyleBackColor = true;
            // 
            // checkBox_BogUseAllBots
            // 
            this.checkBox_BogUseAllBots.AutoSize = true;
            this.checkBox_BogUseAllBots.Location = new System.Drawing.Point(8, 123);
            this.checkBox_BogUseAllBots.Name = "checkBox_BogUseAllBots";
            this.checkBox_BogUseAllBots.Size = new System.Drawing.Size(125, 17);
            this.checkBox_BogUseAllBots.TabIndex = 18;
            this.checkBox_BogUseAllBots.Text = "Use All Bots Possible";
            this.checkBox_BogUseAllBots.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(157, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Post-Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Accounts File Path...";
            // 
            // numericUpDown_BogPrice
            // 
            this.numericUpDown_BogPrice.DecimalPlaces = 6;
            this.numericUpDown_BogPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numericUpDown_BogPrice.Location = new System.Drawing.Point(62, 45);
            this.numericUpDown_BogPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown_BogPrice.Name = "numericUpDown_BogPrice";
            this.numericUpDown_BogPrice.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_BogPrice.TabIndex = 15;
            this.numericUpDown_BogPrice.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Limit Price:";
            // 
            // comboBox_BogSymbol
            // 
            this.comboBox_BogSymbol.FormattingEnabled = true;
            this.comboBox_BogSymbol.Items.AddRange(new object[] {
            "XBTUSD",
            "XBTU19",
            "XBTZ19",
            "XBT7D_D95",
            "XBT7D_U105",
            "ADAU19",
            "BCHU19",
            "EOSU19",
            "ETHUSD",
            "ETH19",
            "LTCU19",
            "TRXU19",
            "XRPU19"});
            this.comboBox_BogSymbol.Location = new System.Drawing.Point(157, 20);
            this.comboBox_BogSymbol.Name = "comboBox_BogSymbol";
            this.comboBox_BogSymbol.Size = new System.Drawing.Size(127, 21);
            this.comboBox_BogSymbol.TabIndex = 13;
            this.comboBox_BogSymbol.Text = "Select Currency";
            // 
            // button_BogWasteTime
            // 
            this.button_BogWasteTime.ForeColor = System.Drawing.Color.Coral;
            this.button_BogWasteTime.Location = new System.Drawing.Point(165, 191);
            this.button_BogWasteTime.Name = "button_BogWasteTime";
            this.button_BogWasteTime.Size = new System.Drawing.Size(117, 23);
            this.button_BogWasteTime.TabIndex = 12;
            this.button_BogWasteTime.Text = "Inverser";
            this.button_BogWasteTime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity:";
            // 
            // numericUpDown_BogQuantity
            // 
            this.numericUpDown_BogQuantity.Location = new System.Drawing.Point(62, 19);
            this.numericUpDown_BogQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_BogQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_BogQuantity.Name = "numericUpDown_BogQuantity";
            this.numericUpDown_BogQuantity.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_BogQuantity.TabIndex = 10;
            this.numericUpDown_BogQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_BogPump
            // 
            this.button_BogPump.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_BogPump.Location = new System.Drawing.Point(86, 190);
            this.button_BogPump.Name = "button_BogPump";
            this.button_BogPump.Size = new System.Drawing.Size(73, 23);
            this.button_BogPump.TabIndex = 1;
            this.button_BogPump.Text = "Bog Trap";
            this.button_BogPump.UseVisualStyleBackColor = true;
            // 
            // button_BogDump
            // 
            this.button_BogDump.Location = new System.Drawing.Point(8, 190);
            this.button_BogDump.Name = "button_BogDump";
            this.button_BogDump.Size = new System.Drawing.Size(72, 23);
            this.button_BogDump.TabIndex = 0;
            this.button_BogDump.Text = "Domp Eet";
            this.button_BogDump.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(627, 239);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trollbox";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox_LogChats);
            this.groupBox7.Controls.Add(this.listView2);
            this.groupBox7.Controls.Add(this.button_PostTrollbox);
            this.groupBox7.Controls.Add(this.textBox_TrollboxText);
            this.groupBox7.Controls.Add(this.button_GetTrollbox);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(621, 231);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Trollbox";
            // 
            // checkBox_LogChats
            // 
            this.checkBox_LogChats.AutoSize = true;
            this.checkBox_LogChats.Location = new System.Drawing.Point(251, 180);
            this.checkBox_LogChats.Name = "checkBox_LogChats";
            this.checkBox_LogChats.Size = new System.Drawing.Size(145, 17);
            this.checkBox_LogChats.TabIndex = 3;
            this.checkBox_LogChats.Text = "Log Trollbox Chats to File";
            this.checkBox_LogChats.UseVisualStyleBackColor = true;
            this.checkBox_LogChats.CheckedChanged += new System.EventHandler(this.checkBox_LogChats_CheckedChanged);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(612, 149);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Name";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Text";
            this.columnHeader15.Width = 550;
            // 
            // button_PostTrollbox
            // 
            this.button_PostTrollbox.Location = new System.Drawing.Point(575, 204);
            this.button_PostTrollbox.Name = "button_PostTrollbox";
            this.button_PostTrollbox.Size = new System.Drawing.Size(39, 20);
            this.button_PostTrollbox.TabIndex = 2;
            this.button_PostTrollbox.Text = "Post";
            this.button_PostTrollbox.UseVisualStyleBackColor = true;
            this.button_PostTrollbox.Click += new System.EventHandler(this.button_PostTrollbox_Click);
            // 
            // textBox_TrollboxText
            // 
            this.textBox_TrollboxText.Location = new System.Drawing.Point(6, 205);
            this.textBox_TrollboxText.Name = "textBox_TrollboxText";
            this.textBox_TrollboxText.Size = new System.Drawing.Size(564, 20);
            this.textBox_TrollboxText.TabIndex = 2;
            // 
            // button_GetTrollbox
            // 
            this.button_GetTrollbox.Location = new System.Drawing.Point(6, 176);
            this.button_GetTrollbox.Name = "button_GetTrollbox";
            this.button_GetTrollbox.Size = new System.Drawing.Size(239, 23);
            this.button_GetTrollbox.TabIndex = 0;
            this.button_GetTrollbox.Text = "Get Trollbox Chats";
            this.button_GetTrollbox.UseVisualStyleBackColor = true;
            this.button_GetTrollbox.Click += new System.EventHandler(this.button_GetTrollbox_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.comboBox_botType);
            this.tabPage5.Controls.Add(this.checkBox_RunBot);
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(627, 359);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Spot AI Bots";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(309, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(315, 338);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Transactions";
            // 
            // checkBox_RunBot
            // 
            this.checkBox_RunBot.AutoSize = true;
            this.checkBox_RunBot.Location = new System.Drawing.Point(6, 12);
            this.checkBox_RunBot.Name = "checkBox_RunBot";
            this.checkBox_RunBot.Size = new System.Drawing.Size(65, 17);
            this.checkBox_RunBot.TabIndex = 2;
            this.checkBox_RunBot.Text = "Run Bot";
            this.checkBox_RunBot.UseVisualStyleBackColor = true;
            // 
            // comboBox_botType
            // 
            this.comboBox_botType.FormattingEnabled = true;
            this.comboBox_botType.Items.AddRange(new object[] {
            "Grid",
            "Reverse Grid",
            "Infinite Grid"});
            this.comboBox_botType.Location = new System.Drawing.Point(101, 8);
            this.comboBox_botType.Name = "comboBox_botType";
            this.comboBox_botType.Size = new System.Drawing.Size(113, 21);
            this.comboBox_botType.TabIndex = 3;
            this.comboBox_botType.Text = "Grid";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip_Options);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Options;
            this.Name = "MainForm";
            this.Text = "CRAB-17 (Binance)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip_Options.ResumeLayout(false);
            this.menuStrip_Options.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip_Orderbook.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TransactionLimitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TransactionQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TransactionLeverage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogCycleDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BogQuantity)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip_Options;
        private System.Windows.Forms.ToolStripMenuItem advancedStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyingVolumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceAlarmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAlarmToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_GetAccountOrders;
        private System.Windows.Forms.Button button_GetRecentTrades;
        private System.Windows.Forms.Label label_OrderMargin;
        private System.Windows.Forms.Label label_AvailableBalance;
        private System.Windows.Forms.Label label_UNPL;
        private System.Windows.Forms.Label label_WalletBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_Orderbook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox_SelectedCurrency;
        private System.Windows.Forms.ToolStripMenuItem xBTUSDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xBTU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xBTZ19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xBT7DD95ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xBT7DU105ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aDAU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bCHU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eOSU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eTHUSDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eTH19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lTCU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tRXU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xRPU19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fetch2hChartToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_BogWasteTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_BogQuantity;
        private System.Windows.Forms.Button button_BogPump;
        private System.Windows.Forms.Button button_BogDump;
        private System.Windows.Forms.ComboBox comboBox_BogSymbol;
        private System.Windows.Forms.ToolStripMenuItem fetch5hChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetch24hChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatIsCRAB17ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_BogRandomBot;
        private System.Windows.Forms.CheckBox checkBox_BogUseAllBots;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_BogPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem whoIsSnimenToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_BogCycleDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_BogCycles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_UserTrades;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Orderbook;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoScrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToFileToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_BogMarketOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_SetLeverage;
        private System.Windows.Forms.Button button_Long;
        private System.Windows.Forms.Label label_TransactionOrderValue;
        private System.Windows.Forms.Label label_TransactionOrderCost;
        private System.Windows.Forms.NumericUpDown numericUpDown_TransactionLimitPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_TransactionQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_TransactionLeverage;
        private System.Windows.Forms.Label label_TransactionLeverage;
        private System.Windows.Forms.CheckBox checkBox_TransactionReduceOnly;
        private System.Windows.Forms.CheckBox checkBox_TransactionHidden;
        private System.Windows.Forms.CheckBox checkBox_TransactionPostOnly;
        private System.Windows.Forms.Label label_TransactionLimitPrice;
        private System.Windows.Forms.Label label_TransactionQuantity;
        private System.Windows.Forms.Button button_Short;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listView_Positions;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button button_PostTrollbox;
        private System.Windows.Forms.TextBox textBox_TrollboxText;
        private System.Windows.Forms.Button button_GetTrollbox;
        private System.Windows.Forms.Button button_GetPositions;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox_AntiLiquidation;
        private System.Windows.Forms.CheckBox checkBox_AntiLiquidation;
        private System.Windows.Forms.CheckBox checkBox_AutoPurchase;
        private System.Windows.Forms.CheckBox checkBox_TrackPrice;
        private System.Windows.Forms.ColumnHeader columnHeader_Liq;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem announcementsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox checkBox_MarketOrder;
        private System.Windows.Forms.TextBox textBox_AutoBuySellProfit;
        private System.Windows.Forms.RadioButton radioButton_Sell;
        private System.Windows.Forms.RadioButton radioButton_Buy;
        private System.Windows.Forms.CheckBox checkBox_LogChats;
        private System.Windows.Forms.TextBox textBox_Beep;
        private System.Windows.Forms.RadioButton radioButton_Beep;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBox_botType;
        private System.Windows.Forms.CheckBox checkBox_RunBot;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

