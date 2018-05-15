using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingBarber
{
    class BarberShop
    {
        public List<Costumer> WaitingRoom = new List<Costumer>();
        private int waitingRoomSize = 0;
        private Barber barber;

        public BarberShop(int waitingRoomChairs)
        {
            waitingRoomSize = waitingRoomChairs;
            barber = new Barber("Chico", this);
        }

        public void Arrive(Costumer c)
        {
            Console.WriteLine($"Costumer {c.Name} has arrived!");

            if (WaitingRoom.Count() < waitingRoomSize)
            {
                WaitingRoom.Add(c);
                if (barber.IsSleeping)
                {
                    Console.WriteLine($"Waking up the barber...");
                    barber.WakeUp();
                }
                else
                {
                    Console.WriteLine($"Barber is buzzy. {c.Name} it's waiting on {WaitingRoom.Count} chair.");
                }
            }
            else
            {
                Console.WriteLine($"The BarberShop is full! {c.Name} left! :(");
            }
        }
    }
}
