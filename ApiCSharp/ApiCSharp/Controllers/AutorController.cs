using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly Contexto _contexto;
        public AutorController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Autores> Get()
        {
            List<Autores> listaAutores = _contexto.autores.ToList();
            return listaAutores;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Autores autor)
        {
            _contexto.Add(autor);
           
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Autores autor)
        {
            _contexto.Update<Autores>(autor);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Autores autor)
        {
            _contexto.Remove<Autores>(autor);
            
        }
    }
}
