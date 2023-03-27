using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationDTO.DTOs.ContactDTOs;

namespace TravelReservationBll.ValidationRules
{
   public class SendContactUsValidator:AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına minimum 5 karakter girmelisiniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına maximum 100 karakter girmelisiniz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
        }
    }
}
