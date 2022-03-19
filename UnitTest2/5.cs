namespace Practice
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

        public static bool operator ==(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.WhichDrWho == t2.WhichDrWho)
                status = true;
            return status;
        }
        public static bool operator !=(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.WhichDrWho != t2.WhichDrWho)
                    status = true;
            return status;
        }
        public static bool operator <(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.WhichDrWho < t2.WhichDrWho || t2.WhichDrWho == 10)
                status = true;
            return status;
        }
        public static bool operator >(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.WhichDrWho > t2.WhichDrWho || t1.WhichDrWho == 10)
                status = true;
            return status;
        }

        public static bool operator <=(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.WhichDrWho <= t2.WhichDrWho || t2.WhichDrWho == 10)
                status = true;
            return status;
        }
        public static bool operator >=(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.WhichDrWho >= t2.WhichDrWho || t1.WhichDrWho == 10))
                status = true;
            return status;
        }

    }
}
