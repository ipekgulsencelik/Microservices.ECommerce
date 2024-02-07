using ECommerce.IdentityServer.DTOs;
using ECommerce.IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(UserRegisterDTO userRegisterDTO)
        {
            var values = new ApplicationUser()
            {
                UserName = userRegisterDTO.UserName,
                Email = userRegisterDTO.Email,
                Name = userRegisterDTO.Name,
                Surname = userRegisterDTO.Surname,
                City = userRegisterDTO.City
            };

            var result = await _userManager.CreateAsync(values, userRegisterDTO.Password);
            if (result.Succeeded)
            {
                return Ok("Kullanıcı Eklendi.");
            }
            else
            {
                return Ok("Bir Hata Oluştu!..");
            }
        }
    }
}