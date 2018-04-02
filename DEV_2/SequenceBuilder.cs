using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    ///Class creates a new string from the previous
    /// </summary>
    public class SequenceBuilder
    {
        /// <summary>
        /// Entry Point.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Write a string");
            String s = Console.ReadLine();
            SequenceBuilder sq = new SequenceBuilder();
            Console.WriteLine("Symbols with even indices: " + sq.CheckEven(s));
        }
        public string CheckEven(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                Console.WriteLine("You have null or empty string");
                return null;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i += 2)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}