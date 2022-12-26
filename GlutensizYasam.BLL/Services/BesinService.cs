using GlutensizYasam.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.BLL.Services
{
    public class BesinService
    {
        BesinRepository besinRepository;
        public BesinService()
        {
            besinRepository = new BesinRepository();
        }

        public int BesinBul(string arananKelime)
        {
            
            return besinRepository.BesinBul(arananKelime);
        }
    }
}
