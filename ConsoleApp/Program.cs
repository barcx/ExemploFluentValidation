using System;

namespace ConsoleApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var jogadorValido = new JogadorFutebol()
            {
                Nome = "Edmundo",
                Posicao = "Atacante",
                Salario = 1000000
            };
            var validator = new JogadorFutebolValidator();
            var result = validator.Validate(jogadorValido);
            Console.WriteLine($"Os dados do jogador {jogadorValido.Nome} são válidos? ({result.IsValid})");

            var jogadorFutebolInvalido = new JogadorFutebol()
            {
                Nome = "Ribamar",
                Posicao = "O mais longe possível de um campo.",
                Salario = -1000000
            };
            result = validator.Validate(jogadorFutebolInvalido);
            Console.WriteLine($"Os dados do jogador {jogadorFutebolInvalido.Nome} são válidos? ({result.IsValid})");
            foreach (var falha in result.Errors)
            {
                Console.WriteLine("Propriedade: " + falha.PropertyName + ". Erro: " + falha.ErrorMessage);
            }
        }
    }
}
