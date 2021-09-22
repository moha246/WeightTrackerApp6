using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class CalorieCounterService : ICalorie_CounterService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        public Guid AddCalorie(CalorieCounter calorie_counter)
        {
            _entity.Calorie_Counter.Add(calorie_counter);
            _entity.SaveChanges();

            return calorie_counter.id;

        }

        public void Delete(Guid Id)
        {
            _entity.Calorie_Counter.Remove(_entity.Calorie_Counter.FirstOrDefault(e => e.id == Id));
            _entity.SaveChanges();
        }

        public IQueryable<CalorieCounter> GetAllCalorie_Counter()
        {
            return _entity.Calorie_Counter.AsQueryable();
        }

        public CalorieCounter GetACalorie(Guid id)
        {
            return _entity.Calorie_Counter.FirstOrDefault(e => e.id == id);
        }

        public void Update(CalorieCounter calorie_counter)
        {
            var old = _entity.Users.FirstOrDefault(e => e.Id == calorie_counter.id);
            _entity.Entry(old).CurrentValues.SetValues(calorie_counter);
            _entity.SaveChanges();
        }

      
    }
}

