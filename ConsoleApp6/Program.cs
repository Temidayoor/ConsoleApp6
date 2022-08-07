using System;

namespace Access_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car honda = new car();
            honda.color = "red";
            honda.make = "atauu";
            honda.Isdriver = true;
            honda.Isfuel = true;
            honda.IscarKey = true;
            honda.Ispolicepresent = true;
            Console.WriteLine(honda.Carstart());
            Console.WriteLine(honda.Arrest());


        }
    }
}


namespace Access_Modifier
{
    public class car
    {
        public string color { get; set; }
        public string Model { get; set; }
        public string make { get; set; }
        public bool Isautomatic { get; set; }
        public bool IscarKey { get; set; }
        public bool Isdriver { get; set; }

        public bool Isfuel { get; set; }

        public bool Ispolicepresent { get; set; }



        public string Carstart()
        {
            if (Isdriver && IscarKey && Isfuel)
            {
                return "Welcome let us start the car";
            }
            else
            {
                return "Sorry we cannot start the car";
            }
        }

        public string Arrest()
        {
            if (Ispolicepresent && color == "Red")
            {
                Console.WriteLine ("Carry On");
            }
            else
            {
                Console.WriteLine("Oga, Stop and Park there");
            }
        }

    }
}