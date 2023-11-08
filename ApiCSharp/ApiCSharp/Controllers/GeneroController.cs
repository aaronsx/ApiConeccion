﻿using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly Contexto _contexto;
        public GeneroController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Generos> Get()
        {
            List<Generos> listaGeneros = _contexto.generos.ToList();
            return listaGeneros;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Generos genero)
        {
            _contexto.Add(genero);
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Generos genero)
        {
            _contexto.Update<Generos>(genero);
           
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Generos genero)
        {
            _contexto.Remove<Generos>(genero);
           
        }
    }
}
