using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly Contexto _contexto;
        public PrestamoController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Prestamos> Get()
        {
            List<Prestamos> listaPrestamos = _contexto.prestamos.ToList();
            return listaPrestamos;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Prestamos prestamo)
        {
            _contexto.Add(prestamo);
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Prestamos prestamo)
        {
            _contexto.Update<Prestamos>(prestamo);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Prestamos prestamo)
        {
            _contexto.Remove<Prestamos>(prestamo);
            
        }
    }
}
