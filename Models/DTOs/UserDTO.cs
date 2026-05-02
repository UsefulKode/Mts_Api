namespace Mts_Api.Models.DTOs
{//get
    public class UserDTO
    {
        public int Id { get; set; }
        public string Fname { get; set; } = string.Empty;

        //public string Lname { get; set; } = string.Empty;
        //public string Role { get; set; } = string.Empty;
        //public string Login { get; set; } = string.Empty;

        // Добавьте сюда только те свойства, которые вы хотите возвращать
        // Например, если у вас есть поле PasswordHash, его здесь быть не должно
    }
}
