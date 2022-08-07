using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Animal
    {
        public string Name { get; set; }

        public string Communicates { get; set; }

        public double Eating(string food)
        {
            return 54.0d;
        }
       
    }

    class dog : Animal
    {

    }

    internal class SimpleInterest
    {
        public double principal;
        public double rate { get; set; } = 5.0d;
        public int time;

        public double SI()
        {
            return principal * rate * time / 100;
        }
        public double Compound(CompoundInterestObj ciObj)
        {
            var amount = ciObj.Prin * ciObj.Rate / 100;
        }
    }

    class CompoundInterestObj
    {
        public decimal Prin { get; set; } 
        public decimal Rate { get; set; }
        public double Inflation { get; set; }

        public int Time { get; set; } 
    }
}
