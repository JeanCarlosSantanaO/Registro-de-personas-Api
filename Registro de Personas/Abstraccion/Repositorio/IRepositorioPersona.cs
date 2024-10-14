using Registro_de_Personas.DTO;
using Registro_de_Personas.Modelos;

namespace Registro_de_Personas.Abstraccion.Repositorio
{
    public interface IRepositorioPersona
    {
        List<Persona> Get();
        Persona GetById(int id);
        Persona Create(CrearPersonaDtocs crearPersonaDtocs);
        Persona Update(int id,ActualizarPersonaDto actualizarPersonaDto);
        void Delete(int id);

    }
}
