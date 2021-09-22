using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class BMIService : IBMIService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        public Guid AddBMI(BMI bmi)
        {
            _entity.BMI.Add(bmi);
            _entity.SaveChanges();

            return bmi.id;

        }

        public void Delete(Guid Id)
        {
            _entity.BMI.Remove(_entity.BMI.FirstOrDefault(e => e.id == Id));
            _entity.SaveChanges();
        }

        public IQueryable<BMI> GetAllBMI()
        {
            return _entity.BMI.AsQueryable();
        }

        public BMI GetABMI(Guid id)
        {
            return _entity.BMI.FirstOrDefault(e => e.id == id);
        }
        public BMI GetBMIByUserId(Guid user_id)
        {

            return _entity.BMI.FirstOrDefault(e => e.UserId == user_id);

        }

        public void Update(BMI bmi)
        {
            var old = _entity.Users.FirstOrDefault(e => e.Id == bmi.id);
            _entity.Entry(old).CurrentValues.SetValues(bmi);
            _entity.SaveChanges();
        }


    }
}

