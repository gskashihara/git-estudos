namespace MentoriaDev
{
    public class Calculadora
    {
        private Dictionary<TiposOperacao, IOperacao> operacoes = new Dictionary<TiposOperacao, IOperacao>(){
            { TiposOperacao.Somar, new Somar() },
        };

        public Calculadora(double num1, double num2, TiposOperacao operacao)
        {
            Num1 = num1;
            Num2 = num2;
            Operacao = operacao;
        }

        public double Num1 { get; private set; }
        public double Num2 { get; private set; }
        public TiposOperacao Operacao { get; private set; }
        public double Calcular()
        {
            if (!operacoes.ContainsKey(Operacao))
                throw new Exception("Operação não foi implementada");

            return operacoes[Operacao].Calcular(Num1, Num2);
        }

    }
}

