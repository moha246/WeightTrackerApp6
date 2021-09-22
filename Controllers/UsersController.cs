using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Models;
using WeightTrackerApp6.IService;
using WeightTrackerApp6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using System.IO;

namespace WeightTrackerApp6.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        IUsersService _usersService;
        IWeightDetailsService _weight_DetailsService;
        ILogger<UsersController> _logger;
        IAspNetUserService _aspNetUserService;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(IUsersService usersService, IWeightDetailsService weight_DetailsService, ILogger<UsersController> logger, IAspNetUserService aspNetUserService, UserManager<IdentityUser> userManager)
        {
            _usersService = usersService;
            _weight_DetailsService = weight_DetailsService;
            _logger = logger;
            _aspNetUserService = aspNetUserService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Dashboard()
        {
            return View();

        }
        public IActionResult Profile()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            ViewBag.userid = details.First_Name;
            return View(details);
            
        }
        

        [HttpPost]
        public IActionResult Profile (IFormCollection form)
        {
            var users = new Users();
            users.Address = form["Address"].ToString();
            users.Age = int.Parse(form["Age"].ToString());
            users.Last_Name = form["Last_Name"].ToString();
            users.Gender = form["Gender"].ToString();
            users.UserName = form["UserName"].ToString();
            users.Postal_code = int.Parse(form["postal_code"].ToString());
            users.Email = form["Email"].ToString();
            users.City = form["City"].ToString();
            users.Country = form["Country"].ToString();
            users.First_Name = form["First_Name"].ToString();
            users.About_me = form["About_me"].ToString();

            users.Id = _usersService.AddUser(users);
            return View();
        }

        [HttpPost]
        public IActionResult EditDoneDetails(Users users)
        {
            _usersService.Update(users);

            return RedirectToAction("Profile");
        }

        public IActionResult DoneDetails()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            
            return View(details);
        }

        public IActionResult EditDoneDetails()
        {
            var user_id = _userManager.GetUserId(HttpContext.User);
            var details = _usersService.GetDetailByUserId(user_id);
            return View(details);
        }


        
        public IActionResult List()
        {
            var context = new WeightTrackerContext();
            var username = User.Identity.Name;
            Users users = null;

            if (!string.IsNullOrEmpty(username))
            {
                var user = context.Users.SingleOrDefault(u => u.UserName == username);
                users = user;
            }

            return View(users);
        }

        public async Task<IActionResult> UploadProfilePic(string userid)

        {

            var files = Request.Form.Files;



            var folderpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Content", "images");



            if (!Directory.Exists(folderpath))

            {

                Directory.CreateDirectory(folderpath);

            }

            var file_loc = Path.Combine(folderpath,  userid +  ".jpg");



            if (files != null && files[0] != null)

            {

                var extension = Path.GetExtension(files[0].FileName);

                if (!new string[] { ".jpeg", ".jpg", ".png", ".gif" }.Contains(extension.ToLower()))

                {

                    return BadRequest("Logo images must be a valid image format");

                }

                using (var fileStream = new FileStream(file_loc, FileMode.Create))

                {

                    await files[0].CopyToAsync(fileStream);

                }

                return Ok();

            }

            return BadRequest("Nothing uploaded");

        }

        public IActionResult DoneDetails(Guid id)
        {
            
            
            return View(_usersService.GetAUser(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult AllUsers()
        {
            return View(_usersService.GetAllUsers());
        }
    }
}
