using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    public class Action
    {
        List<Goods> list = new List<Goods>();
        public void SetInfo()
        {
            String word;
            Boolean flag = true;
            while(flag)
            {
                Goods goods = new Goods();
                Console.WriteLine("Enter a type");
                goods.type = Console.ReadLine();
                if (goods.type == String.Empty)
                {
                    Console.WriteLine("Error, empty string. Try again");
                    Console.WriteLine("Enter a type");
                    goods.type = Console.ReadLine();
                }
                Console.WriteLine("Enter a name");
                goods.name = Console.ReadLine();
                if (goods.name == String.Empty)
                {
                    Console.WriteLine("Error, empty string. Try again");
                    Console.WriteLine("Enter a name");
                    goods.name = Console.ReadLine();
                }
                Console.WriteLine("Enter a quantity");
                goods.quantity = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter a cost per unit in $");
                goods.costPerUnit = Double.Parse(Console.ReadLine());
                Console.WriteLine("Continue? yes/no");
                list.Add(goods);
                word = Console.ReadLine();
                switch (word)
                {
                    case "yes": continue;
                    case "no": ListArray();
                        flag = false;
                        break;
                    default: break;
                }
            }
        }
        public void ListArray()
        {
            foreach(Goods goods in list)
            {
                Console.WriteLine(goods.type + "-" + goods.name + "-" + goods.quantity + "-" + goods.costPerUnit);
            }
        }
        public void EnterCommand()
        {
            Console.WriteLine("Enter a command: | count types | count all | average price | average price [type] | exit |");
            String commandString = Console.ReadLine();
            if (commandString == String.Empty)
            {
                Console.WriteLine("Error, you did not enter the command. Try again");
                EnterCommand();
            }
            String[] command = commandString.Split(' ');
            Console.Write(commandString + ": ");
            if (command.Length == 3 && command[0].Equals("average") && command[1].Equals("price"))
            {
                    Console.WriteLine(getAverageByType(command[2]));
            }
            switch (commandString)
            {
                case "count types": Console.WriteLine(getCountOfType());
                    break;
                case "count all": Console.WriteLine(getAmountGoods());
                    break;
                case "average price": Console.WriteLine(getAveragePrice());
                    break;
                case "exit": Environment.Exit(1);
                    break;
                default: Console.WriteLine("Unknown command, try again");
                    break;
            }
            EnterCommand();
        }
        /// <summary>
        /// For calculating all the different types
        /// </summary>
        /// <returns></returns>
        public int getCountOfType()
        {
            List<String> typeNameList = new List<String>();

            foreach (Goods goods in list)
            {
                typeNameList.Add(goods.type);
            }
            return typeNameList.Distinct().Count();
        }
        /// <summary>
        /// Count the number of all products
        /// </summary>
        /// <returns></returns>
        public int getAmountGoods()
        {
            int amount = 0;
            foreach(Goods goods in list)
            {
                amount += goods.quantity;
            }
            return amount;
        }
        /// <summary>
        /// Calculates the average cost of goods
        /// </summary>
        /// <returns></returns>
        public double getAveragePrice()
        {
            double sumCost = 0;
            foreach(Goods goods in list) 
            {
                sumCost += goods.costPerUnit;
            }
            return sumCost / list.Count;
        }
        /// <summary>
        /// Calculates the average cost of goods by types
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double getAverageByType(String type)
        {
            double average = 0;
            int count = 0;
            double sum = 0;
            foreach(Goods goods in list) 
            {
                if (type.Equals(goods.type))
                {
                    count++;
                    sum += goods.costPerUnit;
                }
            }
            average = sum / count;
            return average;
        }
    }
}