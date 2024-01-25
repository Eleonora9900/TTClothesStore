using TTClothesStore_DL.Interfaces;
using TTClothesStore_Models.Models;
using Moq;
using TTClothesStore_DL.Repositories;
using TTClothesStore_BL.Services;
using TTClothesStore_Models.Request;
namespace TTClothesUnitTest
{
    public class ShoppingServiceTests
    {
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

        [Fact]
        public void chekItemCount_OK()
        {
            var input = 10;
            var expectedCount = 16;

            var mockedItemRepository = new Mock<IItemRepository>();
            mockedItemRepository.Setup(x => x.GetAll()).Returns(ItemData);

            //inject
            var itemService = new ItemService(mockedItemRepository.Object);
            var storeService = new StoreService(new StoreRepository());
            var service = new ShoppingService(storeService, itemService);

            //Act
            var result = service.CheckItemCount(input);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllAvailableItemsForShop_OK()
        {
            //Set up
            var request = new GetAllAvailableItemsForShopRequest()
            {
                shopId = 9200
            };

            var expectedCount = 3;
            var mockedItemRepository = new Mock<ItemRepository>();
            var mockedStoreRepository = new Mock<IStoreRepository>();

            mockedStoreRepository.Setup(x => x.GetById(request.shopId))
                .Returns(StoreData!.FirstOrDefault(s => s.Id == request.shopId));
            mockedItemRepository.Setup(i => i.GetAllAvailableItemsForShop(request.shopId))
                .Returns(ItemData.Where(i => i.StoreId == request.shopId && i.IsAvalible == true).ToList());
            //Inject
            var itemService = new StoreService(mockedStoreRepository.Object);
            var storeService = new ItemService(mockedItemRepository.Object);
            var service = new ShoppingService(itemService, storeService);

            //Act
            var result = service.GetAvailableItemsForShopId(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Items.Count);
            Assert.Equal(request.shopId, result.Store.Id);


        }
    }
}