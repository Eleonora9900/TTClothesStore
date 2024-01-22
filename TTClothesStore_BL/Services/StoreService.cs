
using TTClothesStore_BL.Interfaces;
using TTClothesStore_DL.Interfaces;
using TTClothesStore_Models.Models;

namespace TTClothesStore_BL.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;

        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;   
        }
        public void Add(Store store)
        {
            _storeRepository.Add(store);
        }

        public void Delete(int id)
        {
            _storeRepository.Delete(id);
        }

        public List<Store> GetAll()
        {
            return _storeRepository.GetAll();
        }

        public Store? GetById(int id)
        {
            return _storeRepository.GetById(id);
        }
    }
}
