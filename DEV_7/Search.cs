using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    public class Search
    {
        public static void switchCase()
        {
            Console.WriteLine("Which part of your future car you want enter: ");
            Console.WriteLine("1: Body | (Coupe, Sedan, Minivan, Wagon)");
            Console.WriteLine("2: Cabin | (Leather, Fabric, Combined)");
            Console.WriteLine("3: Engine | (Gasoline, Diesel, Electric)");
            Console.WriteLine("4: ClimateManagment | (ClimateControle, Conditioner, Null)");
            Console.WriteLine("5: Transmission | (Automatic, Manual)");
            Console.WriteLine("6: Brand");
            Console.WriteLine("7: Model");
            Console.WriteLine("8: Capacity");
            Console.WriteLine("9: Power");
            Console.WriteLine("10: All cars");
            Console.WriteLine("11: Purchase of car");
            String part = Console.ReadLine();
            Console.Write("Enter variable: ");
            switch (part)
            {
                case "1": CreateCriteria.checkBody(Console.ReadLine());
                    break;
                case "2": CreateCriteria.checkCabin(Console.ReadLine());
                    break;
                case "3": CreateCriteria.checkEngine(Console.ReadLine());
                    break;
                case "4": CreateCriteria.checkClimateManagment(Console.ReadLine());
                    break;
                case "5": CreateCriteria.checkTransmission(Console.ReadLine());
                    break;
                case "6": CreateCriteria.checkBrand(Console.ReadLine());
                    break;
                case "7": CreateCriteria.checkModel(Console.ReadLine());
                    break;
                case "8": CreateCriteria.checkCapacity(Console.ReadLine());
                    break;
                case "9": CreateCriteria.checkPower(Console.ReadLine());
                    break;
                case "10": CreateCriteria.checkNull();
                    break;
                case "11": CreateCriteria.toJson();
                    break;
                default: Console.WriteLine("Error! Try again");
                    switchCase();
                    break;
            }
        }
    }
}