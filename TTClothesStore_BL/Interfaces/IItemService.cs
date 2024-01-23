using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTClothesStore_Models.Models;

namespace TTClothesStore_BL.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAll();
        Item?  GetById(int id);
        void Add(Item item);
        void Delete(int id);
        List<Item> GetAllByShopId(int shopId);
        List<Item> GetAllAvailableItemsForShop(int shopId);
    }
}
