using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SleepingBarber
{
    class Barber
    {
        private string name;
        public string Name
        {
            get { return this.name;  }
        }

        private bool isSleeping;
        public bool IsSleeping
        {
            get
            {
                return isSleeping;
            }
        }

        private BarberShop barberShop;
        private Thread barberThread;

        public Barber(string name, BarberShop barberShop)
        {
            this.name = name;
            this.isSleeping = true;
            this.barberShop = barberShop;
            this.barberThread = new Thread(baberThreadAction);
            this.barberThread.Start();
        }

        public void baberThreadAction()
        {
            while (true)
            {
                while (!isSleeping)
                {
                    if (barberShop.WaitingRoom.Count() > 0)
                    {
                        Costumer c = barberShop.WaitingRoom[0];
                        barberShop.WaitingRoom.RemoveAt(0);
                        Console.WriteLine($"Barber {this.name} is cutting {c.Name}'s hair!");
                        Thread.Sleep(5000);
                        Console.WriteLine($"{c.Name} had the hair cut!");
                    }
                    else
                    {
                        Sleep();
                    }
                }
            }
        }

        public void Sleep()
        {
            this.isSleeping = true;
            Console.WriteLine($"Barber {this.name} went to sleep! zZzzzzzZzZ");
        }

        public void WakeUp()
        {
            this.isSleeping = false;
            Console.WriteLine($"Barber {this.name} is waked up! (O.O)");
        }
    }
}
