using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double discountPercentage = 0.1;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() -base.CalculatePrice()* discountPercentage;
        }
        public override String Description
        {
            get
            {
                return "now at " +discountPercentage + "% off";
            }

        }
    }
}
