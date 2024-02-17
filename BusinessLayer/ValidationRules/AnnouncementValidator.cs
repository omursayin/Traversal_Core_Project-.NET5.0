using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmını boş bırakamazsınız!..");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Duyuru kısmını boş bırakamazsınız!..");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık en az 5 karakterden oluşmalıdır.");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Duyuru en az 20 karakterden oluşmalıdır.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık fazla 50 karakterden oluşmalıdır.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Duyuru en fazla 500 karakterden oluşmalıdır.");
        }
    }
}
