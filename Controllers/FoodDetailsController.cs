using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Controllers
{
    public class FoodDetailsController : Controller
    {
        IFoodCategoryService _foodcategoryService;
        IFoodTipsService _foodtipservice;
        IFoodTypeService _foodtypeservice;
        private readonly UserManager<IdentityUser> _userManager;

        public FoodDetailsController(IFoodCategoryService foodcategoryService, IFoodTipsService foodtipservice, IFoodTypeService foodtype, UserManager<IdentityUser> userManager)
        {
            _foodcategoryService = foodcategoryService;
            _foodtipservice = foodtipservice;
            _foodtypeservice = foodtype;
            _userManager = userManager;
        }
        public IActionResult FoodDetails()
        {
            var foodCategory = _foodcategoryService.GetAllFoodCategory();
            ViewBag.foodCategories = foodCategory.ToList();
            var foodType = _foodtypeservice.GetAllFoodTypes();
            ViewBag.foodTypes = foodType.ToList();


            return View();
        }

        //public IActionResult GetFoodType()
        //{
        //    var food_obj = (from item in _foodtypeservice.GetAllFoodTypes()
        //                    select new
        //                    {
        //                        item.Id,
        //                        item.FoodTypeName,
        //                        item.FoodTypeMeasurement,
        //                        item.CalorieSize,
        //                        item.FoodCategorieId
        //                    }).ToList();
        //    var model = new List<FoodCategory>();
        //    foreach (var item in food_obj.GroupBy(a => a.FoodCategorieId))
        //    {
        //        model.Add(new FoodCategory
        //        {
        //            Id = item.Key.Id,
        //            FoodName = item.Key.FoodName,
        //            foodTypes = (from i in item.ToList()
        //                         select new FoodType
        //                         {
        //                             FoodTypeName = i.FoodTypeName,
        //                             FoodTypeMeasurement = i.FoodTypeMeasurement,
        //                             CalorieSize = i.CalorieSize,
        //                             Id = i.Id
        //                         }).ToList()

        //        });

        //    }

        //    return Ok(model);
        //}


        public IActionResult Index()
        {
            return View();
        }
    }
}
