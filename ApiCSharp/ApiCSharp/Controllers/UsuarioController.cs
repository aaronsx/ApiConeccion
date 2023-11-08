using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Contexto _contexto;
        public UsuarioController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            List<Usuarios> listaUsuarios = _contexto.usuarios.ToList();
            return listaUsuarios;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Usuarios usu)
        {
            _contexto.Add(usu);
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Usuarios usu)
        {
            _contexto.Update<Usuarios>(usu);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Usuarios usu)
        {
            _contexto.Remove<Usuarios>(usu);
            
        }
    }
}
