using Dostava.DTOs;
using Dostava.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dostava.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly PoruciDbContext _context;

        public LoginController(PoruciDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Login(string username,string password)
        {

            User u = new User();
            u = _context.Users.Where(x => x.UserName == username).FirstOrDefault();
            string cryptedPass = Common.sha256(password);

            if(cryptedPass == u.Password)
            {
                return Ok(u);
            }
            else
            {
                return BadRequest("Incorrect username or password");
            }
           
        }
    }
}
