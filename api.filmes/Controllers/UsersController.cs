using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.filmes.Models;
using api.filmes.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.filmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        
        // GET: api/<UsersController>
        [HttpGet]
        public int Get(Users users)
        {            
            return _userService.GetUser(users);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(Users users)
        {
            _userService.InsertUser(users);
        }

        
    }
}
