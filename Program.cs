namespace Rpg
{
    class Game
    {
       static void Main(string []args)
       {
         Começar();
         static void Começar()
         {       
          Console.Title = "The Adventure of the knight";
          Console.WriteLine("COMEÇAR? " + " PRESSIONE ''ENTER'' ");
          Console.Clear();
          otimizacao();
          Console.Clear();
          inicio();
         }
         static void inicio()
         {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("Zzzzzzz...");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Zzzzzzz...");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Zzzzzzz...");
          Console.ForegroundColor = ConsoleColor.White;
          otimizacao();
          Console.WriteLine("Blink");
          System.Threading.Thread.Sleep(300);
          Console.WriteLine("Blink");
          System.Threading.Thread.Sleep(300);
          Console.WriteLine("Blink");
          System.Threading.Thread.Sleep(700);
          Console.WriteLine("A silhueta se levanta de sua cama e caminha ate ficar de frente a um espelho");
          Console.ReadLine();
          Console.WriteLine("COMO É A SILHUETA ?");
          Criacao();
          }
          static void Criacao()
          {
            Console.WriteLine("Olhos");
            Personalizacoes.EscolhaOlho();
          }
        }
        #region otimizacao
            
        static void otimizacao()
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
              
            }
            else
            {
              otimizacao();
            }
        }
        #endregion
    }
}
