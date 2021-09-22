using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.IService
{
    public interface IFoodTypeService
    {
        FoodType GetAFoodType(int Id);
        IQueryable<FoodType> GetAllFoodTypes();
        //FoodType GetDetailByUserId(string user_id);
    }
}
