using Registro_de_Personas.Abstraccion.Repositorio;
using Registro_de_Personas.DTO;
using Registro_de_Personas.Modelos;

namespace Registro_de_Personas.Implementaciones.Repositorio
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly PersonasContext _context;

        public RepositorioPersona(PersonasContext context)
        {
            _context = context;
        }


        public Persona Create(CrearPersonaDtocs crearPersonaDtocs)
        {
            var persona = new Persona
            {
                Nombre = crearPersonaDtocs.Nombre,
                Apellido = crearPersonaDtocs.Apellido,
                Cedula = crearPersonaDtocs.Cedula,
                Direccion = crearPersonaDtocs.Direccion,
                Telefono = crearPersonaDtocs.Telefono,
                Email = crearPersonaDtocs.Email,
                FechaNacimiento = crearPersonaDtocs.FechaNacimiento,
                Genero = crearPersonaDtocs.Genero,
                EstadoCivil = crearPersonaDtocs.EstadoCivil,
                Nacionalidad = crearPersonaDtocs.Nacionalidad,
                Foto = crearPersonaDtocs.Foto
            }; 
            _context.Personas.Add(persona);
            _context.SaveChanges();
            return persona;
        }

        public Persona Update(int id,ActualizarPersonaDto actualizarPersonaDto) 
        {
            var personasExistente = GetById(id);


            personasExistente.Nombre = actualizarPersonaDto.Nombre ?? personasExistente.Nombre;
            personasExistente.Apellido = actualizarPersonaDto.Apellido ??personasExistente.Apellido;
            personasExistente.Cedula = actualizarPersonaDto.Cedula ?? personasExistente.Cedula;
            personasExistente.Direccion = actualizarPersonaDto.Direccion ?? personasExistente.Direccion;
            personasExistente.Telefono = actualizarPersonaDto.Telefono ?? personasExistente.Telefono;
            personasExistente.Email = actualizarPersonaDto.Email ?? personasExistente.Email;
            personasExistente.FechaNacimiento = actualizarPersonaDto.FechaNacimiento ?? personasExistente.FechaNacimiento;
            personasExistente.Genero = actualizarPersonaDto.Genero ?? personasExistente.Genero;
            personasExistente.EstadoCivil = actualizarPersonaDto.EstadoCivil ?? personasExistente.EstadoCivil;
            personasExistente.Nacionalidad = actualizarPersonaDto.Nacionalidad ?? personasExistente.Nacionalidad;
            personasExistente.Foto = actualizarPersonaDto.Foto ?? personasExistente.Foto;
            
            _context.Update(personasExistente);
            _context.SaveChanges();
            var personaActualizada = GetById(id);
            return personaActualizada;
           

        }


      public List<Persona> Get()
      {
            return [.. _context.Personas];
      }

        public Persona GetById(int id) 
        {
            return _context.Personas.Where(p => p.Id==id).FirstOrDefault();
        }


        public void Delete(int id)
        {
            Persona persona= GetById(id);
            _context.Remove(persona);
            _context.SaveChanges();
        }










    }
}
