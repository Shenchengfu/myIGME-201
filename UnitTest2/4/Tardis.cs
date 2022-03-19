using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tardis
{
    public class Tardis
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get
            {
                return whichDrWho;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }
        }

        public void TimeTravel() { }
}
}
