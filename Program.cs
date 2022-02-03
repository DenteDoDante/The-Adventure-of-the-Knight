namespace Rpg
{
    class Game
    {
      bool cabeloLiso = false;
      bool cabeloCurto = false;
      bool cabeloBranco = false;
      bool cabeloPreto = false;
      bool olhoPuxado = false;
      bool olhoAbertos = false;
      bool olhoSemOlhos = false;
      bool olhoAmarelo = false;
      bool olhoPreto = false;


       static void Main(string []args)
       {
         PressioneEnter();
         static void PressioneEnter()
         {       
          Console.Title = "The Adventure of the knight";
          Console.WriteLine("COMEÇAR? " + " PRESSIONE ''ENTER'' ");
          otimizacao();
          Console.Clear();
          inicio();
         }
         static void inicio()
         {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("ATENÇÃO! \n RESPOSTAS EM MAIUSCULO \n 'ENTER' PARA CONTINUAR");
          otimizacao();
          Console.Clear();
          System.Threading.Thread.Sleep(500);
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("Zzzzzzz...");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Zzzzzzz...");
          System.Threading.Thread.Sleep(1000);
          Console.WriteLine("Zzzzzzz...");
          System.Threading.Thread.Sleep(1000);
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Acordar a silhueta? " + " 'ENTER' ");
          otimizacao();
          Console.Clear();
          Console.WriteLine("A silhueta se levanta de sua cama e caminha ate ficar de frente a um espelho");
          Console.WriteLine("COMO É A SILHUETA ?");
          Criacao();
          }
          static void Criacao()
          {
            Console.WriteLine("CABELO?");
            System.Threading.Thread.Sleep(600);
            Console.Write("1 GRANDE E LISO,2 CURTO: ");
            string escolhaCabelo = Console.ReadLine();
            switch (escolhaCabelo)
            {
              case "1":
              case "GRANDE E LISO":
              {
                Caracteristica.setTipoCabelo(1);
                Console.ReadLine();
                break;
              }
              case "2":
              case "CURTO":
              {

                break;
              }
              default:
              {
                opcaoInvalida();
                Console.Clear();
                Criacao();
                break;
              }
            }
           
          }
          static void corCabelo()
          {
            Console.WriteLine("QUAL É A COR?");
            System.Threading.Thread.Sleep(600);
            Console.Write("1 BRANCO,2 PRETO: ");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
              System.Threading.Thread.Sleep(400);
              bool cabeloBranco = true;
              Console.Clear();
              Olho();
            }
            else if (Console.ReadKey().Key == ConsoleKey.D2)
            {
              System.Threading.Thread.Sleep(400);
              bool cabeloPreto = true;
              Console.Clear();
              Olho();
            }
            else
            {
              Console.Clear();
              corCabelo();
            }
          }
          static void Olho()
          {
            Console.WriteLine("COMO SÃO SEUS OLHOS?");
            System.Threading.Thread.Sleep(600);
            Console.Write("1 ABERTOS,2 PUXADO E FECHADO,3 SEM OLHOS: ");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
              System.Threading.Thread.Sleep(400);
              bool olhoAbertos = true;
              Console.Clear();
              corOlho();
            }
            else if (Console.ReadKey().Key == ConsoleKey.D2)
            {
              System.Threading.Thread.Sleep(400);
              bool olhoFechado = true;
              Console.Clear();
              corOlho();
            }
            else if (Console.ReadKey().Key == ConsoleKey.D3)
            {  
              System.Threading.Thread.Sleep(400);
              bool olhoSemOlhos = true;
              Console.Clear();
              Console.WriteLine("SEM OLHOS?");
              System.Threading.Thread.Sleep(3000);
              Semolhos();
            }
            else
            {
              Console.Clear();
              corOlho();
            }
            static void corOlho()
            {
              Console.WriteLine("QUAL A COR DE SEUS OLHOS?");
              System.Threading.Thread.Sleep(600);
              Console.Write("1 AMARELO,2 PRETO: ");
              if (Console.ReadKey().Key == ConsoleKey.D1) 
              {
                System.Threading.Thread.Sleep(400);
                bool olhoAmarelo = true;
                Console.Clear();
                Confirmacao();
              }
              else if (Console.ReadKey().Key == ConsoleKey.D2)
              {
                System.Threading.Thread.Sleep(400);
                bool olhoPreto = true;
                Console.Clear();
                Confirmacao();
              }
              else 
              {
                Console.Clear();
                corOlho();
              }
            }
            static void Confirmacao()
            {
              Console.Clear();
              Console.WriteLine(" É ASSIM QUE A SILHUETA SE PARECE? ");
              System.Threading.Thread.Sleep(1000);
              
            }
            static void Comeco()
            {

            }
            static void Semolhos()
            {
              Console.Clear();
              Console.WriteLine("CERTEZA?");
              System.Threading.Thread.Sleep(900);
              Console.WriteLine("DIGITE AQUI SUA RESPOSTA");
              Console.ReadLine();
              string certeza = Console.ReadLine();
              switch (certeza)
              {
                case "Sim":
                case "s":
                case "y":
                {
                  break;
                }
                case "Não":
                case "Nao":
                {
                  break;
                }
              }
            }
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
        static void opcaoInvalida()
        {
          Console.WriteLine("OPÇÃO INVALIDA APERTE 'ENTER' PARA CONTINUAR");
          Console.ReadLine();
        }
        #endregion
    }
}
