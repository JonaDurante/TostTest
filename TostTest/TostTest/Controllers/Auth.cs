using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TostTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        // GET: api/<Auth>
        [HttpGet]
        public IActionResult Authorize()
        {
            return Ok(new string[] { "Conectar" });
        }


    }
}
