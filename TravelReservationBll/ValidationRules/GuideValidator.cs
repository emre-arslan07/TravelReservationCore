using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.ValidationRules
{
   public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz");
            RuleFor(x => x.Name).MinimumLength(10).WithMessage("Lütfen en az 10 karakter uzunluğunda bir isim giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter uzunluğunda bir isim giriniz");
        }
    }
}
