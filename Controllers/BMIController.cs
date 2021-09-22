using Microsoft.AspNetCore.Http;
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
    public class BMIController : Controller
    {
        IBMIService _bmiService;
        IWeightDetailsService _weight_detailsService;
        IUsersService _usersService;
        private readonly UserManager<IdentityUser> _userManager;

        public BMIController(IUsersService usersService, IBMIService bmiService, IWeightDetailsService weight_DetailsService, UserManager<IdentityUser> userManager)
        {
            _usersService = usersService;
            _weight_detailsService = weight_DetailsService;
            _bmiService = bmiService;
            _userManager = userManager;
        }


        public IActionResult BMI()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMI(IFormCollection form)
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            var bmi = new BMI();
            bmi.BMICount = float.Parse(form["BMICount"].ToString());
            bmi.UserId = details.Id;

            //bmi.UserId = details.Id;


            //weight_details.UserId = _usersService.GetAUser(UserId);

            //users.aspNetUsersId = _aspNetUserService.GetAspNetUser(Id);
            bmi.id = _bmiService.AddBMI(bmi);



            return RedirectToAction("BMIInput", new { id = bmi.id });
        }

        public IActionResult Dashboard()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var u_id = _usersService.GetDetailByUserId(user_id);
            var details = _bmiService.GetBMIByUserId(u_id.Id);
            var weight = _weight_detailsService.GetDetailByUserId(u_id.Id);

            ViewBag.Details = details;
            ViewBag.Weight = weight;

            //var detail = _weight_detailsService.GetDetailByUserId(u_id.Id);
            // ViewBag.weight = detail.Weights;
            //_usersService.GetAUser(id);

            return View();

        }

        public IActionResult DoneDetails()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            //_usersService.GetAUser(id);
            return View(details);
        }
        public IActionResult BMIInput(Guid Id)
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var u_id = _usersService.GetDetailByUserId(user_id);
            var details = _bmiService.GetBMIByUserId(u_id.Id);

            //_usersService.GetAUser(id);
            return View(details);
            //return View(_weight_detailsService.GetUserWeight_details(Id));
        }


        public IActionResult Index()
          {
            return View();
        }
    }
}
