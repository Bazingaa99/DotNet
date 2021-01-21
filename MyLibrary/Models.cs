using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MyLibrary
{
    public class Game
    {
        [JsonProperty("gameID")]
        public int id { get; set; }
        [JsonProperty("external")]
        public string title { get; set; }
    }

    public class Store
    {
        [JsonProperty("storeID")]
        public int id { get; set; }
        [JsonProperty("storeName")]
        public string name { get; set; }
        public bool isActive { get; set; }

        public override String ToString()
        {
            return name;
        }
    }

    public class Deal
    {
        [JsonProperty("dealID")]
        public string id { get; set; }
        public string title { get; set; }
        public string metacriticLink { get; set; }
        public int storeID { get; set; }
        public int gameID { get; set; }
        public float salePrice { get; set; }
        public float normalPrice { get; set; }
        public string isOnSale { get; set; }
        public int metacriticScore { get; set; }
        public string steamRatingText { get; set; }
        public string steamRatingPercent { get; set; }
        public string thumb { get; set; }
        public List<CheaperStores> cheaperStores { get; set; }
    }

    public class CheaperStores
    {
        public string dealID { get; set; }
        public int storeID { get; set; }
        public float salePrice { get; set; }
        [JsonProperty("retailPrice")]
        public float normalPrice { get; set; }
    }
}
