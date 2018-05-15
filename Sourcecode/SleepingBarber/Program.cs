using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SleepingBarber
{
    class Program
    {
        static void Main(string[] args)
        {
            BarberShop bs = new BarberShop(2);
            bs.Arrive(new Costumer("C0"));
            Thread.Sleep(1200);
            bs.Arrive(new Costumer("C1"));
            Thread.Sleep(10000);
            bs.Arrive(new Costumer("C2"));
            Thread.Sleep(105);
            bs.Arrive(new Costumer("C3"));
            Thread.Sleep(1000);
            bs.Arrive(new Costumer("C4"));
            bs.Arrive(new Costumer("C5"));
        }
    }
}
