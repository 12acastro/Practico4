using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private IBL_Personas _bl;
        private IDAL_Personas _dal;

        public PersonasController()
        {
            _dal = new DAL_Personas_SQL();
            _bl = new BL_Personas(_dal);
        }



        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return _bl.GetPersonas();
        }

        [HttpGet("{documento}")]
        public Persona Get(string documento)
        {
            return _bl.Get(documento);
        }

        [HttpPost]
        public Persona Post([FromBody] Persona value)
        {
            return _bl.AddPersona(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
