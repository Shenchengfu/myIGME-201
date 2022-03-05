using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public string brand;
        public Customer customer;

        public HotDrink()
        {
            this.instant = false;
            this.milk = false;
            this.sugar = 0;
            this.size = "";
            this.brand = "";
            this.customer = new Customer();
        }

        public HotDrink(string brand)
        {
            this.brand = brand;
            this.customer = new Customer();
        }

        public virtual void AddSugar(byte amount)
        {
            sugar += amount;

        }

        public abstract void Steam();

    }
}
