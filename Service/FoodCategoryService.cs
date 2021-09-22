using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;
using WeightTrackerApp6.IService;

namespace WeightTrackerApp6.Service
{
        
        public class FoodCategoryService : IFoodCategoryService
        {
            readonly WeightTrackerContext _entity = new WeightTrackerContext();
            public IQueryable<FoodCategory> GetAllFoodCategory()
            {
                return _entity.FoodCategory.AsQueryable();
            }

            public FoodCategory GetAFoodCategory(int Id)
            {
                return _entity.FoodCategory.FirstOrDefault(e => e.Id == Id);
            }
          

        }
    
}