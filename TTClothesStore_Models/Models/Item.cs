
namespace TTClothesStore_Models.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;
        public string Colour {  get; set; } = string.Empty;
        public bool IsAvalible { get; set; }
        public int StoreId { get; set; }
    }
}
