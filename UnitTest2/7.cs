using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void UsePhone(object obj)
        {
            ((PhoneInterface) obj).MakeCall();
            if (obj is PhoneBooth)
                ((PhoneBooth) obj).OpenDoor();
            else if(obj is Tardis)
                ((Tardis) obj).TimeTravel();

        }
        static void Main(string[] args)
        {
            Tardis t = new Tardis();
            UsePhone(t);
            PhoneBooth pb = new PhoneBooth();
            UsePhone(pb);
        }
    }
}
