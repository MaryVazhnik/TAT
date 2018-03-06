using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DEV_3
{
        public class CalculationMethod
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            /// <summary>
            /// Translates from the decimal number system to the number system with the base of number system
            /// </summary>
            /// <param name="number">The number that we convert</param>
            /// <param name="sys">Number system, into which we convert</param>
            /// <returns></returns>
            public string ToNumberSystem(string number, string sys)
            {
                string newNum = String.Empty;
                int num = Convert.ToInt32(number);
                int chast = Convert.ToInt32(number);
                ArrayList numTemp = new ArrayList();
                while (chast > 0)
                {
                    chast = chast / Convert.ToInt32(sys);
                    numTemp.Add(num - chast * Convert.ToInt32(sys));
                    num = chast;
                }
                int j;
                for (j = numTemp.Count - 1; j >= 0; j--)
                    newNum += newCh(numTemp[j].ToString(), "to");
                Console.WriteLine(newNum);
                return newNum;
            }
            /// <summary>
            /// Function, replaces letters with numbers and vice versa
            /// </summary>
            /// <param name="worknumber">Number to work over</param>
            /// <param name="otk">In which direction is the action performed with respect to the decimal number system</param>
            /// <returns>Returns a letter if the number matches a letter and vice versa, otherwise the number</returns>
            string newCh(string worknumber, string partytoactionplace)
            {
                string line = String.Empty;
                if (partytoactionplace == "to")
                {
                    if (Convert.ToInt32(worknumber) > 10)
                    {
                        line += letters.Substring(Convert.ToInt32(worknumber) - 10, 1);
                    }
                    else
                    {
                        line += worknumber;
                    }
                }
                else if (partytoactionplace == "from")
                {
                    if (letters.IndexOf(worknumber) == -1)
                    {
                        line += worknumber;
                    }
                    else
                    {
                        line += (letters.IndexOf(worknumber) + 10).ToString();
                    }
                }
                return line;
            }
        }
    }