using Microsoft.AspNetCore.Mvc;
using TTClothesStore_BL.Interfaces;
using TTClothesStore_Models.Models;

namespace TTClothesStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Store> GetAll()
        {
            return _storeService.GetAll();
        }

        [HttpGet("GetById")]
        public Store? GetById(int id)
        {
            return _storeService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Store store)
        {
            _storeService.Add(store);
        }

        [HttpGet("Delete")]
        public void Delete(int id)
        {
            _storeService.Delete(id);
        }

    }
}
