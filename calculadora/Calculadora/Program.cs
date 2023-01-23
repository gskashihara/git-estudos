namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var teclado = new Teclado();
            var condicional = true;
            while(condicional)
            {
                menu.PrintMenu();

                var opcao = (int)teclado.Recebe_num();
                
                if ((Enum)opcao == Enum.Sair) break;
                
                menu.PrintTeclado();
                Console.WriteLine("Resultado: " + menu.Selecao(opcao, teclado));
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            
        }
    }
}