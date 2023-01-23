namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var teclado = new Teclado();
            var condicional = 0;
            while(condicional != -9999)
            {
                menu.PrintMenu();

                var opcao = (int)teclado.Recebe_num();
                menu.PrintTeclado();
                if (opcao == 4) break;
                
                var valor1 = teclado.Recebe_num();
                var valor2 = teclado.Recebe_num();
                Console.WriteLine("Resultado: " + menu.Selecao(opcao, valor1, valor2));
            }
            
        }
    }
}