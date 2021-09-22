using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IWeightDetailsService
    {
        Guid AddWeight_detail(WeightDetails weight_details);
        WeightDetails GetUserWeight_details(Guid Id);
        IQueryable<WeightDetails> GetAllWeight_details();
        void Update(WeightDetails weight_details);
        void Delete(Guid id);
       
        WeightDetails GetDetailByUserId(Guid user_id);
        IQueryable <WeightDetails> GetAllUserWeight_details(Guid mo_id);
    }
}
