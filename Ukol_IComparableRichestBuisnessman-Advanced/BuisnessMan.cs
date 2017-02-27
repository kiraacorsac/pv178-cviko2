using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_IComparableRichestBuisnessman_Advanced
{
    class BuisnessMan /*implementuje IComparable so samým sebou*/
    {
        public string Name { get; set; }
        public decimal ValueOfCar { get; set; }
        public decimal ValueOfHouse { get; set; }
        public decimal ValueOfBuisness { get; set; }

    }
}
