namespace ConsoleApp
{
    public class JogadorFutebol
    {
        public string Nome { get; set; }

        public string Posicao { get; set; }

        public decimal Salario { get; set; }

        public JogadorFutebol()
        {
        }

        public JogadorFutebol(string nome, string posicao, decimal salario)
        {
            Nome = nome;
            Posicao = posicao;
            Salario = salario;
        }

        public string Apresentar() => $"Oi! Meu nome é {Nome} e jogo na posição {Posicao}.";

        public void ConcederAumentoSalarial(decimal percentual)
        {
            if (percentual < 0)
            {
                return;
            }
            Salario += Salario * (percentual / 100);
        }
    }
}
