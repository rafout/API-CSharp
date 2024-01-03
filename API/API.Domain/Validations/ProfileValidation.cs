using API.Domain.Models;
using FluentValidation;

namespace API.Domain.Validations
{
    public class ProfileValidation : AbstractValidator<ProfileModel>
    {
        public ProfileValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O nome é obrigatório")
                .NotNull()
                .WithMessage("O nome é obrigatório")
                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres")
                .MaximumLength(50)
                .WithMessage("O nome deve ter no máximo 50 caracteres");
        }
    }
}
