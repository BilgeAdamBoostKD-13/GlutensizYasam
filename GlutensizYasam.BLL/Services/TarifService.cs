using GlutensizYasam.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.BLL.Services
{
    public class TarifService
    {
        TarifRepository tarifRepository;
        public TarifService()
        {
            tarifRepository = new TarifRepository();
        }
    }
}
