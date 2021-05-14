using System;

namespace VerificaIlaria.SecondWeek
{
    public abstract class Movement
    {
        public decimal Importo { get; set; }
        public DateTime DataDelMovimento { get; set; }

        public Movement() { }

        public Movement(decimal importo): this(importo, DateTime.Now) { }

        public Movement(decimal importo, DateTime dataMov)
        {
            Importo = importo;
            DataDelMovimento = dataMov;
        }

        public override string ToString()
        {
            return $"Importo {Importo}, Data del movimento {DataDelMovimento}";
        }

        public virtual void Statement()
        {
            Console.WriteLine(this);
        }


    }
}