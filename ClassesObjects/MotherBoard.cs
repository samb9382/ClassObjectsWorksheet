using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class MotherBoard
    {
        //member variables
        string manufacturer;
        CPU processor;
        RAM temporaryMemory;
        HardDrive storage;
        GPU graphics;

        //constructor
        public MotherBoard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
            this.manufacturer = manufacturer;
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;
        }
    }
}
