using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTClothesStore_Models.Request;
using TTClothesStore_Models.Response;

namespace TTClothesStore_BL.Interfaces
{
    public interface IShoppingService
    {
        public GetAllItemsByShopIdResponse
            GetAllItemsByShopId(GetAllItemsByShopIdRequest request);
    }
}
