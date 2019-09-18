using EtradeApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Validation
{
    public class ShippingDetailsValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailsValidator()
        {
            RuleFor(f => f.FirstName).NotEmpty().WithMessage("İsim bilgisi boş geçilemez !");

            RuleFor(f => f.LastName).NotEmpty().WithMessage("Soyisim bilgisi boş geçilemez !");

            RuleFor(f => f.Email).NotEmpty().WithMessage("Email bilgisi boş geçilemez !").EmailAddress().WithMessage("Geçerli bir email adresi giriniz !");

            RuleFor(f => f.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez !");

            RuleFor(f => f.Phone).NotEmpty().WithMessage("Telefon bilgisi boş geçilemez !");

            RuleFor(f => f.Adress).NotEmpty().WithMessage("Adres bilgisi boş geçilemez !");
        }
    }
}
