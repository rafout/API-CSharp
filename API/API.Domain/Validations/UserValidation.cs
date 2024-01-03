using API.Domain.Models;
using FluentValidation;

namespace API.Domain.Validations
{
    public class UserValidation : AbstractValidator<UserModel>
    {
        public UserValidation()
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
            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("O nome de usuário é obrigatório")
                .NotNull()
                .WithMessage("O nome de usuário é obrigatório")
                .MinimumLength(3)
                .WithMessage("O nome de usuário deve ter no mínimo 3 caracteres")
                .MaximumLength(50)
                .WithMessage("O nome de usuário deve ter no máximo 50 caracteres");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("A senha é obrigatória")
                .NotNull()
                .WithMessage("A senha é obrigatória")
                .MinimumLength(3)
                .WithMessage("A senha deve ter no mínimo 3 caracteres")
                .MaximumLength(50)
                .WithMessage("A senha deve ter no máximo 15 caracteres");
            RuleFor(x => x.Profile)
                .NotEmpty()
                .WithMessage("O perfil é obrigatório")
                .NotNull()
                .WithMessage("O perfil é obrigatório");
        }
    }
}
