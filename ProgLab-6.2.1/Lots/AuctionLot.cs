using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._2._1
{
    class AuctionLot : Lot
    {
        public AuctionLot(int minPrice, DateTime expireDate,string description )
        {
            Price = minPrice;
            ExpireDate = expireDate;
        }
    }
}
