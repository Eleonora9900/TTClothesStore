

using TTClothesStore_Models.Models;

namespace TTClothesStore_Models.Response
{
    public class GetAllItemsByShopIdResponse
    {
        public Store ?Store { get; set; }
        public List<Item> ?Items { get; set; }   
    }
}
