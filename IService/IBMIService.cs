using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IBMIService
    {
        Guid AddBMI(BMI bmi);
        BMI GetABMI(Guid id);
        IQueryable<BMI> GetAllBMI();
        void Update(BMI bmi);
        void Delete(Guid id);

        BMI GetBMIByUserId(Guid user_id);
    }
}

