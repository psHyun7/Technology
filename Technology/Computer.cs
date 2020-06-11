using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Computer : AbstractIdentity
    {
        public string OperatingSystem { get; set; }
        public bool HasUserInputOutput { get; set; }
        public double Storage { get; set; }

        public Computer(string operatingSystem, bool hasUserInputOutput, double storage)
        {
            OperatingSystem = operatingSystem;
            HasUserInputOutput = hasUserInputOutput;
            Storage = storage;
        }
        public string Boot()
        {
            return $"{OperatingSystem}";
        }
        public string Calculate()
        {
            return "Calculation Complete...";
        }

    }
}
