
using TTClothesStore_Models.Models;

namespace TTClothesStore_DL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<Store> StoreData = new List<Store>()
        {
            new Store()
            {
                Id = 9200,
                Name = "TTVarna",
                TownName = "Varna"
            },
            new Store() 
            {
                Id = 9201,
                Name = "TTPlovdiv",
                TownName = "Plovdiv"
            },
            new Store()
            {
                Id = 9202,
                Name = "TTCarfur",
                TownName = "Sofia"
            }
        };

        public static List<Item> ItemData = new List<Item>()
        {
            new Item()
            {
                Id = 00001,
                Type = "T-shirt",
                Season = "Summer",
                Colour = "30015",
                IsAvalible = true,
                StoreId = 9200
            },
            new Item()
            {
                Id = 00002,
                Type = "T-shirt",
                Season = "Summer",
                Colour = "29999",
                IsAvalible = true,
                StoreId = 9200
            },
            new Item()
            {
                Id = 00010,
                Type = "Skirt",
                Season = "Summer",
                Colour = "30015",
                IsAvalible = true,
                StoreId = 9202
            },
            new Item()
            {
                Id = 00221,
                Type = "Trousers",
                Season = "Spring",
                Colour = "30015",
                IsAvalible = false,
                StoreId = 9201
            },
            new Item()
            {
                Id = 1756,
                Type = "Dress",
                Season = "Summer",
                Colour = "30415",
                IsAvalible = true,
                StoreId = 9201
            },
            new Item()
            {
                Id = 00222,
                Type = "Trousers",
                Season = "Spring",
                Colour = "30015",
                IsAvalible = true,
                StoreId = 9200
            }
        };
    }
}
