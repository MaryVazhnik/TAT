using System;
using System.Text;

namespace DEV_1
{
    /// <summary>
    /// This class contains a method that works with a string
    /// </summary>
    class RepeatSequence
    {
        /// <summary>
        /// Enter point. Args is message in command line
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = args[0];
            int maxcount = 0;
            int count = 1;
            for (int n = 0; n < str.Length - 1; n++)
            {
                if (str[n] == str[n + 1])
                {
                    count++;
                }
                else if (count > maxcount)
                {
                    maxcount = count;
                    count = 1;
                }    
            }
            if (count > maxcount)
                maxcount = count;
            Console.WriteLine("Amount: " + maxcount);
            Console.ReadLine();
        }
    }
}