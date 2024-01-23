using Microsoft.AspNetCore.Mvc;
using TTClothesStore_BL.Interfaces;
using TTClothesStore_Models.Models;

namespace TTClothesStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {

        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Item> GetAll()
        {
            return _itemService.GetAll();
        }

        [HttpGet("GetById")]
        public Item? GetById(int id)
        {
            return _itemService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Item item) 
        { 
            _itemService.Add(item);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _itemService.Delete(id);
        }
    }
}
