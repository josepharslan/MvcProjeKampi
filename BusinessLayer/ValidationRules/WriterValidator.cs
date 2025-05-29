using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Olamaz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soy Adı Boş Olamaz");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Yazar Adı En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvanı Boş Olamaz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Boş Olamaz");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar Adı 50 Karakterden Fazla Olamaz");
        }
    }
}
