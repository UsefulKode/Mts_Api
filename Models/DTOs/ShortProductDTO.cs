namespace Mts_Api.Models.DTOs
{
    public class ShortProductDTO
    {
        public string Category {  get; set; }
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ? ImageUrl { get; set; }
    }
}
