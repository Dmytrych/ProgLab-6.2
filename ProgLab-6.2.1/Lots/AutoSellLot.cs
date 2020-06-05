using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._2._1
{
    class AutoSellLot : Lot
    {
        public AutoSellLot(int price, string description)
        {
            Price = price;
            Description = description;
        }
    }
}
