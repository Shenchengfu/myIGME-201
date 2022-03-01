using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    abstract class Donut
    {
        private string description;

        public string DonutDescription
        {
            get
            {
               return description;
            }
            set
            {
                description = value;
            }
        }
    }
}
