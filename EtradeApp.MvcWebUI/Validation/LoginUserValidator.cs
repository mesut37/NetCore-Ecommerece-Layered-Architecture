using EtradeApp.MvcWebUI.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Validation
{
    public class LoginUserValidator: AbstractValidator<LoginViewModel>
    {
        public LoginUserValidator()
        {
            RuleFor(f => f.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez !");

            RuleFor(f => f.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez !");
        }
    }
}
