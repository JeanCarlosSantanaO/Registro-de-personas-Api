using Registro_de_Personas.DTO;
using Registro_de_Personas.Modelos;

namespace Registro_de_Personas.Abstraccion.Servicios
{
    public interface IServiciosPersonas
    {
        List<PersonasDto> Get();
        Persona GetById(int id);
        PersonasDto Create(CrearPersonaDtocs crearPersonaDtocs);
        PersonasDto Update(int id,ActualizarPersonaDto actualizarPersonaDto);
        void Delete(int id);
    }
}
