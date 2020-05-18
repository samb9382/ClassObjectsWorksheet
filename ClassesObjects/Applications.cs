using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Applications
    {
        //member variables
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        //constructor
        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging Service";
            RequiredRAM = 4.0; //in gigabytes
            RequiredStorage = 0.512; //in gigabytes
        }
    }
}
