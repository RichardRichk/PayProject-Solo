using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagamento_Solo
{
    public class Credito : Cartao
    {
        public float Limite {get; private set;} = 5000.00f;

        public int parcelas {get; private set;}

        private bool loopBreak = true;

        public override void Pagar()
        {
            ReceberValor();

            if (Valor > Limite)
            {
                Console.WriteLine($"O valor e maior que seu limite! Voce nao pode realizar a compra!");
                Console.WriteLine($"Voltando para menu inicial...");  
            }
            else
            {
                do
                {
                    
                    Console.WriteLine($"O valor sera parcelado em quantas vezes ? (De 1 a 12)");
                    parcelas = int.Parse(Console.ReadLine());
                    switch (parcelas)
                    {
                        case <=0:
                        Console.WriteLine($"O numero de parcelas não pode ser menor ou igual a 0 ! Digite novamente"); 
                        Thread.Sleep(2000);
                        Console.Clear();                  
                            break;

                        case <=6:
                        Console.WriteLine($"Sera cobrado 5% de juros.");
                        Console.WriteLine($"Valor inicial: {Valor.ToString("C2")}");
                        Console.WriteLine($"Valor final: {(Valor * Math.Pow(1 + 0.05, parcelas)).ToString("C2")}");
                        Console.WriteLine($"Valor por parcela: {(Valor * Math.Pow(1 + 0.05, parcelas)/parcelas).ToString("C2")}");
                        
                        
                        loopBreak = false;               
                            break;

                        case <=12:
                        Console.WriteLine($"Sera cobrado 8% de juros.");
                        loopBreak = false;
                            break;

                        default:
                        Console.WriteLine($"Numero de parcelas nao disponivel! Escreva novamente");   
                        Thread.Sleep(2000);
                        Console.Clear();                  
                        break;
                    }
                } while (loopBreak);
                            
            }
        }
    }
}