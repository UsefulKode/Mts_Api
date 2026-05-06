namespace Mts_Api.Models.DTOs
{

    public class FullProductDTO : ShortProductDTO
    {
        public string Description { get; set; }
        // Словарь, куда мы запишем все уникальные поля (процессор, экран и т.д.)
        public Dictionary<string, string> Specs { get; set; } = new();
    }
}
