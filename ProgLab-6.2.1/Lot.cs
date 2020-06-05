using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._2._1
{
    class Lot
    {
        public enum LotTypes
        {
            Auction,
            QuickSelling,
            Bidding
        }
        public int MinPrice { get; private set; }
        public DateTime ExpireDate { get; private set; } = DateTime.Today.AddDays(7);
        public string Description { get; private set; } = "Standart shipping";
        public Lot(int minPrice, DateTime expireDate, string description)
        {
            MinPrice = minPrice;
            ExpireDate = expireDate;
            Description = description;
        }
    }
}
