using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class WeightDetailsService : IWeightDetailsService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        public Guid AddWeight_detail(WeightDetails weight_details)
        {
            _entity.WeightDetails.Add(weight_details); 
              _entity.SaveChanges();

            return weight_details.Id;

        }

        public void Delete(Guid Id)
        {
            _entity.WeightDetails.Remove(_entity.WeightDetails.FirstOrDefault(e => e.Id == Id));
            _entity.SaveChanges();
        }

        public IQueryable<WeightDetails> GetAllWeight_details()
        {
            return _entity.WeightDetails.AsQueryable();
        }

        public WeightDetails GetUserWeight_details(Guid Id)
        {
            return _entity.WeightDetails.FirstOrDefault(e => e.Id == Id);
        }
        public WeightDetails GetDetailByUserId( Guid user_id)
        {
          
            return _entity.WeightDetails.OrderBy(d => d.Date).LastOrDefault(e => e.UserId == user_id);

        }
        public IQueryable <WeightDetails> GetAllUserWeight_details(Guid mo_id)
        {

            return _entity.WeightDetails.Where(e => e.UserId == mo_id);

        }
        public void Update(WeightDetails weight_details)
        {
            var old = _entity.Users.FirstOrDefault(e => e.Id == weight_details.Id);
            _entity.Entry(old).CurrentValues.SetValues(weight_details);
            _entity.SaveChanges();
        }
    }
    }

