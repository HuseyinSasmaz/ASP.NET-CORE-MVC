using FluentValidation;
using GeziRehberim.Model;

namespace GeziRehberim.FluentValodations
{
    public class HakkımzdaValidator:AbstractValidator<Hakkımzda>
    {
        public HakkımzdaValidator()
        {
                RuleFor(x=>x.Acıklama).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez...");
            RuleFor(x => x.Resim).NotEmpty().WithMessage("Göresel seçiniz...");
        }
    }
}
