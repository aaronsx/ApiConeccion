using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly Contexto _contexto;
        public LibroController(Contexto contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Libros> Get(Contexto contexto)
        {
            List<Libros> listaLibros = _contexto.libros.ToList();
            return listaLibros;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Libros libro)
        {
            _contexto.Add(libro);
           
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Libros libro)
        {
            _contexto.Update<Libros>(libro);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Libros libro)
        {
            _contexto.Remove<Libros>(libro);
            
        }
    }
}
