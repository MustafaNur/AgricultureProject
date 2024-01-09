using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x=>x.PersonelName).NotEmpty().WithMessage("Takım arkadaşı ismini boş geçmeyiniz.");
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Görev boş geçmeyiniz.");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Url boş geçmeyiniz.");
            RuleFor(x=>x.PersonelName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az giriş yapınız.");
            RuleFor(x=>x.PersonelName).MinimumLength(3).WithMessage("Lütfen en az 3 karakterden daha fazla giriş yapınız.");
        }
    }
}
