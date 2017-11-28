using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public class GasCar : Car
    {
        public int GasTankSize { get; private set; }
        public double GasTankLevel { get; private set; }
        public double MilesPerGallon { get; private set; }

        public GasCar(string make, string model, int gasTankSize, double milesPerGallon) : base(make, model)
        {
            this.GasTankSize = gasTankSize;
            this.GasTankLevel = gasTankSize;
            this.MilesPerGallon = milesPerGallon;
        }

        public override void Drive(int miles)
        {
            // adjust fuel based on MPG
            // write out distance traveled and fuel remaining
            double maxDistance = this.MilesPerGallon * this.GasTankLevel;
            double distanceTraveled = miles;
            if (miles > maxDistance)
            {
                distanceTraveled = maxDistance;
            }
            double gallonsUsed = distanceTraveled / this.MilesPerGallon;
            this.GasTankLevel -= gallonsUsed;
            var text = String.Format("Traveled {0} Miles, Used {1} Gallons, {2} Gallons Remaining ", distanceTraveled, gallonsUsed, this.GasTankLevel);
            Console.WriteLine(text);
    }
    }
}
