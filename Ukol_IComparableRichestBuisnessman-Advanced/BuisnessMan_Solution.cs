using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_IComparableRichestBuisnessman_Advanced
{
    //Content
    class BuisnessMan : IComparable<BuisnessMan>
    {
        public string Name { get; set; }
        public decimal ValueOfCar { get; set; }
        public decimal ValueOfHouse { get; set; }
        public decimal ValueOfBuisness { get; set; }

        public int CompareTo(BuisnessMan other)
        {
            decimal thisValue = ValueOfCar + ValueOfHouse + ValueOfBuisness;
            decimal otherValue = other.ValueOfCar + other.ValueOfHouse + other.ValueOfBuisness;
            return thisValue.CompareTo(otherValue);
        }

    }
}
