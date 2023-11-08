using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosPrestamoController : ControllerBase
    {
        private readonly Contexto _contexto;
        public EstadosPrestamoController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Estados_Prestamos> Get()
        {
            List<Estados_Prestamos> listaEstadosPrestamo = _contexto.estados_Prestamos.ToList();
            return listaEstadosPrestamo;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Estados_Prestamos estadoPrestamo)
        {
            _contexto.Add(estadoPrestamo);
           
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Estados_Prestamos estadoPrestamo)
        {
            _contexto.Update<Estados_Prestamos>(estadoPrestamo);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Estados_Prestamos estadoPrestamo)
        {
            _contexto.Remove<Estados_Prestamos>(estadoPrestamo);
          
        }
    }
}
