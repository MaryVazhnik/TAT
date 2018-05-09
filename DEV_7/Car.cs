using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    public enum Body { Coupe, Sedan, Minivan, Wagon };
    public enum Cabin { Leather, Fabric, Combined };
    public enum Engine { Gasoline, Diesel, Electric };
    public enum ClimateManagment { ClimateControle, Conditioner, Null }
    public enum Transmission { Automatic, Manual }
    class Car
    {
        public Body body { get; set; }
        public Cabin cabin { get; set; }
        public Engine engine { get; set; }
        public ClimateManagment climateManagement { get; set; }
        public Transmission transmission { get; set; }
        public String brand { get; set; }
        public String model { get; set; }
        public double capacity { get; set; }
        public int power { get; set; }
        public Car() { }
        public Car(Body body, Cabin cabin, Engine engine, ClimateManagment climateManagement, 
            Transmission transmission, String brand, String model, double capacity, int power)
        {
            this.body = body;
            this.cabin = cabin;
            this.engine = engine;
            this.climateManagement = climateManagement;
            this.transmission = transmission;
            this.brand = brand;
            this.model = model;
            this.capacity = capacity;
            this.power = power;
        }
        public override String ToString()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(this.brand + " " + this.model + " " + this.body + 
                " " + this.transmission + " " + this.engine + " " + this.capacity + 
                " " + this.power + " " + this.climateManagement + " " + this.cabin);
            Console.Write("--------------------------------------------------------------------------");
                return "";
        }
    }
}