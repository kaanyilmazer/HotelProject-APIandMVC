using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lütfen Oda Numarasını Yazınız")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage ="Lütfen Oda Başlığı Giriniz")]
        public string Title { get; set; }
        public string BedCount { get; set; }
        [Required(ErrorMessage ="Lütfen banyo sayısı giriniz.")]
        public string BatchCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
