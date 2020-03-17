using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CarProxy : ICarServices
    {
        public CarProxy()
        {

        }
        public int ShowFuel()
        {
            ICarServices car = new RealCar();
            return car.ShowFuel();
        }

        public string ShowLocation()
        {
            ICarServices car = new RealCar();
            return car.ShowLocation();
        }
    }
}
