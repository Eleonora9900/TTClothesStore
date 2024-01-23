

using TTClothesStore_DL.Interfaces;
using TTClothesStore_DL.MemoryDB;
using TTClothesStore_Models.Models;

namespace TTClothesStore_DL.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public void Add(Item item)
        {
            InMemoryDB.ItemData.Add(item);
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                InMemoryDB.ItemData.Remove(item);
            }
        }

        public List<Item> GetAll()
        {
            return InMemoryDB.ItemData;
        }

        public List<Item> GetAllAvailableItemsForShop(int shopId)
        {
            return InMemoryDB.ItemData.Where(i => i.StoreId == shopId && i.IsAvalible == true).ToList();
        }

        public List<Item> GetAllByShopId(int shopId)
        {
            return InMemoryDB.ItemData.Where(i => i.StoreId == shopId).ToList();
        }

        public Item? GetById(int id)
        {
            return InMemoryDB.ItemData.FirstOrDefault(i => i.Id == id);
        }
    }
}
