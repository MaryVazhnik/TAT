using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args) 
          { 
                int length = int.Parse(args[0]); 
                int width = int.Parse(args[1]); 
            try 
            { 
                if (length < 0 && width < 0 ) 
                    { 
                        Console.WriteLine("Negative value."); 
                        return; 
                    } 
                if (length > int.MaxValue && width > int.MaxValue) 
                    { 
                        Console.WriteLine("Much value."); 
                        return; 
                    }
                AreaOfRectangle calc = new AreaOfRectangle(width, length);
                calc.Calculate(width, length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          }
    }
}