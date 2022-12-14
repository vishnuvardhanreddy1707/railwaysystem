using RailwaySystem.API.Models;
using RailwaySystem.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Services
{
    public class QuotaS
    {
        private IQuota _Iquota;
        public QuotaS(IQuota Iquota)
        {
            _Iquota = Iquota;
        }
        public string SaveQuota(Quota quota)
        {
            return _Iquota.SaveQuota(quota);
        }
        public string UpdateQuota(Quota quota)
        {
            return _Iquota.UpdateQuota(quota);
        }
        public Quota GetQuota(int QuotaId)
        {
            return _Iquota.GetQuota(QuotaId);
        }
        public List<Quota> GetAllQuotas()
        {
            return _Iquota.GetAllQuotas();
        }
    }
}
