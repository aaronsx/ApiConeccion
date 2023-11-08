using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccesoController : ControllerBase
    {
        private readonly Contexto _contexto;
        public AccesoController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Accesos> Get()
        {
            List<Accesos> listaAccesos = _contexto.accesos.ToList();
            return listaAccesos;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Accesos acs)
        {
            _contexto.Add(acs);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Accesos acs)
        {
            _contexto.Update<Accesos>(acs);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Accesos acs)
        {
            _contexto.Remove<Accesos>(acs);
            
        }
    }
}
