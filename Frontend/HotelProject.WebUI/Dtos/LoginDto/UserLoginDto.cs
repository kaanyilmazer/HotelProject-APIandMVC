using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class UserLoginDto
    {
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Şifrenizi Giriniz.")]
        public string Password { get; set; }
    }
}
