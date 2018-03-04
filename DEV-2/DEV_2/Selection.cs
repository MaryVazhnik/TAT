using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    ///Class for deleting all odd symbols 
    /// </summary>
    class Selection
    {
        /// <summary>
        /// Entry Point.
        /// </summary>
        static void Main(string[] args)
        {
           StringBuilder sb = new StringBuilder();
           Console.WriteLine("Write line");
           sb.Append(Console.ReadLine());
           for (int i = 0; i < sb.Length; i++)
           {
              sb = sb.Remove(i, 1);
           }
           Console.WriteLine("Symbols with even indices: "+sb);
        }
    }
}