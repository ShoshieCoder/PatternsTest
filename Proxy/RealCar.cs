using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealCar : ICar, ICarServices
    {
        protected int fuel = 100;
        protected string location = "this location";

        public void Decrease()
        {
            Console.WriteLine("Decreasing speed...");
        }

        public void Increase()
        {
            Console.WriteLine("Increasing speed...");
        }

        public void Left()
        {
            Console.WriteLine("Turning Left");
        }

        public void Right()
        {
            Console.WriteLine("Turning Right");
        }

        public void StartDriving()
        {
            Console.WriteLine("Driving...");
        }

        public void StopDriving()
        {
            Console.WriteLine("Stopping...");
        }

        public int ShowFuel()
        {
            return this.fuel;
        }

        public string ShowLocation()
        {
            return this.location;
        }
    }
}
