using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._2._1
{
    abstract class Lot
    {
        public int Price { get; protected set; }
        public DateTime ExpireDate { get; protected set; } = DateTime.Today.AddDays(7);
        public string Description { get; protected set; } = "Standart shipping";
    }
}
