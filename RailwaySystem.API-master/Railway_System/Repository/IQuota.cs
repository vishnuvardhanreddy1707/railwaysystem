using RailwaySystem.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
   public interface IQuota
    {
        public string SaveQuota(Quota quota);
        public string DeactQuota(int QuotaId);
        public string UpdateQuota(Quota quota);
        Quota GetQuota(int QuotaId);
        List<Quota> GetAllQuotas();

    }
}
