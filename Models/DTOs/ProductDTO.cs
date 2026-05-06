namespace Mts_Api.Models.DTOs
{
    public class ProductDTO
    {
        // Базовые поля (есть у всех: и у тарифа, и у ТВ)
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Словарь для доп. характеристик: Ключ — Название ("ОС"), Значение — ("Android 14")
        public Dictionary<string, string> Specifications { get; set; } = new();
    }
}
