using System;

namespace VerificaIlaria.SecondWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nell'applicazione Banca");
            
            //creo un account
            Account account1 = new Account(11111, "Intesa SanPaolo", 3570);

            //ho tentato per un paio d'ore di realizzare l'inserimento dati da input dell'utente ma non sono stata in grado 
            CreditCardMovement movimento1 = new CreditCardMovement(159, DateTime.Now, 34567, Tipo.MASTERCARD);
            CashMovement movimento2 = new CashMovement(-437, DateTime.Today, "Leonard Henry McCoy"); //ebbene sì, ha un secondo nome! :D
            TransfertMovement movimento3 = new TransfertMovement(1000, DateTime.Now, "Banca Intesa", "Banca Sella"); ;

            if(account1 + movimento1)
            {
                Console.WriteLine($"Operazione eseguita sul conto numero" +
                    $" {account1.NumeroDiConto}, " +
                    $"Tipo di movimento: {movimento1.ToString()}," +
                    $" Saldo {account1.Saldo}");
            }

            if (account1 + movimento2)
            {
                Console.WriteLine($"Operazione eseguita sul conto numero" +
                    $" {account1.NumeroDiConto}, " +
                    $"Tipo di movimento: {movimento2.ToString()}," +
                    $" Saldo {account1.Saldo}");
            }

            account1.Statement();

        }
    }
}
