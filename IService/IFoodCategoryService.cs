using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IFoodCategoryService
    {
        FoodCategory GetAFoodCategory(int Id);
        IQueryable<FoodCategory> GetAllFoodCategory();
        
    }
}
