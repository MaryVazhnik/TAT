using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    class ParseJson
    {
        public static List<Car> list = new List<Car>();
        public static List<Car> serialize()
        {
            JsonSerializer serializer = new JsonSerializer();
            FileStream s = File.Open("cars.json", FileMode.Open);
            StreamReader sr = new StreamReader(s);
            JsonReader reader = new JsonTextReader(sr);
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.StartObject)
                {
                    list.Add(serializer.Deserialize<Car>(reader));
                }
            }
            return list;
        }
    }
}