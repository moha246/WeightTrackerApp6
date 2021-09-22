using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Models;
using Microsoft.AspNetCore.Identity;
using WeightTrackerApp6.Service;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace WeightTrackerApp6.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly WeightTrackerContext _context;
        IUsersService _usersService;
        private readonly UserManager<IdentityUser> _userManager;
        IWeightDetailsService _weight_detailsService;
        IBMIService _bmiService;
        IAspNetUserService _aspNetUserService;


        public HomeController(WeightTrackerContext context, IUsersService usersService, UserManager<IdentityUser> userManager, IAspNetUserService aspNetUserService, IWeightDetailsService weight_DetailsService, IBMIService bmiService)
        {
            _context = context;
            _aspNetUserService = aspNetUserService;
            _usersService = usersService;
            _userManager = userManager;
            _weight_detailsService = weight_DetailsService;
            _bmiService = bmiService;
        }

        public IActionResult Index()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var u_id = _usersService.GetDetailByUserId(user_id);
            var details = _bmiService.GetBMIByUserId(u_id.Id);
            var weight = _weight_detailsService.GetDetailByUserId(u_id.Id);

            ViewBag.Details = details;
            ViewBag.Weight = weight;
            return View("Dashboard");           
        }

        //[HttpPost]
        //public IActionResult Profile(IFormCollection form)
        //{

        //    var users = new Users();
        //    users.Address = form["Address"].ToString();
        //    users.Age = int.Parse(form["Age"].ToString());
        //    users.Last_Name = form["Last_Name"].ToString();
        //    users.Gender = form["Gender"].ToString();
        //    users.UserName = form["UserName"].ToString();
        //    users.Postal_code = int.Parse(form["postal_code"].ToString());
        //    users.Email = form["Email_"].ToString();
        //    users.City = form["City"].ToString();
        //    users.Country = form["Country"].ToString();
        //    users.First_Name = form["First_Name"].ToString();
        //    users.About_me = form["About_me"].ToString();
          
        //    users.Id = _usersService.AddUser(users);
        //    return RedirectToAction("DoneDetails", new { id = users.Id });
        //}

        //[HttpPost]
        //public IActionResult EditDoneDetails(Users users)
        //{
        //    _usersService.Update(users);

        //    return RedirectToAction("DoneDetails");
        //}

        //public IActionResult DoneDetails()
        //{
        //    var user_id = _userManager.GetUserId(HttpContext.User);
        //    var details = _usersService.GetDetailByUserId(user_id);
        //    return View(details);
        //}

        //public IActionResult EditDoneDetails()
        //{
        //    var user_id = _userManager.GetUserId(HttpContext.User);
        //    var details = _usersService.GetDetailByUserId(user_id);            
        //    return View(details);
        //}
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
