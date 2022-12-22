using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
