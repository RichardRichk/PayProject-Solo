using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagamento_Solo
{
    public class Debito : Cartao
    {
        public float Saldo {get; private set;} = 5000.00f;
        public override void Pagar()
        {
            ReceberValor();
            if (Valor > Saldo)
            {
                Console.WriteLine($"O valor e maior que seu saldo! Voce nao pode realizar a compra!");
                Console.WriteLine($"Voltando para menu inicial...");                
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Compra realizada, seu saldo agora e de:");
                Console.WriteLine($"{Saldo - Valor}");   
                Console.WriteLine($"Tecle <ENTER> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter); 
                Console.Clear();          
            }
        }
    }
}