using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class ServiceUpdateDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Servis İkon Linki Giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz")]
        [StringLength(100, ErrorMessage = "Max 100 Karakter.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz")]
        public string Description { get; set; }
    }
}
