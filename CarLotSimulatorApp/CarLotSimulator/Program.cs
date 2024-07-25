using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the
            //program and as you create a car add the car to the list.
            var lot = new CarLot();
            


            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //(.) dot notation
            var michealsCar = new Car();

            michealsCar.make = "ford";
            michealsCar.model = "focus";
            michealsCar.year = 2013;
            michealsCar.engineNoise = "vroom";
            michealsCar.honkNoise = "beep";
            michealsCar.isDrivable = true;

            lot.Cars.Add( michealsCar );
            
            //Object Initilizer syntax
            var stevesCar = new Car()
            {
                year = 2019,
                make = "tesla",
                model = "Cyber Truck",
                engineNoise = "...",
                honkNoise = "brrmmp",
                isDrivable = false
            };

            lot.Cars.Add( stevesCar );

            //Constructor instantitation syntax
            var brettsCar = new Car(2013, "Honda", "Civic", "vrrroom", "vruggaa", true);

            lot.Cars.Add(brettsCar);

            //call methods
            michealsCar.MakeEngineNoise(michealsCar.engineNoise);
            stevesCar.MakeEngineNoise(stevesCar.engineNoise);
            brettsCar.MakeEngineNoise(brettsCar.engineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($" Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year {car.year} Make: {car.make} Model: {car.model}");
            }
        }
    }
}
