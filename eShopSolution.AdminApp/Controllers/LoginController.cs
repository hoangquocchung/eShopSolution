using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class LoginController : Controller
    {
        //private readonly IUserApiClient _userApiClient;
        //private readonly IConfiguration _configuration;

        //public LoginController(IUserApiClient userApiClient,
        //    IConfiguration configuration)
        //{
        //    _userApiClient = userApiClient;
        //    _configuration = configuration;
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
