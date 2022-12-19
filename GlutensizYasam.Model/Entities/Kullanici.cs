using GlutensizYasam.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class Kullanici : BaseEntity
    {
        public string EMail { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }        
        public int Kilo { get; set; }
        public int Boy { get; set; }
        public int HedefKilo { get; set; }
        public KullaniciTipi KullaniciTipi { get; set; }
        public SporTipi SporBilgisi { get; set; }

    }
}
