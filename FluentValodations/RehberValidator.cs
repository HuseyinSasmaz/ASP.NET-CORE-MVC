using FluentValidation;
using GeziRehberim.Model;

namespace GeziRehberim.FluentValodations
{
    public class RehberValidator:AbstractValidator<Rehber>
    {
       public RehberValidator() 
        {
            RuleFor(x => x.Adı).NotEmpty().WithMessage("Lütfen rehber adını giriniz...");
            RuleFor(x => x.Acıklama).NotEmpty().WithMessage("Lütfen rehber acıklamasini giriniz...");
            RuleFor(x => x.Resim).NotEmpty().WithMessage("Lütfen rehber görselini giriniz...");
        } 
    }
}
