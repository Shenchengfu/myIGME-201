using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public CupOfCoffee(string brand) : base(brand)
        {

        }

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

    }
}
