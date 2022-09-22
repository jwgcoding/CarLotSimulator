using System;
using System.Runtime;
using System.Xml.Schema;
using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            var lot = new CarLot();


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //var myCar = new Car();
            //myCar.Make = "Merecedes";
            //myCar.Model = "GLC";
            //myCar.Year = 2022;
            //myCar.EngineNoise = "brrr";
            //myCar.IsDriveable = true;
            //myCar.HonkNoise = "hooonnkkk";

            //var samCar = new Car();
            //samCar.Make = "Audi";
            //samCar.Model = "Q4";
            //samCar.Year = 2021;
            //samCar.EngineNoise = "vrooommm";
            //samCar.IsDriveable = true;
            //samCar.HonkNoise = "beeppppp";

            //var danCar = new Car();
            //danCar.Make = "Audi";
            //danCar.Model = "Q5";
            //danCar.Year = 2021;
            //danCar.EngineNoise = "vrvrvroom";
            //danCar.IsDriveable = true;
            //danCar.HonkNoise = "booopppp";
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            

            var myCar = new Car();
            myCar.Make = "Merecedes";
            myCar.Model = "GLC";
            myCar.Year = 2022;
            myCar.EngineNoise = "brrr";
            myCar.IsDriveable = true;
            myCar.HonkNoise = "hooonnkkk";
            lot.Cars.Add(myCar);

            var danCar = new Car() 
            {
                Year = 2021,
                Make = "Audi",
                Model = "Q4",
                EngineNoise = "vrvrrrvrvroommm",
                HonkNoise = "Boop",
                IsDriveable = true,
            };
                lot.Cars.Add(danCar);

            var samCar = new Car(2013, "Audi", "Q5", "brbrbrbrbr", "bep", true);
            lot.Cars.Add(samCar);

            myCar.MakeEngineNoise();
            samCar.MakeEngineNoise();
            danCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            danCar.MakeHonkNoise();
            samCar.MakeHonkNoise();
            
            
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }

        

        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
    }
}
