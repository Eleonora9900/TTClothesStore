



using TTClothesStore_DL.Interfaces;
using TTClothesStore_DL.MemoryDB;
using TTClothesStore_Models.Models;

namespace TTClothesStore_DL.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        public void Add(Store store)
        {
            InMemoryDB.StoreData.Add(store);
        }

        public void Delete(int id)
        {
            var store = GetById(id);
            if ( store != null)
            {
                InMemoryDB.StoreData.Remove(store);
            }
        }

        public List<Store> GetAll()
        {
            return InMemoryDB.StoreData;
        }

        public Store? GetById(int id)
        {
            return InMemoryDB.StoreData.FirstOrDefault(s => s.Id == id);
        }
    }
}
