using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace DEV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCriteria.getList();
            Search.switchCase();
        }
    }
}