using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var listOfCars = new CarLot();

            var shinyCar = new Car();
            shinyCar.Year = 2022;
            shinyCar.Make = "Toyota";
            shinyCar.Model = "Prius";
            shinyCar.EngineNoise = "mmmmmm";
            shinyCar.HonkNoise = "meep.";
            shinyCar.IsDriveable = true;

            listOfCars.CarList.Add(shinyCar);
            Console.WriteLine($"{CarLot.numberOfCars} cars currently in the car lot.");

            var junkCar = new Car()
            {
                Year = 2003,
                Make = "Chevrolet",
                Model = "Impala",
                EngineNoise = "BLUHBLUHBLUHBLUHBLUH",
                HonkNoise = "Honnnnnk!",
                IsDriveable = true,
            };

            listOfCars.CarList.Add(junkCar);
            Console.WriteLine($"{CarLot.numberOfCars} cars currently in the car lot.");

            var brokenCar = new Car(1982, "Ford", "Ranger", "chunk...chunk...chunk...", "*silence*", false);

            listOfCars.CarList.Add(brokenCar);
            Console.WriteLine($"{CarLot.numberOfCars} cars currently in the car lot.");

            shinyCar.MakeEngineNoise(shinyCar.EngineNoise);
            shinyCar.MakeHonkNoise(shinyCar.HonkNoise);

            junkCar.MakeEngineNoise(junkCar.EngineNoise);
            junkCar.MakeHonkNoise(junkCar.HonkNoise);

            brokenCar.MakeEngineNoise(brokenCar.EngineNoise);
            brokenCar.MakeHonkNoise(brokenCar.HonkNoise);

            Console.WriteLine($"-----------------------------------------------------");
            foreach (var car in listOfCars.CarList)
            {
                Console.WriteLine($"Year:{car.Year} | Make:{car.Make} | Model:{car.Model}");
                Console.WriteLine($"-----------------------------------------------------");
            }
        }
    }
}
