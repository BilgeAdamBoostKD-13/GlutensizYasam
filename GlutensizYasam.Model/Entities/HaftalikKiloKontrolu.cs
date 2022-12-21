using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class HaftalikKiloKontrolu : BaseEntity
    {
        public DateTime KontrolTarihi { get; set; }
        public int AnlikKilo { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
