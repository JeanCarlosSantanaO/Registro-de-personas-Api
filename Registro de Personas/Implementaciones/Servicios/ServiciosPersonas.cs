using Registro_de_Personas.Abstraccion.Repositorio;
using Registro_de_Personas.Abstraccion.Servicios;
using Registro_de_Personas.DTO;
using Registro_de_Personas.Implementaciones.Repositorio;
using Registro_de_Personas.Modelos;

namespace Registro_de_Personas.Implementaciones.Servicios
{
    public class ServiciosPersonas :IServiciosPersonas
    {
        private readonly IRepositorioPersona repositorioPersona;
        
        public ServiciosPersonas(IRepositorioPersona repositorio)
        {
            repositorioPersona=repositorio;

        }

        public List<PersonasDto> Get()
        {
            var personas = repositorioPersona.Get();
            var personasDto = new List<PersonasDto>();
            foreach (Persona persona in personas)
            {
                var npersonaDto = new PersonasDto()
                {
                    Id = persona.Id,
                    Nombre = persona.Nombre,
                    Apellido = persona.Apellido,
                    Cedula = persona.Cedula,
                    Direccion = persona.Direccion,
                    Telefono = persona.Telefono,
                    Email = persona.Email,
                    EstadoCivil = persona.EstadoCivil,
                    Nacionalidad = persona.Nacionalidad,
                    Foto = persona.Foto,
                    FechaNacimiento = persona.FechaNacimiento,
                    FechaDeReguistro = persona.FechaDeReguistro,
                    Genero = persona.Genero

                };
                
                personasDto.Add(npersonaDto);
            }
            return personasDto;
        }

        public Persona GetById(int id)
        {
            return repositorioPersona.GetById(id);
        }


        public PersonasDto Create(CrearPersonaDtocs crearPersonaDtocs)
        {
            var personas = repositorioPersona.Create(crearPersonaDtocs);
            var personasDto = new PersonasDto
            {
                Id = personas.Id,
                Nombre = personas.Nombre,
                Apellido = personas.Apellido,
                Cedula = personas.Cedula,
                Direccion = personas.Direccion,
                Telefono = personas.Telefono,
                Email = personas.Email,
                EstadoCivil = personas.EstadoCivil,
                Nacionalidad = personas.Nacionalidad,
                Foto = personas.Foto,
                FechaNacimiento = personas.FechaNacimiento,
                FechaDeReguistro = personas.FechaDeReguistro,
                Genero = personas.Genero
            };
            return personasDto;


        }

        public PersonasDto Update(int id, ActualizarPersonaDto actualizarPersonaDto)
        {
            var persona = repositorioPersona.Update(id, actualizarPersonaDto);
            var personaDTO = new PersonasDto
            {

                Id =id,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Cedula = persona.Cedula,
                Direccion = persona.Direccion,
                Telefono = persona.Telefono,
                Email = persona.Email,
                EstadoCivil = persona.EstadoCivil,
                Nacionalidad = persona.Nacionalidad,
                Foto = persona.Foto,
                FechaNacimiento = persona.FechaNacimiento,
                FechaDeReguistro = persona.FechaDeReguistro,
                Genero = persona.Genero
            };
            return personaDTO;
        }

        public void Delete(int id)
        {
           repositorioPersona.Delete(id);
        }
    }
}
