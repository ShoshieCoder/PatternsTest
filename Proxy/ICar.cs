using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ICar
    {
        void StartDriving();
        void StopDriving();
        void Increase();
        void Decrease();
        void Left();
        void Right();
    }
}
