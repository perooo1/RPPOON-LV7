using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;

        public SystemDataProvider(): base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }

        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;

            if(Math.Abs(1.0 - this.previousCPULoad / currentLoad) > 0.1)
                this.Notify();
            
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }

        public float GetAvailableRAM()
        {
            float currentlyAvailableRAM = this.AvailableRAM;

            if(Math.Abs(1.0 - this.previousRAMAvailable / currentlyAvailableRAM) > 0.1)
                this.Notify();
            
            this.previousRAMAvailable = currentlyAvailableRAM;
            return currentlyAvailableRAM;
        }

    }
}
