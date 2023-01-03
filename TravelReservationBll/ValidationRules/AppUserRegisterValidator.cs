﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationDTO.DTOs.AppUserDTOs;

namespace TravelReservationBll.ValidationRules
{
   public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");

            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");
            RuleFor(x => x.Username).MaximumLength(5).WithMessage("Lütfen en fazla 20 karakter girişi yapınız");

            RuleFor(x => x.Password).NotEqual(x => x.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");
        }
    }
}
