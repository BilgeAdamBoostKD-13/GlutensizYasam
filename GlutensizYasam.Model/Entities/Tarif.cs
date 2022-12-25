using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class Tarif : BaseEntity
    {
        public Tarif()
        {
            Besinler = new HashSet<Besin>();
        }
        public string TarifAdi { get; set; }
        public string TarifIcerigi { get; set; }
        public bool AktifMi { get; set; }

        public virtual ICollection<Besin> Besinler { get; set; }
    }
}
