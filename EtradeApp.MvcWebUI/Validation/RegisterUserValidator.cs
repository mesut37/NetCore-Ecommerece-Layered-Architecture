using EtradeApp.MvcWebUI.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Validation
{
    public class RegisterUserValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterUserValidator()
        {
            RuleFor(f => f.Email).NotEmpty().WithMessage("Email alanı boş geçilemez !").EmailAddress().WithMessage("Geçerli bir email adresi giriniz !");

            RuleFor(f => f.Phone).NotEmpty().WithMessage("Telefon alanı boş geçilemez !");

            RuleFor(f => f.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez !");

            RuleFor(f => f.Password).NotEmpty().WithMessage("Şifre alanı alanı boş geçilemez !");

            RuleFor(f => f.ConfirmPassword).NotEmpty().WithMessage("Şifre alanı alanı boş geçilemez !").Equal(f => f.Password).WithMessage("şifreler aynı değil");


        }
    }
}
