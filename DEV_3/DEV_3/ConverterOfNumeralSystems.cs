using System;
using System.Text;

namespace DEV_3
{
    class ConverterOfNumeralSystems
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Number " + args[0] + " in " + args[1] + " number system:");
            CalculationMethod prog = new CalculationMethod();
            int check = Int32.Parse(args[1]);
            int args2 = Int32.Parse(args[0]);
            if (check <= 20 && check >= 2 && args2 > 0)
            {
                prog.ToNumberSystem(args[0], args[1]);
            }
            else
            {
                Console.WriteLine("Error! Change the data, please");
            }
        }
    }
}
