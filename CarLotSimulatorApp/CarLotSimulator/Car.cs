using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            carLot.numberOfCars++;
        }

        public Car(int year, 
                    string make, 
                    string model, 
                    string engineNoise, 
                    string honkNoise, 
                    bool isDrivable)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.engineNoise = engineNoise;
            this.honkNoise = honkNoise;
            this.isDrivable = isDrivable;
        }

        public int year {  get; set; }
        public string make {  get; set; }
        public string model {  get; set; }
        public string engineNoise {  get; set; }
        public string honkNoise {  get; set; }
        public bool isDrivable {  get; set; }

        public void MakeEngineNoise (string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void makeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
}
