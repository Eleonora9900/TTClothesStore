
using System.ComponentModel;
using TTClothesStore_Models.Models;

namespace TTClothesStore_DL.Interfaces
{
    public interface IItemRepository
    {
        List<Item>GetAll();
        Item? GetById(int id);
        void Add(Item item);
        void Delete(int id);
        List<Item> GetAllByShopId(int shopId);
    }
}
