using System;
using System.Text;
using System.Collections;

namespace DEV_3
{
    /// <summary>
    /// Translates from an active number system to another number system
    /// </summary>
         class CalculationMethod
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
                int j = 0;
                for (j = numTemp.Count - 1; j >= 0; j--)
                {
                    newNum += newChast(numTemp[j].ToString(), "to");
                }
                Console.WriteLine(newNum);
                return newNum;
            }
            /// <summary>
            /// Function, replaces letters with numbers and vice versa
            /// </summary>
            /// <param name="convertednumber">Number to work over</param>
            /// <param name="partytoactionplace">In which direction is the action performed with respect to the decimal number system</param>
            /// <returns>Returns a letter if the number matches a letter and vice versa, otherwise the number</returns>
            string newChast(string convertednumber, string partytoactionplace)
            {
                StringBuilder direction = new StringBuilder();
                if (partytoactionplace == "to")
                {
                    if (Convert.ToInt32(convertednumber) >= 10)
                    {
                        letters = letters.Substring(Convert.ToInt32(convertednumber) - 10, 1);
                        direction = direction.Append(letters);
                    }
                    else
                    {
                        direction = direction.Append(convertednumber);
                    }
                }
                else if (partytoactionplace == "from")
                {
                    if (letters.IndexOf(convertednumber) == -1)
                    {
                        direction = direction.Append(convertednumber);
                    }
                    else
                    {
                        letters = (letters.IndexOf(convertednumber) + 10).ToString();
                        direction = direction.Append(letters);
                    }
                }
                return direction.ToString();
            }
        }
    }