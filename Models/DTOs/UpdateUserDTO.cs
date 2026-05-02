using System.ComponentModel.DataAnnotations;

namespace Mts_Api.Models.DTOs
{
    public class UpdateUserDTO
    {
        [Required(ErrorMessage = "Имя обязательно.")]
        [StringLength(100, ErrorMessage = "Имя не может быть длиннее 100 символов.")]
        public string Fname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Фамилия обязательна.")]
        [StringLength(100, ErrorMessage = "Фамилия не может быть длиннее 100 символов.")]
        public string Lname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Роль обязательна.")]
        public string Role { get; set; } = string.Empty;

        [Required(ErrorMessage = "Логин обязателен.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Логин должен быть от 3 до 50 символов.")]
        public string Login { get; set; } = string.Empty;
    }
}
