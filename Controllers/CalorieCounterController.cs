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
    public class CalorieCounterController : Controller
    {
        private readonly WeightTrackerContext _context;
        IUsersService _usersService;
        private readonly UserManager<IdentityUser> _userManager;
        IWeightDetailsService _weight_detailsService;
        IBMIService _bmiService;
        IAspNetUserService _aspNetUserService;


        public CalorieCounterController(WeightTrackerContext context, IUsersService usersService, UserManager<IdentityUser> userManager, IAspNetUserService aspNetUserService, IWeightDetailsService weight_DetailsService, IBMIService bmiService)
        {
            _context = context;
            _aspNetUserService = aspNetUserService;
            _usersService = usersService;
            _userManager = userManager;
            _weight_detailsService = weight_DetailsService;
            _bmiService = bmiService;
        }


        public IActionResult CalorieCounter()
        {
            return View();
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
    }
}
