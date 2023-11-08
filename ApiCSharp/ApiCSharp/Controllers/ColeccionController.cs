using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColeccionController : ControllerBase
    {
        private readonly Contexto _contexto;
        public ColeccionController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Colecciones> Get()
        {
            List<Colecciones> listaColecciones = _contexto.colecciones.ToList();
            return listaColecciones;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Colecciones coleccion)
        {
            _contexto.Add(coleccion);
           
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Colecciones coleccion)
        {
            _contexto.Update<Colecciones>(coleccion);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Colecciones coleccion)
        {
            _contexto.Remove<Colecciones>(coleccion);
            
        }
    }
}
