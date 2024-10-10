using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registro_de_Personas.Abstraccion.Servicios;
using Registro_de_Personas.DTO;

namespace Registro_de_Personas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IServiciosPersonas serviciosPersonas;
        public PersonaController(IServiciosPersonas servicios)
        {
            serviciosPersonas = servicios;
       
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var result = serviciosPersonas.Get();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create(CrearPersonaDtocs crearPersonaDtocs)
        {
            var result = serviciosPersonas.Create(crearPersonaDtocs);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarPersonaDto actualizar)
        {
            var result = serviciosPersonas.Update(id, actualizar);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            serviciosPersonas.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = serviciosPersonas.GetById(id);
            return Ok(result);
        }

    }

    
}
