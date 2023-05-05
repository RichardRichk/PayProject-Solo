using Pagamento_Solo;
internal class Program
{
    private static void Main(string[] args)
    {
        Debito debito = new Debito();
        Credito credito = new Credito();
        Pagamento pagamento = new Pagamento();
        
        Console.Clear();

        Console.WriteLine($"Hello World!");

        debito.Pagar();
                         
    }
}