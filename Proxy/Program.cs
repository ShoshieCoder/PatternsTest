using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCar car = new RealCar();
            GetProxy(new CarProxy());
        }

        static void GetProxy(ICarServices proxy)
        {
            Console.WriteLine(proxy.ShowFuel());
            Console.WriteLine(proxy.ShowLocation());
        }
    }
}
