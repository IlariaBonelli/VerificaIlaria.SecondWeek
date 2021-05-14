using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaIlaria.SecondWeek
{
    public class CashMovement: Movement
    {
        public string Esecutore { get; set; }

        public CashMovement(decimal importo,string esecutore) : base(importo)
        {
            Esecutore = esecutore;
        }


        public CashMovement(decimal importo, DateTime dataMov, string esecutore): base(importo, dataMov)
        {
            Esecutore = esecutore;
        }

        public override string ToString()
        {
            return base.ToString() + $"Esecutore: {Esecutore}";
        }

        public override void Statement()
        {
            Console.WriteLine(this);
        }


    }
}
