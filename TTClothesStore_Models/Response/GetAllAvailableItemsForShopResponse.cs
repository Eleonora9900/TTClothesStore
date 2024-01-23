using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTClothesStore_Models.Models;

namespace TTClothesStore_Models.Response
{
    public class GetAllAvailableItemsForShopResponse
    {
        public Store ?Store { get; set; }
        public List<Item>? Items { get; set; }

    }
}
