﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTClothesStore_BL.Interfaces;
using TTClothesStore_Models.Request;
using TTClothesStore_Models.Response;

namespace TTClothesStore_BL.Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly IStoreService _storeService;
        private readonly IItemService _itemService;

        public ShoppingService(IStoreService storeService, IItemService itemService)
        {
            _itemService = itemService;
            _storeService = storeService;
        }

        public int CheckItemCount(int input)
        {
            var itemCount = _itemService.GetAll();
            return itemCount.Count + input;
        }

        public GetAllItemsByShopIdResponse GetAllItemsByShopId(GetAllItemsByShopIdRequest request)
        {
            var result = new GetAllItemsByShopIdResponse();
            result.Store = _storeService.GetById(request.ShopId);
            result.Items = _itemService.GetAllByShopId(request.ShopId);
            return result;
        }

        public GetAllAvailableItemsForShopResponse GetAvailableItemsForShopId(GetAllAvailableItemsForShopRequest request)
        {
            var result = new GetAllAvailableItemsForShopResponse();
            result.Store = _storeService.GetById(request.shopId);
            result.Items = _itemService.GetAllAvailableItemsForShop(request.shopId);
            return result;
        }
    }
}
