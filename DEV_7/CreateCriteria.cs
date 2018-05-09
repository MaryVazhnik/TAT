using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace DEV_7
{
    public class CreateCriteria
    {
        private static List<Car> list;
        public static void getList()
        {
            list = ParseJson.serialize();
        }
        private static List<Car> tempList;
        public static void checkBody(String str)
        {
            byte i = 0;
            tempList = new List<Car>();
            foreach (Body body in Enum.GetValues(typeof(Body)))
            {
                i++;
                if (body.ToString().Equals(str))
                {
                    foreach (Car car in list)
                    {
                        if (car.body.Equals(body))
                        {
                            tempList.Add(car);
                            Console.WriteLine(car.ToString());
                        }
                    }
                    list = tempList;
                    break;
                }
                else if (Enum.GetValues(typeof(Body)).Length > i)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            Search.switchCase();
        }
        public static void checkCabin(String str)
        {
            byte i = 0;
            tempList = new List<Car>();
            foreach (Cabin cabin in Enum.GetValues(typeof(Cabin)))
            {
                i++;
                if (cabin.ToString().Equals(str))
                {
                    foreach (Car car in list)
                    {
                        if (car.cabin.Equals(cabin))
                        {
                            tempList.Add(car);
                            Console.WriteLine(car.ToString());
                        }
                    }
                    list = tempList;
                    break;
                }
                else if (Enum.GetValues(typeof(Cabin)).Length > i)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            Search.switchCase();
        }
        public static void checkTransmission(String str)
        {
            byte i = 0;
            tempList = new List<Car>();
            foreach (Transmission transmission in Enum.GetValues(typeof(Transmission)))
            {
                i++;
                if (Transmission.Automatic.ToString().Equals(str))
                {
                    foreach (Car car in list)
                    {
                        if (car.transmission.Equals(Transmission.Automatic) && car.cabin.Equals(Cabin.Leather))
                        {
                            tempList.Add(car);
                            Console.WriteLine(car.ToString());
                        }
                    }
                    list = tempList;
                    Search.switchCase();
                    break;
                }
                else if (transmission.ToString().Equals(str))
                {
                    foreach (Car car in list)
                    {
                        if (car.transmission.Equals(transmission))
                        {
                            tempList.Add(car);
                            Console.WriteLine(car.ToString());
                        }
                    }
                    list = tempList;
                    Search.switchCase();
                    break;
                }
                else if (Enum.GetValues(typeof(Transmission)).Length > i)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
                Search.switchCase();
            }
        }
        public static void checkEngine(String str)
        {
            byte i = 0;
            tempList = new List<Car>();
            foreach (Engine engine in Enum.GetValues(typeof(Engine)))
            {
                i++;
                if (engine.ToString().Equals(str))
                {
                    foreach (Car car in list)
                    {
                        if (car.engine.Equals(engine))
                        {
                            tempList.Add(car);
                            Console.WriteLine(car.ToString());
                        }
                    }
                    list = tempList;
                    break;
                }
                else if (Enum.GetValues(typeof(Engine)).Length > i)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            Search.switchCase();
        }
        public static void checkClimateManagment(String str)
        {
            byte i = 0;
            tempList = new List<Car>();
            foreach (ClimateManagment climateManagement in Enum.GetValues(typeof(Engine)))
            {
                i++;
                if (climateManagement.ToString().Equals(str))
                {
                    foreach (Car car in list)
                    {
                        if (car.climateManagement.Equals(climateManagement))
                        {
                            tempList.Add(car);
                            Console.WriteLine(car.ToString());
                        }
                    }
                    list = tempList;
                    break;
                }
                else if (Enum.GetValues(typeof(ClimateManagment)).Length > i)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            Search.switchCase();
        }
        public static void checkBrand(String str)
        {
            tempList = new List<Car>();
            foreach (Car car in list)
            {
                if (car.brand.Equals(str))
                {
                    tempList.Add(car);
                    Console.WriteLine(car.ToString());
                }
                else if (!list.IndexOf(car).Equals(list.Count - 1))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            list = tempList;
            Search.switchCase();
        }
        public static void checkModel(String str)
        {
            tempList = new List<Car>();
            foreach (Car car in list)
            {
                if (car.model.Equals(str))
                {
                    tempList.Add(car);
                    Console.WriteLine(car.ToString());
                }
                else if (!list.IndexOf(car).Equals(list.Count - 1))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            list = tempList;
            Search.switchCase();
        }
        public static void checkCapacity(String str)
        {
            double number;
            tempList = new List<Car>();
            foreach (Car car in list)
            {
                number = Double.Parse(str);
                if (car.capacity.Equals(number))
                {
                    tempList.Add(car);
                    Console.WriteLine(car.ToString());
                }
                else if (!list.IndexOf(car).Equals(list.Count - 1))
                {
                   continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            list = tempList;
            Search.switchCase();
        }
        public static void checkPower(String str)
        {
            int number;
            tempList = new List<Car>();
            foreach (Car car in list)
            {
                number = Int32.Parse(str);
                if (car.power.Equals(number))
                {
                    tempList.Add(car);
                    Console.WriteLine(car.ToString());
                }
                else if (!list.IndexOf(car).Equals(list.Count - 1))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have such models");
                    tempList = list;
                }
            }
            list = tempList;
            Search.switchCase();
        }
        public static void checkNull()
        {
            tempList = new List<Car>();
            foreach (Car car in list)
            {
                Console.WriteLine(car.ToString());
            }
            Search.switchCase();
        }
        public static void toJson()
        {
            String JsonString = JsonConvert.SerializeObject(list);
            System.IO.File.WriteAllText(@"manufacture.json", JsonString);
        }
    }
}