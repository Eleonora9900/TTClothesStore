using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTClothesStore_Models.CustomExceptions
{
    public class ShopIdNotFoundException : Exception
    {
        public ShopIdNotFoundException() { }
        public ShopIdNotFoundException(string message) : base(message) { }
        public ShopIdNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
