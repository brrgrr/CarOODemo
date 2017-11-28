using System;

namespace CarOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: create different cars and drive them
            //Car car = new Car("Ford", "Prefect");
            GasCar explorer = new GasCar("Ford", "Explorer", 20, 15 );
            ElectricCar leaf = new ElectricCar("Nissan", "Leaf", 75, 3);
            //Console.WriteLine(explorer.Make);
            //Console.ReadKey();

            explorer.Drive(75);
            explorer.Drive(50);
            leaf.Drive(200);
            leaf.Drive(200);

           
        }
    }
}
