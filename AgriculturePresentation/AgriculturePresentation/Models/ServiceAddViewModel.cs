using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık Boş Geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel Boş Geçilemez")]
        public string Image { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string Description { get; set; }
    }
}
