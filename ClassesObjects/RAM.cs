using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class RAM
    {
        //member variables
        double totalGigabytes;
        string brand;

        //constructor
        public RAM(string brand, double totalGigabytes)
        {
            this.brand = brand;
            this.totalGigabytes = totalGigabytes;
        }
    }
}
