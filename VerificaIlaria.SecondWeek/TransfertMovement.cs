using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaIlaria.SecondWeek
{
    public class TransfertMovement: Movement
    {
        public string BancaOrigine { get; set; }
        public string BancaFinale { get; set; }

        public TransfertMovement(decimal importo,string bancaOrig, string bancaFin) : base(importo)
        {
            BancaOrigine = bancaOrig;
            BancaFinale = bancaFin;
        }

        public TransfertMovement(decimal importo, DateTime dataMov, string bancaOrig, string bancaFin): base(importo, dataMov)
        {
            BancaOrigine = bancaOrig;
            BancaFinale = bancaFin;
        }

        public override string ToString()
        {
            return base.ToString() + $"Banca di origine {BancaOrigine}, Banca di Destinazione {BancaFinale}";
        }

        public override void Statement()
        {
            Console.WriteLine(this);
        }



    }
}
