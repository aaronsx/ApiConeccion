using DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialController : ControllerBase
    {
        private readonly Contexto _contexto;
        public EditorialController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Editoriales> Get()
        {
            List<Editoriales> listaEditoriales = _contexto.editoriales.ToList();
            return listaEditoriales;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Editoriales editorial)
        {
            _contexto.Add(editorial);
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Editoriales editorial)
        {
            _contexto.Update<Editoriales>(editorial);
            
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public void Delete([FromBody] Editoriales editorial)
        {
            _contexto.Remove<Editoriales>(editorial);
            
        }
    }
}
