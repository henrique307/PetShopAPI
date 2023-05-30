using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShopAPI.Models;

namespace PetShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public string[] GetUsuarios()
        {

            string[] carros = { "volvo" };
            return carros;
        }
    }

}