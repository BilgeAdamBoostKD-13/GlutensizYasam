using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class Besin : BaseEntity
    {
        public string BesinAdi { get; set; }

        public int Kalori 
        {
            get
            {
                return (4 * Protein + 4 * Karbonhidrat + 9 * Yag);
            }

        }
        public int Protein { get; set; }
        public int Karbonhidrat { get; set; }
        public int Yag { get; set; }

    }
}
