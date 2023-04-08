using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Numarasını Yazınız")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Görseli Giriniz")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Giriniz")]
        [StringLength(100,ErrorMessage ="lütfen en fazla 100 karakter giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
        public string BatchCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama Yazınız")]
        public string Description { get; set; }
    }
}
