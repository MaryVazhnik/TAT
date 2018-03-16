using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    ///Class creates a new string from the previous
    /// </summary>
    class SequenceBuilder
    {
        /// <summary>
        /// Entry Point.
        /// </summary>
        static void Main(string[] args)
        {
           Console.WriteLine("Write a string");
           String s = Console.ReadLine(); 
           StringBuilder sb = new StringBuilder();
           for (int i = 0; i < s.Length; i+=2)
           {
              sb.Append(s[i]);
           }
           Console.WriteLine("Symbols with even indices: "+sb);
        }
    }
}