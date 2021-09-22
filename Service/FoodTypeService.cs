using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class FoodTypeService : IFoodTypeService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        public IQueryable<FoodType> GetAllFoodTypes()
        {
            
            return _entity.FoodType.AsQueryable();

        }

        public FoodType GetAFoodType(int Id)
        {
            return _entity.FoodType.FirstOrDefault(e => e.Id == Id);
        }


    }

}
