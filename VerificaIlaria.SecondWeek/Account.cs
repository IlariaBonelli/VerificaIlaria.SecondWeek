using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaIlaria.SecondWeek
{
    public class Account
    {
        public int NumeroDiConto { get; set; }
        public string NomeDellaBanca { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }

        public List<Movement> Movimenti = new List<Movement>();

        public Account() { }

        public Account(int numConto, string nomeBanca, decimal saldo)
        {
            NumeroDiConto = numConto;
            NomeDellaBanca = nomeBanca;
            Saldo = saldo;
            DataUltimaOperazione = DateTime.Now;
        }

       
        public static bool operator +(Account account, Movement movimento)
        {
            account.Saldo += movimento.Importo;
            account.DataUltimaOperazione = DateTime.Now;
            account.AggiungiMovimento(movimento);
            return true;
        }

        //è l'importo inserito che avrà il valore negativo 
        public static bool operator -(Account account, Movement movimento)
        {
            account.Saldo += movimento.Importo;
            account.DataUltimaOperazione = DateTime.Now;
            account.AggiungiMovimento(movimento);
            return true;
        }

        public void AggiungiMovimento(Movement movimento)
        {
            Movimenti.Add(movimento);
        }

        public void Statement()
        {
            Console.WriteLine(this);
            foreach (Movement m in Movimenti)
                Console.Write(m);
        }

        public override string ToString()
        {
            string DatiDelConto = $"Numerdo di conto: {NumeroDiConto}, " +
                                  $"Nome della Banca:{NomeDellaBanca}," +
                                  $" Saldo: {Saldo}, " +
                                  $"Data dell'ultima operazione{DataUltimaOperazione}";
            return DatiDelConto;
        }



    }
}
