using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property

//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
  public Car(int year, string make, string model, string engineNoise,string honkNoise, bool isDrivable)
       
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;
        }
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }   

        public bool IsDriveable { get; set; }

      
       
        
        public void MakeEngineNoise() 
        {
            Console.WriteLine(EngineNoise);

        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
    

}
