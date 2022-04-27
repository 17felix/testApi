using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi
{
    public  class Other
    {
        [JsonProperty("storeId")]
        public long StoreId { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public  class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("stock")]
        public string Stock { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("children")]
        public Item[] Children { get; set; }

        [JsonProperty("availableFrom")]
        public object AvailableFrom { get; set; }

        [JsonProperty("availableTo")]
        public object AvailableTo { get; set; }

        [JsonProperty("rappiIds")]
        public long[] RappiIds { get; set; }

        [JsonProperty("sortingPosition")]
        public long SortingPosition { get; set; }

        [JsonProperty("maxLimit")]
        public long MaxLimit { get; set; }
    }

    public  class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("minQty")]
        public long MinQty { get; set; }

        [JsonProperty("maxQty")]
        public long MaxQty { get; set; }

        [JsonProperty("sortingPosition")]
        public long SortingPosition { get; set; }
    }
}


// json to c#: https://app.quicktype.io/?l=csharp
// can i init many class in one? nested types