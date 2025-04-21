using BookShop.Models;
using DemoBookStoreAPI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoBookStoreAPI.DTOs;

namespace DemoBookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersApiController : Controller
    {
        private readonly DemoBookStoreAPIContext _context;
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;

        public UsersApiController(DemoBookStoreAPIContext context, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsersAsync()
        {
            return await _context.User.ToListAsync();
        }

        // POST: api/Users/Register
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDto)
        {
            var user = new UserModel
            {
                UserName = userRegisterDto.Email.Split('@')[0],
                Email = userRegisterDto.Email,
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                Address = userRegisterDto.Address,
                DoB = userRegisterDto.DoB,
                NormalizedEmail = _userManager.NormalizeEmail(userRegisterDto.Email),
                NormalizedUserName = _userManager.NormalizeName(userRegisterDto.Email.Split('@')[0]),
            };

            var result = await _userManager.CreateAsync(user, userRegisterDto.Password);

            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        // POST: api/Users/Login
    }
}
