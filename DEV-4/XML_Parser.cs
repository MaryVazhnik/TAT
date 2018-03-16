using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DEV_4
{
    class XML_Parser
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">xml file</param>
        static void Main(string[] args)
        {
            string text = String.Empty, name = String.Empty;
            name = args[0];
            text = enter(name);
            parse(text);
        }
        static string enter(string name)
        {
            string text = String.Empty;
            using (StreamReader fs = new StreamReader(name))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null)
                        break;
                    text += temp;
                }
            }
            return text;
        }
        /// <summary>
        /// Parser description
        /// </summary>
        /// <param name="text"></param>
        static void parse(string text)
        {
            while (text.IndexOf("  ") > -1)
            {
                text = text.Replace("  ", " ");
                text = text.Replace(">", ">@");
                text = text.Replace("<", "@<");
                string[] split = text.Split('@');
                string[] elements = new string[0];
                string[] atribut = new string[0];
                string el;
                int ind = 0;
                bool flag = false;
                for (int j = 0; j < split.Length; j++)
                {
                    if (flag)
                    {
                        Console.Write(" - " + split[j - 2]);
                        Console.WriteLine();
                        flag = false;
                    }
                    if (split[j].IndexOf("<") == 0)
                    {
                        if (split[j].IndexOf("/") != 1)
                        {
                            Array.Resize<string>(ref elements, elements.Length + 1);
                            el = split[j].Replace("<", "");
                            el = el.Replace(">", "");
                            elements[elements.Length - 1] = el;
                        }
                        else
                        {
                            el = split[j].Replace("</", "");
                            el = el.Replace(">", "");
                            for (int i = 0; i < elements.Length; i++)
                            {
                                Console.Write(elements[i]);
                                if (elements[i].IndexOf(el) > -1)
                                {
                                    ind = i;
                                    break;
                                }
                                Console.Write(" - ");
                            }
                            flag = true;
                            Array.Resize<string>(ref elements, ind);
                        }
                        el = String.Empty;
                    }
                }
            }
        }
    }
}