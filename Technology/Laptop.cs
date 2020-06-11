using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Technology
{
    class Laptop : Computer
    {
        public bool IsPluggedIn { get; set; }

        public Laptop (string operatingSystem, bool hasUserInputOutput, double storage, bool isPluggedIn) : base (operatingSystem, hasUserInputOutput, storage)
        {
            IsPluggedIn = isPluggedIn;
        }

        public void UnPlug()
        {
            IsPluggedIn = false;
        }

        public void PlugIn()
        {
            IsPluggedIn = true;
        }
    }
}
