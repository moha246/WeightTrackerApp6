using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface ICalorie_CounterService
    {
        Guid AddCalorie(CalorieCounter calorie_counter);
        CalorieCounter GetACalorie(Guid id);
        IQueryable<CalorieCounter> GetAllCalorie_Counter();
        void Update(CalorieCounter calorie_counter);
        void Delete(Guid Id);
    }
}
