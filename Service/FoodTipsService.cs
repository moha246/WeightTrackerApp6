using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Service
{
    public class FoodTipsService : IFoodTipsService
    {
        readonly WeightTrackerContext _entity = new WeightTrackerContext();
        public IQueryable<FoodTips> GetAllFoodTips()
        {
            return _entity.FoodTips.AsQueryable();
        }

        public FoodTips GetAFoodTip(int Id)
        {
            return _entity.FoodTips.FirstOrDefault(e => e.Id == Id);
        }


    }

}
