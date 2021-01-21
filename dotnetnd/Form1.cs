using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace dotnetnd
{
    public partial class Form1 : Form
    {
        public MyProvider provider = new MyProvider();
        public List<string> myList = new List<string>();

        private const string REMOVE_ITEM_STRING = "Remove item from my list";
        private const string ADD_ITEM_STRING = "Add item to my list";

        private const string SALE_PRICE = "salePrice";
        private const string NORMAL_PRICE = "normalPrice";

        public Form1()
        {
            InitializeComponent();

            var stores = provider.GetStores();
            foreach (Store store in stores)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = store.ToString();
                listItem.Tag = store;
                storeList.Items.Add(listItem);
            }

            CheckedlistAllItemsValue(storeList, true);

            txtTotalPrice.ReadOnly = true;
            txtOnSaleSaved.ReadOnly = true;

            
        }

        // Page 1 panel -------------------------------------------------------------------

        // Buttons
        private void btnSearchDeals_Click(object sender, EventArgs e)
        {
            if (storeList.CheckedItems.Count > 0 && txtGameTitle.Text != "")
            {
                dealsList.Items.Clear();

                List<Store> checkedStores = new List<Store>();
                for (int i = 0; i < storeList.CheckedItems.Count; i++)
                {
                    checkedStores.Add((Store)storeList.CheckedItems[i].Tag);
                }
                List<Deal> deals = provider.GetDeals(checkedStores, txtGameTitle.Text, (int)inputMaxPrice.Value,
                                                                                       (int)inputMinPrice.Value,
                                                                                       (int)inputMinRating.Value,
                                                                                       chkOnSale.Checked ? 1 : 0);
                PopulateListView(deals, dealsList);
            }
        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {

            List<Deal> deals = dealsList.Items.Cast<ListViewItem>().Select(item => (Deal)item.Tag).ToList();

            if (deals.Count < 2)
            {
                return;
            }

            List<Deal> sortedDeals = null;

            if (btnSortPrice.Tag.ToString() == "asc")
            {
                sortedDeals = deals.OrderByDescending(item => item.salePrice).ToList();
                btnSortPrice.Tag = "desc";
            }
            else
            {
                sortedDeals = deals.OrderBy(item => item.salePrice).ToList();
                btnSortPrice.Tag = "asc";
            }

            PopulateListView(sortedDeals, dealsList);
        }

        private void btnStoreCheckAll_Click(object sender, EventArgs e)
        {
            CheckedlistAllItemsValue(storeList, true);
        }

        private void btnStoreUncheckAll_Click(object sender, EventArgs e)
        {
            CheckedlistAllItemsValue(storeList, false);
        }

        // Lists
        private void dealsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedDeal((ListView)sender);
        }

        // Page 2 panel -------------------------------------------------------------------

        //Buttons
        private void btnSearchGames_Click(object sender, EventArgs e)
        {
            if(txtSearchGame.Text != "")
            {
                List<Game> games = provider.GetGames(txtSearchGame.Text);
                PopulateListView(games, gameList);
            }
        }

        //Lists
        private void gameDealsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedDeal((ListView)sender);
        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game game = GetSelectedObject<Game>((ListView)sender);

            if (game != null)
            {
                List<Deal> deals = provider.GetDeals(game.id);

                PopulateListView(deals, gameDealsList);
            }
        }

        // Left -------------------------------------------------------------------

        // Panel navigation buttons

        private void mainPanelButton_Click(object sender, EventArgs e)
        {
            mainPanel.BringToFront();
            secondaryPanel.SendToBack();

            UpdateFilters(true);
        }

        private void secondaryPanelButton_Click(object sender, EventArgs e)
        {
            secondaryPanel.BringToFront();
            mainPanel.SendToBack();

            UpdateFilters(false);
        }

        // Center -------------------------------------------------------------------
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (btnAddToList.Tag != null && btnAddToList.Text != REMOVE_ITEM_STRING)
            {
                myList.Add(btnAddToList.Tag.ToString());
                btnAddToList.Text = REMOVE_ITEM_STRING;

                UpdateMyListView();
            }
            else if (btnAddToList.Tag != null)
            {
                myList.Remove(btnAddToList.Tag.ToString());
                btnAddToList.Text = ADD_ITEM_STRING;

                UpdateMyListView();
            }
        }

        private void lblMetaInput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string url = linkLabel.Text;

            System.Diagnostics.Process.Start(url);
        }

        // Right -------------------------------------------------------------------

        // Lists

        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedDeal((ListView)sender);
        }

        private void cheapestItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedDeal((ListView)sender);
        }

        // Other methods
        

        private void CheckedlistAllItemsValue(ListView list, bool value)
        {
            foreach (ListViewItem item in list.Items)
            {
                item.Checked = value;
            }
        }

        private void PopulateListView(List<Deal> deals, ListView listView)
        {
            if(ShouldPopulateList<Deal>(deals, listView))
            {
                foreach (Deal deal in deals)
                {
                    ListViewItem listItem = new ListViewItem(new string[] {deal.title,
                                                                       provider.FindStore(deal.storeID).name,
                                                                       deal.salePrice.ToString() + "€"});
                    listItem.Tag = deal;
                    listView.Items.Add(listItem);
                }
            }
        }

        private void PopulateListView(List<Game> games, ListView listView)
        {
            if (ShouldPopulateList<Game>(games, listView))
            {
                foreach (Game game in games)
                {
                    ListViewItem listItem = new ListViewItem(game.title);
                    listItem.Tag = game;
                    listView.Items.Add(listItem);
                }
            }
        }

        private bool ShouldPopulateList<T>(List<T> list, ListView listView)
        {
            listView.Items.Clear();

            if (list.Count == 0)
            {
                listView.Items.Add(new ListViewItem("None"));
                return false;
            }

            return true;
        }

        private void UpdateMyListView()
        {
            List<Deal> deals = new List<Deal>();

            foreach (string id in myList)
            {
                deals.Add(provider.GetDeal(id));
            }

            PopulateListView(deals, myListView);

            float totalSalePrice = provider.GetTotalPrice(deals, SALE_PRICE);
            float totalNormalPrice = provider.GetTotalPrice(deals, NORMAL_PRICE);

            txtTotalPrice.Text = totalSalePrice.ToString() + "€";
            txtOnSaleSaved.Text = (totalNormalPrice - totalSalePrice).ToString() + "€";

            PopulateListView(provider.GetCheaperDeals(deals), cheapestItemsListView);
        }

        private T GetSelectedObject<T>(ListView listView)
        {
            if (listView.SelectedIndices.Count < 1)
            {
                return default(T);
            }

            int selectedIndex = listView.SelectedIndices[0];

            return (T)listView.Items[selectedIndex].Tag;
        }

        private void DisplaySelectedDeal(ListView listView)
        {
            Deal deal = GetSelectedObject<Deal>(listView);

            if (deal == null)
            {
                return;
            }

            if (myList.Contains(deal.id))
            {
                btnAddToList.Text = REMOVE_ITEM_STRING;
                btnAddToList.Tag = deal.id;
            }
            else
            {
                btnAddToList.Text = ADD_ITEM_STRING;
                btnAddToList.Tag = deal.id;
            }

            UpdateSelectedItemDisplay(deal);
        }

        private void UpdateSelectedItemDisplay(Deal deal)
        {
            lblTitleInput.Text = deal.title;
            lblStoreInput.Text = provider.FindStore(deal.storeID).name;
            lblOnSaleInput.Text = deal.isOnSale == "1" ? "yes" : "no";
            lblPriceInput.Text = deal.salePrice.ToString() + "€";
            lblNormalPriceInput.Text = deal.normalPrice.ToString() + "€";

            if (deal.metacriticLink != null)
            {
                lblMetaInput.Text = "www.metacritic.com" + deal.metacriticLink;
                lblMetaInput.LinkArea = new LinkArea(0, lblMetaInput.Text.Length);
            }
            else
            {
                lblMetaInput.Text = "review is not available";
                lblMetaInput.LinkArea = new LinkArea(0, 0);
            }

            lblMetaScoreInput.Text = deal.metacriticScore != 0 ? deal.metacriticScore.ToString() : "score is not available";
            lblSteamRatingInput.Text = deal.steamRatingText != null ? deal.steamRatingText + " " + deal.steamRatingPercent + "%" : "rating is not available";
            imgGame.Load(deal.thumb);
        }

        private void UpdateFilters(bool enabled)
        {
            inputMaxPrice.Enabled = enabled;
            inputMinPrice.Enabled = enabled;
            inputMinRating.Enabled = enabled;
            chkOnSale.Enabled = enabled;
        }
    }
}