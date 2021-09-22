using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;

namespace WeightTrackerApp6.Controllers
{
    public class WeightDetailsController : Controller
    {
        IBMIService _bmiService;
        IWeightDetailsService _weight_detailsService;
        IUsersService _usersService;
        private readonly UserManager<IdentityUser> _userManager;

        public WeightDetailsController(IUsersService usersService, IBMIService bmiService, IWeightDetailsService weight_DetailsService, UserManager<IdentityUser> userManager)
        {
            _usersService = usersService;
            _bmiService = bmiService;
            _weight_detailsService = weight_DetailsService;
            _userManager = userManager;
        }

        public IActionResult WeightDetails()
        {
            return View();
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
            public IActionResult Tables()
        {
            var mo_id = _userManager.GetUserId(HttpContext.User);
            var k_id = _usersService.GetDetailByUserId(mo_id);
            var detaill = _weight_detailsService.GetAllUserWeight_details(k_id.Id);
            return View(detaill);

            //return View(_weight_detailsService.GetAllUserWeight_details());
        }


        [HttpPost]
        public IActionResult WeightDetails(IFormCollection form)
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            var weight_details = new WeightDetails();
            weight_details.Weights = int.Parse(form["Weights"].ToString());
            weight_details.Height = int.Parse(form["Height"].ToString());
            weight_details.Waist_size = float.Parse(form["Waist_size"].ToString());
            weight_details.Chest_size = float.Parse(form["Chest_size"].ToString());
            weight_details.Date = DateTime.Now ;
            weight_details.UserId = details.Id;

            
            //weight_details.UserId = _usersService.GetAUser(UserId);

            //users.aspNetUsersId = _aspNetUserService.GetAspNetUser(Id);
            weight_details.Id = _weight_detailsService.AddWeight_detail(weight_details);
            


            return RedirectToAction("WeightInput", new { id = weight_details.Id });
        }
         
        
        public IActionResult WeightInput(Guid Id)
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var u_id = _usersService.GetDetailByUserId(user_id);
            var details = _weight_detailsService.GetDetailByUserId(u_id.Id);
            //_usersService.GetAUser(id);
            return View(details);
            //return View(_weight_detailsService.GetUserWeight_details(Id));
        }

        public IActionResult Details()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var x = Guid.Parse(user_id);
            var details = _weight_detailsService.GetDetailByUserId(x);
            //_usersService.GetAUser(id);
            return View(details);
        }

        public IActionResult DoneWeightDetails(Guid Id)
        {


            return View(_weight_detailsService.GetUserWeight_details(Id));
        }

        public IActionResult DoneDetails()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            //_usersService.GetAUser(id);
            return View(details);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string WeightTracker()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            var weightdata = _weight_detailsService.GetAllUserWeight_details(details.Id);

            return JsonConvert.SerializeObject(new
            {
                 weightdata
            });
        }

       

    }
}
