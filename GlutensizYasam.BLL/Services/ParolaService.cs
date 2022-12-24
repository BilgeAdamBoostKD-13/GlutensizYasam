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
        void CheckParolaId(int ParolaID)
        {
            if (ParolaID <= 0) throw new Exception("Parametre değeri uygun değil");
        }

        
        public bool Insert(Parola parola)
        {
            //parola.OlusturulmaTarihi = DateTime.Now;
            return parolaRepository.Insert(parola);
        }

        public bool Update(Parola parola)
        {
            return parolaRepository.Update(parola);
        }
    }
}
