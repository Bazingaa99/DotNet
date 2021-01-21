using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyLibrary
{
    public class MyProvider
    {
        public List<Store> stores;
        public List<Store> GetStores()
        {
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");
                string s = client.GetStringAsync("stores").Result;
                stores = JsonConvert.DeserializeObject<List<Store>>(s);
                return stores;
            }
        }

        public List<Deal> GetDeals(List<Store> stores, String title, int maxPrice, int minPrice, int minRating, int onSale)
        {
            List<Deal> deals = new List<Deal>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");
                foreach(Store store in stores)
                {
                    string s = client.GetStringAsync("deals?storeID=" + store.id + 
                                                     "&title=" + title + 
                                                     "&upperPrice=" + maxPrice +
                                                     "&lowerPrice=" + minPrice +
                                                     "&metacritic=" + minRating +
                                                     "&onSale=" + onSale).Result;
                    if(s != null)
                    {
                        var deal = JsonConvert.DeserializeObject<List<Deal>>(s);
                        deals.AddRange(deal);
                    }
                    
                }
                
                return deals;
            }
        }

        public List<Deal> GetDeals(int gameID)
        {
            List<Deal> deals = new List<Deal>();
            string dealID;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");

                string s = client.GetStringAsync("games?id=" + gameID.ToString()).Result;
                if (s != null)
                {
                    JObject result = JObject.Parse(s);

                    var resultDeals = result["deals"];

                    foreach(var d in resultDeals)
                    {
                        dealID = d["dealID"].ToString();
                        deals.Add(GetDeal(dealID));
                    }
                }

                return deals;
            }
        }

        public List<Deal> GetCheaperDeals(List<Deal> deals)
        {
            List<Deal> list = new List<Deal>();
            Deal d;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");
                foreach (Deal deal in deals)
                {
                    foreach (CheaperStores cheaperStore in deal.cheaperStores)
                    {
                        d = GetDeal(cheaperStore.dealID);

                        if (!list.Any(item => item.id == d.id))
                            list.Add(d);
                    }
                }
                
                return list;
            }
        }

        public List<Game> GetGames(string title)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");
                string s = client.GetStringAsync("games?title=" + title).Result;
                var list = JsonConvert.DeserializeObject<List<Game>>(s);
                return list;
            }
        }

        public Game GetGame(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");
                string s = client.GetStringAsync("games?id=" + id.ToString()).Result;
                var list = JsonConvert.DeserializeObject<Game>(s);
                return list;
            }
        }

        public Deal GetDeal(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.cheapshark.com/api/1.0/");
                string s = client.GetStringAsync("deals?id=" + id).Result;
                JObject result = JObject.Parse(s);
                Deal deal = result["gameInfo"].ToObject<Deal>();
                deal.id = id;
                deal.title = result["gameInfo"]["name"].ToString();
                deal.normalPrice = (float)result["gameInfo"]["retailPrice"];
                deal.cheaperStores = (List<CheaperStores>)result["cheaperStores"].ToObject<List<CheaperStores>>();
                deal.isOnSale = deal.normalPrice > deal.salePrice ? "1" : "0";
                return deal;
            }
        }

        public Store FindStore(int id)
        {
            Store store = stores.FirstOrDefault(s => s.id == id);
            return store != null ? store : new Store() { name = "Store not found" };
        }

        public float GetTotalPrice(List<Deal> deals, string priceType)
        {
            float sum = 0;

            Type dealType = typeof(Deal);
            PropertyInfo dealProperty = dealType.GetProperty(priceType);

            foreach (Deal deal in deals)
            {
                if (deal != null && dealProperty.GetValue(deal) is float)
                {
                    sum += (float)dealProperty.GetValue(deal);
                }
            }

            return sum;
        }
    }
}
