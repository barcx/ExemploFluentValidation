using FluentValidation;

namespace ConsoleApp
{
    public class JogadorFutebolValidator : AbstractValidator<JogadorFutebol>
    {
        public JogadorFutebolValidator()
        {
            RuleFor(f => f.Nome)
            .NotEmpty().WithMessage("Informe o nome.")
            .Length(2, 200).WithMessage("O nome deve ter entre 2 e 200 caracteres.");

            RuleFor(f => f.Posicao)
                .NotEmpty().WithMessage("Informe a posição.")
                .Length(5, 50).WithMessage("O nome deve ter entre 5 e 50 caracteres.");

            RuleFor(f => f.Salario)
                .NotEmpty()
                .GreaterThan(0).WithMessage("O salário deve ser maior que 0.");
        }
    }
}
