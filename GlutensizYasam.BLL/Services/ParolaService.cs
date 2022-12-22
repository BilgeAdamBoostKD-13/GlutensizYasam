using GlutensizYasam.DAL.Repositories;
using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.BLL.Services
{
    public class ParolaService
    {
        ParolaRepository parolaRepository;
        public ParolaService()
        {
            parolaRepository = new ParolaRepository();
        }

        public bool Insert(Parola parola)
        {
            //parola.OlusturulmaTarihi = DateTime.Now;
            return parolaRepository.Insert(parola);
        }
    }
}
