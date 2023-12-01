using Microsoft.AspNetCore.Mvc;
using TostTest.App.Entities;

namespace TostTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Events : ControllerBase
    {
        // GET: api/<Events>
        [HttpGet]
        public List<Event> ListarEventos()
        {
            var data = new List<Event>(); // Datos que quieres devolver
            return data;
        }

        // POST api/<Events>
        [HttpPost]
        public void CrearEvento([FromBody] Event value)
        {
        }

        // PUT api/<Events>/5
        [HttpPut("{id}")]
        public void EditarEvento(int id, [FromBody] Event value)
        {
        }

        // DELETE api/<Events>/5
        [HttpDelete("{id}")]
        public void EliminarEvento(int id)
        {
        }
    }
}
