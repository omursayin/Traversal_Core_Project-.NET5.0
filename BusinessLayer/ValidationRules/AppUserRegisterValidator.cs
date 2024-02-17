using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator() 
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyisim alanı boş bırakılamaz.");
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanı boş bırakılamaz.");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifreyi Onayla alanı boş bırakılamaz.");
            RuleFor(x=>x.UserName).MinimumLength(5).WithMessage("Kullanıcı Adı en az 5 karakterden oluşmalıdır.");
            RuleFor(x=>x.UserName).MaximumLength(20).WithMessage("Kullanıcı Adı en fazla 20 karakterden oluşmalıdır.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbirleriyle uyuşmuyor.");
        }
    }
}
