using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTClothesStore_BL.Interfaces;
using TTClothesStore_DL.Interfaces;
using TTClothesStore_Models.Models;

namespace TTClothesStore_BL.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void Add(Item item)
        {
            _itemRepository.Add(item);
        }

        public void Delete(int id)
        {
            _itemRepository.Delete(id);
        }

        public List<Item> GetAll()
        {
            return _itemRepository.GetAll();
        }

        public List<Item> GetAllByShopId(int shopId)
        {
            return _itemRepository.GetAllByShopId(shopId);
        }

        public Item? GetById(int id)
        {
            return _itemRepository.GetById(id);
        }
    }
}
