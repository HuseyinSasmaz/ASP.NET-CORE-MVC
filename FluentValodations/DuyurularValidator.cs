using FluentValidation;
using GeziRehberim.Model;

namespace GeziRehberim.FluentValodations
{
    public class DuyurularValidator:AbstractValidator<Duyurular>
    {
        public DuyurularValidator() 
        {
            RuleFor(x => x.Baslık).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyiniz...!");
            RuleFor(x => x.İcerik).NotEmpty().WithMessage("Lütfen içeriği boş geçmeyiniz...!");
            RuleFor(x => x.Baslık).MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalıdır...!");
            RuleFor(x => x.İcerik).MinimumLength(20).WithMessage("İçerik en az 20 karakter olmalıdır...!");
            RuleFor(x => x.Baslık).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter olmalıdır...!");
            RuleFor(x => x.İcerik).MaximumLength(500).WithMessage("İçerik en fazla 500 karakter olmalıdır...!");
        }
    }
}
