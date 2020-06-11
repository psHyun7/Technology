using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class SmartPhone : Computer
    {
        public bool IsCellular;

        public SmartPhone(string operatingSystem, bool hasUserInputOutput, double storage, bool isCellular) : base(operatingSystem, hasUserInputOutput, storage)
        {
            IsCellular = isCellular;
        }

        public void AirPlaneMode()
        {
            IsCellular = !IsCellular;
        }
    }
}
