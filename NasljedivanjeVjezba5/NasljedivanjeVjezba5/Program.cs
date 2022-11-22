using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeVjezba5
{

    class Brojevi
    {
        double broj;

        public double Broj
        {
            get => this.broj; set => this.broj = value; 
        }
        public virtual double ApsVrijednost(double broj)
        {
            return 0;
        }
        public Brojevi()
        {
            
        }
    }
    class Cijeli : Brojevi
    {
        public override double ApsVrijednost(double broj)
        {
            return (Math.Abs(broj));
        }
    }

    class Decimalni : Brojevi
    {
        public override double ApsVrijednost(double broj)
        {
            return (Math.Abs(broj));
        }
    }

    class Pozitivni : Cijeli
    {
        //ovdje nisam overrideao metodu ApsVrijednost jer ju klasa pozitivni naslijeduje vec overrideanu od klase Cijeli
    }

    class Negativni : Cijeli
    {
        //ovdje nisam overrideao metodu ApsVrijednost jer ju klasa negativni naslijeduje vec overrideanu od klase Cijeli
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            Console.WriteLine("Apsolutna vrijednost x: " + x.ApsVrijednost(100));
            Negativni y = new Negativni();
            Console.WriteLine("Apsolutna vrijednost y: " + y.ApsVrijednost(-100));
            Decimalni z = new Decimalni();
            Console.WriteLine("Apsolutna vrijednost z: " + z.ApsVrijednost(100.45));

            Console.ReadKey();
        }
    }
}
