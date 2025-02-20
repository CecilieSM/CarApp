using System;
using System.Reflection;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string brand = "Toyota";
            string model = "Corolla";
            int Year = 2020;
            char geartype = 'A';

            Console.WriteLine("Bilmærke: " + brand);
            Console.WriteLine("Bilmodel: " + model);
            Console.WriteLine("Årgang: " + Year);
            Console.WriteLine("Gear: " + geartype);


            /*Console.WriteLine("Indtast bilmærke");
                String brand2= Console.ReadLine();
            Console.WriteLine("Indtast model");
            string model2 = Console.ReadLine();
            Console.WriteLine("Indtast årgang");
            int year2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast GearType (Brug A eller M)");
            char GearType2= char.Parse(Console.ReadLine());

            /*Console.WriteLine();
            Console.WriteLine("Bilmærke: " + brand2);
            Console.WriteLine("Bilmodel: " + model2);
            Console.WriteLine("Årgang; " + year2);
            Console.WriteLine("Gear: " + GearType2);*/

            //Console.WriteLine(brand2 +" "+ model2 + " " + "fra" + " " + year2 + " " + "har" + " " + "Gear" + " " + GearType2);

            Console.WriteLine("Indtast brændstoftype");
            string fuelType = Console.ReadLine();
            Console.WriteLine("Indtast kilometerstand");
            double odoValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast brændstofpris");
            double fuelPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast brændstofforbrug");
            double fuelNeed = double.Parse(Console.ReadLine());
            Console.Write("Brændstofforbrug" + " " + "=" + " " + fuelNeed+ " " + "Km/l" + "\n");

            double tripCost = fuelPrice * fuelNeed;

            Console.WriteLine("Turpris = " + " " + tripCost +" "+ "kr");

            Console.WriteLine("Ny kilometerstand: " + (odoValue + fuelNeed).ToString("#") + "km" + "\n");

            string s = String.Format("Brændstofudgifterne for " + odoValue + "km er " + tripCost.ToString("#.00") + "DKK" + "\n");
            Console.WriteLine(s);

            Console.WriteLine("Bilmærke".PadRight(15) + "| Model".PadRight(15) + "| Kilometertal" + "\n");
            Console.WriteLine("-----------------------------------------------" + "\n");
            Console.WriteLine(brand.PadRight(15) + "| " + model.PadRight(13) + "| " + (fuelNeed + odoValue).ToString("#"));




            Console.ReadKey();
        }

    }
}
