using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz!!")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz!!")]
        public string? mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz!!")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekarar Giriniz!!")]
        [Compare("password",ErrorMessage = "Şifreler Uyumlu Değil, Kontrol Ediniz!")]
        public string? passwordConfirm { get; set; }

       
    }
}
