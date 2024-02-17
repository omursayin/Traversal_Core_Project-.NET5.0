using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanını boş bırakamazsınız!..");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanını boş bırakamazsınız!..");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanını boş bırakamazsınız!..");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanını boş bırakamazsınız!..");
        }
    }
}
