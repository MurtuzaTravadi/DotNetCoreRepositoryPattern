using Microsoft.AspNetCore.Mvc;
using DotNetCoreRepositoryPattern.Repository.Abstract;
using System.Collections.Generic;
using DotNetCoreRepositoryPattern.Models.Domain.Model;

namespace DotNetCoreRepositoryPattern.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            //IEnumerable<User> user =as IEnumerable<User>;
            return View(userRepository.GetAll());
        }
        

    }
}