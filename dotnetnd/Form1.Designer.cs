
namespace dotnetnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.stores_label = new System.Windows.Forms.Label();
            this.btnStoreCheckAll = new System.Windows.Forms.Button();
            this.btnStoreUncheckAll = new System.Windows.Forms.Button();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.btnSearchDeals = new System.Windows.Forms.Button();
            this.storeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealsList = new System.Windows.Forms.ListView();
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.storeTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblMetaScore = new System.Windows.Forms.Label();
            this.lblSteamRating = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnSortPrice = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.chkOnSale = new System.Windows.Forms.CheckBox();
            this.inputMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.inputMinPrice = new System.Windows.Forms.NumericUpDown();
            this.imgGame = new System.Windows.Forms.PictureBox();
            this.lblNormalPrice = new System.Windows.Forms.Label();
            this.lblOnSale = new System.Windows.Forms.Label();
            this.lblTitleInput = new System.Windows.Forms.Label();
            this.lblStoreInput = new System.Windows.Forms.Label();
            this.lblOnSaleInput = new System.Windows.Forms.Label();
            this.lblPriceInput = new System.Windows.Forms.Label();
            this.lblNormalPriceInput = new System.Windows.Forms.Label();
            this.lblMetaScoreInput = new System.Windows.Forms.Label();
            this.lblSteamRatingInput = new System.Windows.Forms.Label();
            this.myListView = new System.Windows.Forms.ListView();
            this.myTitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myStoreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPanelButton = new System.Windows.Forms.Button();
            this.secondaryPanelButton = new System.Windows.Forms.Button();
            this.secondaryPanel = new System.Windows.Forms.Panel();
            this.btnSearchGames = new System.Windows.Forms.Button();
            this.lblSelectGameTitle = new System.Windows.Forms.Label();
            this.lblDealsForSelectedGame = new System.Windows.Forms.Label();
            this.lblEnterGameTitle = new System.Windows.Forms.Label();
            this.gameDealsList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchGame = new System.Windows.Forms.TextBox();
            this.lblMetaInput = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblMyList = new System.Windows.Forms.Label();
            this.lblMinRating = new System.Windows.Forms.Label();
            this.inputMinRating = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblOnSaleSaved = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtOnSaleSaved = new System.Windows.Forms.TextBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cheaperItemsList = new System.Windows.Forms.Label();
            this.cheapestItemsListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.inputMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGame)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.secondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(259, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a game title";
            // 
            // stores_label
            // 
            this.stores_label.AccessibleName = "stores_label";
            this.stores_label.AllowDrop = true;
            this.stores_label.AutoSize = true;
            this.stores_label.Location = new System.Drawing.Point(6, 145);
            this.stores_label.Name = "stores_label";
            this.stores_label.Size = new System.Drawing.Size(68, 13);
            this.stores_label.TabIndex = 3;
            this.stores_label.Text = "Select stores";
            // 
            // btnStoreCheckAll
            // 
            this.btnStoreCheckAll.Location = new System.Drawing.Point(9, 744);
            this.btnStoreCheckAll.Name = "btnStoreCheckAll";
            this.btnStoreCheckAll.Size = new System.Drawing.Size(80, 22);
            this.btnStoreCheckAll.TabIndex = 6;
            this.btnStoreCheckAll.Text = "Select all";
            this.btnStoreCheckAll.UseVisualStyleBackColor = true;
            this.btnStoreCheckAll.Click += new System.EventHandler(this.btnStoreCheckAll_Click);
            // 
            // btnStoreUncheckAll
            // 
            this.btnStoreUncheckAll.Location = new System.Drawing.Point(95, 744);
            this.btnStoreUncheckAll.Name = "btnStoreUncheckAll";
            this.btnStoreUncheckAll.Size = new System.Drawing.Size(80, 22);
            this.btnStoreUncheckAll.TabIndex = 7;
            this.btnStoreUncheckAll.Text = "Select none";
            this.btnStoreUncheckAll.UseVisualStyleBackColor = true;
            this.btnStoreUncheckAll.Click += new System.EventHandler(this.btnStoreUncheckAll_Click);
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(137, 62);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(386, 20);
            this.txtGameTitle.TabIndex = 8;
            // 
            // btnSearchDeals
            // 
            this.btnSearchDeals.Location = new System.Drawing.Point(263, 88);
            this.btnSearchDeals.Name = "btnSearchDeals";
            this.btnSearchDeals.Size = new System.Drawing.Size(75, 22);
            this.btnSearchDeals.TabIndex = 11;
            this.btnSearchDeals.Text = "Search deals";
            this.btnSearchDeals.UseVisualStyleBackColor = true;
            this.btnSearchDeals.Click += new System.EventHandler(this.btnSearchDeals_Click);
            // 
            // storeList
            // 
            this.storeList.CheckBoxes = true;
            this.storeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.storeList.HideSelection = false;
            this.storeList.Location = new System.Drawing.Point(9, 161);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(173, 577);
            this.storeList.TabIndex = 12;
            this.storeList.UseCompatibleStateImageBehavior = false;
            this.storeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stores";
            this.columnHeader1.Width = 126;
            // 
            // dealsList
            // 
            this.dealsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHeader,
            this.storeTitle,
            this.price});
            this.dealsList.HideSelection = false;
            this.dealsList.Location = new System.Drawing.Point(188, 161);
            this.dealsList.Name = "dealsList";
            this.dealsList.Size = new System.Drawing.Size(534, 635);
            this.dealsList.TabIndex = 13;
            this.dealsList.UseCompatibleStateImageBehavior = false;
            this.dealsList.View = System.Windows.Forms.View.Details;
            this.dealsList.SelectedIndexChanged += new System.EventHandler(this.dealsList_SelectedIndexChanged);
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 363;
            // 
            // storeTitle
            // 
            this.storeTitle.Text = "Store";
            this.storeTitle.Width = 90;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 77;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(826, 452);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title:";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.Location = new System.Drawing.Point(819, 478);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(46, 17);
            this.lblStore.TabIndex = 15;
            this.lblStore.Text = "Store:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(771, 531);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(94, 17);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Current price:";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.Location = new System.Drawing.Point(793, 587);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(72, 17);
            this.lblMeta.TabIndex = 17;
            this.lblMeta.Text = "Metacritic:";
            // 
            // lblMetaScore
            // 
            this.lblMetaScore.AutoSize = true;
            this.lblMetaScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaScore.Location = new System.Drawing.Point(754, 614);
            this.lblMetaScore.Name = "lblMetaScore";
            this.lblMetaScore.Size = new System.Drawing.Size(111, 17);
            this.lblMetaScore.TabIndex = 19;
            this.lblMetaScore.Text = "Metacritic score:";
            // 
            // lblSteamRating
            // 
            this.lblSteamRating.AutoSize = true;
            this.lblSteamRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteamRating.Location = new System.Drawing.Point(773, 640);
            this.lblSteamRating.Name = "lblSteamRating";
            this.lblSteamRating.Size = new System.Drawing.Size(92, 17);
            this.lblSteamRating.TabIndex = 20;
            this.lblSteamRating.Text = "Steam rating:";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(813, 703);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(155, 22);
            this.btnAddToList.TabIndex = 23;
            this.btnAddToList.Text = "Add to my list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnSortPrice
            // 
            this.btnSortPrice.Location = new System.Drawing.Point(632, 132);
            this.btnSortPrice.Name = "btnSortPrice";
            this.btnSortPrice.Size = new System.Drawing.Size(90, 22);
            this.btnSortPrice.TabIndex = 24;
            this.btnSortPrice.Tag = "not sorted";
            this.btnSortPrice.Text = "Order by price";
            this.btnSortPrice.UseVisualStyleBackColor = true;
            this.btnSortPrice.Click += new System.EventHandler(this.btnSortPrice_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(908, 157);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(60, 24);
            this.lblFilter.TabIndex = 28;
            this.lblFilter.Text = "Filters";
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPrice.Location = new System.Drawing.Point(793, 190);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(72, 17);
            this.lblMaxPrice.TabIndex = 29;
            this.lblMaxPrice.Text = "Max price:";
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPrice.Location = new System.Drawing.Point(933, 189);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(69, 17);
            this.lblMinPrice.TabIndex = 30;
            this.lblMinPrice.Text = "Min price:";
            // 
            // chkOnSale
            // 
            this.chkOnSale.AutoSize = true;
            this.chkOnSale.Location = new System.Drawing.Point(1008, 219);
            this.chkOnSale.Name = "chkOnSale";
            this.chkOnSale.Size = new System.Drawing.Size(62, 17);
            this.chkOnSale.TabIndex = 34;
            this.chkOnSale.Text = "On sale";
            this.chkOnSale.UseVisualStyleBackColor = true;
            // 
            // inputMaxPrice
            // 
            this.inputMaxPrice.Location = new System.Drawing.Point(866, 190);
            this.inputMaxPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputMaxPrice.Name = "inputMaxPrice";
            this.inputMaxPrice.Size = new System.Drawing.Size(61, 20);
            this.inputMaxPrice.TabIndex = 39;
            this.inputMaxPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // inputMinPrice
            // 
            this.inputMinPrice.Location = new System.Drawing.Point(1008, 190);
            this.inputMinPrice.Name = "inputMinPrice";
            this.inputMinPrice.Size = new System.Drawing.Size(61, 20);
            this.inputMinPrice.TabIndex = 41;
            // 
            // imgGame
            // 
            this.imgGame.Location = new System.Drawing.Point(949, 361);
            this.imgGame.Name = "imgGame";
            this.imgGame.Size = new System.Drawing.Size(165, 83);
            this.imgGame.TabIndex = 43;
            this.imgGame.TabStop = false;
            // 
            // lblNormalPrice
            // 
            this.lblNormalPrice.AutoSize = true;
            this.lblNormalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalPrice.Location = new System.Drawing.Point(773, 560);
            this.lblNormalPrice.Name = "lblNormalPrice";
            this.lblNormalPrice.Size = new System.Drawing.Size(92, 17);
            this.lblNormalPrice.TabIndex = 44;
            this.lblNormalPrice.Text = "Normal price:";
            // 
            // lblOnSale
            // 
            this.lblOnSale.AutoSize = true;
            this.lblOnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnSale.Location = new System.Drawing.Point(804, 505);
            this.lblOnSale.Name = "lblOnSale";
            this.lblOnSale.Size = new System.Drawing.Size(61, 17);
            this.lblOnSale.TabIndex = 45;
            this.lblOnSale.Text = "On sale:";
            // 
            // lblTitleInput
            // 
            this.lblTitleInput.AutoSize = true;
            this.lblTitleInput.Location = new System.Drawing.Point(871, 456);
            this.lblTitleInput.Name = "lblTitleInput";
            this.lblTitleInput.Size = new System.Drawing.Size(0, 13);
            this.lblTitleInput.TabIndex = 46;
            // 
            // lblStoreInput
            // 
            this.lblStoreInput.AutoSize = true;
            this.lblStoreInput.Location = new System.Drawing.Point(871, 482);
            this.lblStoreInput.Name = "lblStoreInput";
            this.lblStoreInput.Size = new System.Drawing.Size(0, 13);
            this.lblStoreInput.TabIndex = 47;
            // 
            // lblOnSaleInput
            // 
            this.lblOnSaleInput.AutoSize = true;
            this.lblOnSaleInput.Location = new System.Drawing.Point(871, 509);
            this.lblOnSaleInput.Name = "lblOnSaleInput";
            this.lblOnSaleInput.Size = new System.Drawing.Size(0, 13);
            this.lblOnSaleInput.TabIndex = 48;
            // 
            // lblPriceInput
            // 
            this.lblPriceInput.AutoSize = true;
            this.lblPriceInput.Location = new System.Drawing.Point(871, 535);
            this.lblPriceInput.Name = "lblPriceInput";
            this.lblPriceInput.Size = new System.Drawing.Size(0, 13);
            this.lblPriceInput.TabIndex = 49;
            // 
            // lblNormalPriceInput
            // 
            this.lblNormalPriceInput.AutoSize = true;
            this.lblNormalPriceInput.Location = new System.Drawing.Point(871, 562);
            this.lblNormalPriceInput.Name = "lblNormalPriceInput";
            this.lblNormalPriceInput.Size = new System.Drawing.Size(0, 13);
            this.lblNormalPriceInput.TabIndex = 50;
            // 
            // lblMetaScoreInput
            // 
            this.lblMetaScoreInput.AutoSize = true;
            this.lblMetaScoreInput.Location = new System.Drawing.Point(871, 618);
            this.lblMetaScoreInput.Name = "lblMetaScoreInput";
            this.lblMetaScoreInput.Size = new System.Drawing.Size(0, 13);
            this.lblMetaScoreInput.TabIndex = 52;
            // 
            // lblSteamRatingInput
            // 
            this.lblSteamRatingInput.AutoSize = true;
            this.lblSteamRatingInput.Location = new System.Drawing.Point(871, 644);
            this.lblSteamRatingInput.Name = "lblSteamRatingInput";
            this.lblSteamRatingInput.Size = new System.Drawing.Size(0, 13);
            this.lblSteamRatingInput.TabIndex = 53;
            // 
            // myListView
            // 
            this.myListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.myTitleHeader,
            this.myStoreHeader,
            this.myPriceHeader});
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(1304, 110);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(534, 385);
            this.myListView.TabIndex = 54;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // myTitleHeader
            // 
            this.myTitleHeader.Text = "Title";
            this.myTitleHeader.Width = 363;
            // 
            // myStoreHeader
            // 
            this.myStoreHeader.Text = "Store";
            this.myStoreHeader.Width = 90;
            // 
            // myPriceHeader
            // 
            this.myPriceHeader.Text = "Price";
            this.myPriceHeader.Width = 77;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dealsList);
            this.mainPanel.Controls.Add(this.btnSortPrice);
            this.mainPanel.Controls.Add(this.stores_label);
            this.mainPanel.Controls.Add(this.btnStoreUncheckAll);
            this.mainPanel.Controls.Add(this.txtGameTitle);
            this.mainPanel.Controls.Add(this.storeList);
            this.mainPanel.Controls.Add(this.btnSearchDeals);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.btnStoreCheckAll);
            this.mainPanel.Location = new System.Drawing.Point(12, 59);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(736, 837);
            this.mainPanel.TabIndex = 55;
            // 
            // mainPanelButton
            // 
            this.mainPanelButton.Location = new System.Drawing.Point(11, 12);
            this.mainPanelButton.Name = "mainPanelButton";
            this.mainPanelButton.Size = new System.Drawing.Size(89, 36);
            this.mainPanelButton.TabIndex = 56;
            this.mainPanelButton.Text = "Page 1";
            this.mainPanelButton.UseVisualStyleBackColor = true;
            this.mainPanelButton.Click += new System.EventHandler(this.mainPanelButton_Click);
            // 
            // secondaryPanelButton
            // 
            this.secondaryPanelButton.Location = new System.Drawing.Point(105, 12);
            this.secondaryPanelButton.Name = "secondaryPanelButton";
            this.secondaryPanelButton.Size = new System.Drawing.Size(89, 36);
            this.secondaryPanelButton.TabIndex = 57;
            this.secondaryPanelButton.Text = "Page 2";
            this.secondaryPanelButton.UseVisualStyleBackColor = true;
            this.secondaryPanelButton.Click += new System.EventHandler(this.secondaryPanelButton_Click);
            // 
            // secondaryPanel
            // 
            this.secondaryPanel.Controls.Add(this.btnSearchGames);
            this.secondaryPanel.Controls.Add(this.lblSelectGameTitle);
            this.secondaryPanel.Controls.Add(this.lblDealsForSelectedGame);
            this.secondaryPanel.Controls.Add(this.lblEnterGameTitle);
            this.secondaryPanel.Controls.Add(this.gameDealsList);
            this.secondaryPanel.Controls.Add(this.gameList);
            this.secondaryPanel.Controls.Add(this.txtSearchGame);
            this.secondaryPanel.Location = new System.Drawing.Point(11, 59);
            this.secondaryPanel.Name = "secondaryPanel";
            this.secondaryPanel.Size = new System.Drawing.Size(736, 837);
            this.secondaryPanel.TabIndex = 58;
            // 
            // btnSearchGames
            // 
            this.btnSearchGames.Location = new System.Drawing.Point(327, 62);
            this.btnSearchGames.Name = "btnSearchGames";
            this.btnSearchGames.Size = new System.Drawing.Size(105, 46);
            this.btnSearchGames.TabIndex = 59;
            this.btnSearchGames.Text = "Search";
            this.btnSearchGames.UseVisualStyleBackColor = true;
            this.btnSearchGames.Click += new System.EventHandler(this.btnSearchGames_Click);
            // 
            // lblSelectGameTitle
            // 
            this.lblSelectGameTitle.AutoSize = true;
            this.lblSelectGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGameTitle.Location = new System.Drawing.Point(304, 131);
            this.lblSelectGameTitle.Name = "lblSelectGameTitle";
            this.lblSelectGameTitle.Size = new System.Drawing.Size(146, 24);
            this.lblSelectGameTitle.TabIndex = 63;
            this.lblSelectGameTitle.Text = "Select the game";
            // 
            // lblDealsForSelectedGame
            // 
            this.lblDealsForSelectedGame.AutoSize = true;
            this.lblDealsForSelectedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealsForSelectedGame.Location = new System.Drawing.Point(304, 465);
            this.lblDealsForSelectedGame.Name = "lblDealsForSelectedGame";
            this.lblDealsForSelectedGame.Size = new System.Drawing.Size(111, 24);
            this.lblDealsForSelectedGame.TabIndex = 62;
            this.lblDealsForSelectedGame.Text = "Game deals";
            // 
            // lblEnterGameTitle
            // 
            this.lblEnterGameTitle.AutoSize = true;
            this.lblEnterGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGameTitle.Location = new System.Drawing.Point(323, 9);
            this.lblEnterGameTitle.Name = "lblEnterGameTitle";
            this.lblEnterGameTitle.Size = new System.Drawing.Size(127, 20);
            this.lblEnterGameTitle.TabIndex = 61;
            this.lblEnterGameTitle.Text = "Enter game title";
            // 
            // gameDealsList
            // 
            this.gameDealsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.gameDealsList.HideSelection = false;
            this.gameDealsList.Location = new System.Drawing.Point(4, 492);
            this.gameDealsList.Name = "gameDealsList";
            this.gameDealsList.Size = new System.Drawing.Size(729, 338);
            this.gameDealsList.TabIndex = 60;
            this.gameDealsList.UseCompatibleStateImageBehavior = false;
            this.gameDealsList.View = System.Windows.Forms.View.Details;
            this.gameDealsList.SelectedIndexChanged += new System.EventHandler(this.gameDealsList_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 363;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Store";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            this.columnHeader7.Width = 77;
            // 
            // gameList
            // 
            this.gameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.gameList.HideSelection = false;
            this.gameList.Location = new System.Drawing.Point(4, 164);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(729, 263);
            this.gameList.TabIndex = 59;
            this.gameList.UseCompatibleStateImageBehavior = false;
            this.gameList.View = System.Windows.Forms.View.Details;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 724;
            // 
            // txtSearchGame
            // 
            this.txtSearchGame.Location = new System.Drawing.Point(241, 36);
            this.txtSearchGame.Name = "txtSearchGame";
            this.txtSearchGame.Size = new System.Drawing.Size(283, 20);
            this.txtSearchGame.TabIndex = 0;
            // 
            // lblMetaInput
            // 
            this.lblMetaInput.AutoSize = true;
            this.lblMetaInput.Location = new System.Drawing.Point(871, 589);
            this.lblMetaInput.Name = "lblMetaInput";
            this.lblMetaInput.Size = new System.Drawing.Size(0, 13);
            this.lblMetaInput.TabIndex = 59;
            this.lblMetaInput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMetaInput_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1175, 589);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 60;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(1299, 522);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(100, 26);
            this.lblStats.TabIndex = 61;
            this.lblStats.Text = "Statistics";
            // 
            // lblMyList
            // 
            this.lblMyList.AutoSize = true;
            this.lblMyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyList.Location = new System.Drawing.Point(1299, 22);
            this.lblMyList.Name = "lblMyList";
            this.lblMyList.Size = new System.Drawing.Size(74, 26);
            this.lblMyList.TabIndex = 62;
            this.lblMyList.Text = "My list";
            // 
            // lblMinRating
            // 
            this.lblMinRating.AutoSize = true;
            this.lblMinRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinRating.Location = new System.Drawing.Point(756, 218);
            this.lblMinRating.Name = "lblMinRating";
            this.lblMinRating.Size = new System.Drawing.Size(109, 17);
            this.lblMinRating.TabIndex = 31;
            this.lblMinRating.Text = "Min Meta rating:";
            // 
            // inputMinRating
            // 
            this.inputMinRating.Location = new System.Drawing.Point(866, 218);
            this.inputMinRating.Name = "inputMinRating";
            this.inputMinRating.Size = new System.Drawing.Size(61, 20);
            this.inputMinRating.TabIndex = 42;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1301, 564);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 18);
            this.lblTotalPrice.TabIndex = 63;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblOnSaleSaved
            // 
            this.lblOnSaleSaved.AutoSize = true;
            this.lblOnSaleSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnSaleSaved.Location = new System.Drawing.Point(1436, 564);
            this.lblOnSaleSaved.Name = "lblOnSaleSaved";
            this.lblOnSaleSaved.Size = new System.Drawing.Size(106, 18);
            this.lblOnSaleSaved.TabIndex = 64;
            this.lblOnSaleSaved.Text = "On Sale Saved";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(1304, 587);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(76, 20);
            this.txtTotalPrice.TabIndex = 66;
            // 
            // txtOnSaleSaved
            // 
            this.txtOnSaleSaved.Location = new System.Drawing.Point(1439, 587);
            this.txtOnSaleSaved.Name = "txtOnSaleSaved";
            this.txtOnSaleSaved.Size = new System.Drawing.Size(103, 20);
            this.txtOnSaleSaved.TabIndex = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 373;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Store";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 66;
            // 
            // cheaperItemsList
            // 
            this.cheaperItemsList.AutoSize = true;
            this.cheaperItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheaperItemsList.Location = new System.Drawing.Point(1299, 634);
            this.cheaperItemsList.Name = "cheaperItemsList";
            this.cheaperItemsList.Size = new System.Drawing.Size(154, 26);
            this.cheaperItemsList.TabIndex = 70;
            this.cheaperItemsList.Text = "Cheaper items";
            // 
            // cheapestItemsListView
            // 
            this.cheapestItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.cheapestItemsListView.HideSelection = false;
            this.cheapestItemsListView.Location = new System.Drawing.Point(1304, 672);
            this.cheapestItemsListView.Name = "cheapestItemsListView";
            this.cheapestItemsListView.Size = new System.Drawing.Size(534, 217);
            this.cheapestItemsListView.TabIndex = 71;
            this.cheapestItemsListView.UseCompatibleStateImageBehavior = false;
            this.cheapestItemsListView.View = System.Windows.Forms.View.Details;
            this.cheapestItemsListView.SelectedIndexChanged += new System.EventHandler(this.cheapestItemsListView_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Title";
            this.columnHeader9.Width = 363;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Store";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Price";
            this.columnHeader11.Width = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 911);
            this.Controls.Add(this.cheapestItemsListView);
            this.Controls.Add(this.cheaperItemsList);
            this.Controls.Add(this.txtOnSaleSaved);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblOnSaleSaved);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblMyList);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMetaInput);
            this.Controls.Add(this.secondaryPanelButton);
            this.Controls.Add(this.mainPanelButton);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.inputMinPrice);
            this.Controls.Add(this.lblOnSale);
            this.Controls.Add(this.inputMinRating);
            this.Controls.Add(this.lblSteamRatingInput);
            this.Controls.Add(this.imgGame);
            this.Controls.Add(this.chkOnSale);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNormalPrice);
            this.Controls.Add(this.lblMetaScoreInput);
            this.Controls.Add(this.inputMaxPrice);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.lblTitleInput);
            this.Controls.Add(this.lblNormalPriceInput);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.lblMeta);
            this.Controls.Add(this.lblPriceInput);
            this.Controls.Add(this.lblStoreInput);
            this.Controls.Add(this.lblSteamRating);
            this.Controls.Add(this.lblMinRating);
            this.Controls.Add(this.lblMetaScore);
            this.Controls.Add(this.lblMinPrice);
            this.Controls.Add(this.lblOnSaleInput);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.secondaryPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGame)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.secondaryPanel.ResumeLayout(false);
            this.secondaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputMinRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stores_label;
        private System.Windows.Forms.Button btnStoreCheckAll;
        private System.Windows.Forms.Button btnStoreUncheckAll;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Button btnSearchDeals;
        private System.Windows.Forms.ListView storeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView dealsList;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader storeTitle;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label lblMetaScore;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgGame;
        private System.Windows.Forms.NumericUpDown inputMinPrice;
        private System.Windows.Forms.NumericUpDown inputMaxPrice;
        private System.Windows.Forms.CheckBox chkOnSale;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnSortPrice;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label lblSteamRating;
        private System.Windows.Forms.Label lblOnSale;
        private System.Windows.Forms.Label lblNormalPrice;
        private System.Windows.Forms.Label lblSteamRatingInput;
        private System.Windows.Forms.Label lblMetaScoreInput;
        private System.Windows.Forms.Label lblNormalPriceInput;
        private System.Windows.Forms.Label lblPriceInput;
        private System.Windows.Forms.Label lblOnSaleInput;
        private System.Windows.Forms.Label lblStoreInput;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.ColumnHeader myTitleHeader;
        private System.Windows.Forms.ColumnHeader myStoreHeader;
        private System.Windows.Forms.ColumnHeader myPriceHeader;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button mainPanelButton;
        private System.Windows.Forms.Button secondaryPanelButton;
        private System.Windows.Forms.Panel secondaryPanel;
        private System.Windows.Forms.Label lblSelectGameTitle;
        private System.Windows.Forms.Label lblDealsForSelectedGame;
        private System.Windows.Forms.Label lblEnterGameTitle;
        private System.Windows.Forms.ListView gameDealsList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView gameList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtSearchGame;
        private System.Windows.Forms.Button btnSearchGames;
        private System.Windows.Forms.LinkLabel lblMetaInput;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblMyList;
        private System.Windows.Forms.Label lblMinRating;
        private System.Windows.Forms.NumericUpDown inputMinRating;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblOnSaleSaved;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtOnSaleSaved;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label cheaperItemsList;
        private System.Windows.Forms.ListView cheapestItemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

