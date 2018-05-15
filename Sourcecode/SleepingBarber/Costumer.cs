using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingBarber
{
    class Costumer
    {
        private string name;
        public string Name
        {
            get { return this.name; }
        }

        public Costumer(string name)
        {
            this.name = name;
        }
    }

}
