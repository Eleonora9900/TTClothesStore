using Microsoft.AspNetCore.Mvc;
using TTClothesStore_BL.Interfaces;
using TTClothesStore_Models.Request;
using TTClothesStore_Models.Response;

namespace TTClothesStoreApp.Controllers
{
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingService _shoppingService;

        public ShoppingController(IShoppingService shoppingService)
        {
            _shoppingService = shoppingService;
        }

        [HttpPost("GetAllItemsByShopId")]
        public GetAllItemsByShopIdResponse GetAllItemsByShopId(GetAllItemsByShopIdRequest request)
        {
            return _shoppingService.GetAllItemsByShopId(request);
        }
    }
}
