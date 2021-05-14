using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaIlaria.SecondWeek
{
    public enum Tipo
    {
        AMEX,
        VISA,
        MASTERCARD,
        OTHER
    }

    public class CreditCardMovement: Movement
    {
        public int NumeroDiCarta { get; set; }
        public Tipo TipoDicarta { get; set; }

        public CreditCardMovement(decimal importo, int numeroDiCarta, Tipo tipoDiCarta): base(importo)
        {
            NumeroDiCarta = numeroDiCarta;
            TipoDicarta = tipoDiCarta;
        }


        public CreditCardMovement(decimal importo, DateTime dataMov,int numeroDiCarta, Tipo tipoDiCarta): base(importo,dataMov)
        {
            NumeroDiCarta = numeroDiCarta;
            TipoDicarta = tipoDiCarta;

        }

        public override string ToString()
        {
            return base.ToString() + $"Numero della carta {NumeroDiCarta}, Tipo di carta: {TipoDicarta}";
        }

        public override void Statement()
        {
            Console.WriteLine(this);
        }


    }
}
