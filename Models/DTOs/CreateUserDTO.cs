using System.ComponentModel.DataAnnotations;

namespace Mts_Api.Models.DTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Имя обязательно.")]
        [StringLength(100, ErrorMessage = "Имя не может быть длиннее 100 символов.")]
        public string Fname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Фамилия обязательна.")]
        [StringLength(100, ErrorMessage = "Фамилия не может быть длиннее 100 символов.")]
        public string Lname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Роль обязательна.")]
        // Уточните, если Role - это int или enum, и нужна дополнительная валидация
        public string Role { get; set; } = string.Empty;

        [Required(ErrorMessage = "Логин обязателен.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Логин должен быть от 3 до 50 символов.")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обязателен.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль должен быть от 6 до 100 символов.")]
        public string Password { get; set; } = string.Empty;

        
    }
}
