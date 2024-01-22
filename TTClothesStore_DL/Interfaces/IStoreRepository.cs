

using TTClothesStore_Models.Models;

namespace TTClothesStore_DL.Interfaces
{
    public interface IStoreRepository
    {
        List<Store> GetAll();
        Store? GetById(int id);
        void Add(Store store);  
        void Delete(int id);
    }
}
