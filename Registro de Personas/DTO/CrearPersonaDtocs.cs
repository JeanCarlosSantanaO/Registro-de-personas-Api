namespace Registro_de_Personas.DTO
{
    public class CrearPersonaDtocs
    {
        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Cedula { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly FechaNacimiento { get; set; }

        public string Genero { get; set; } = null!;

        public string EstadoCivil { get; set; } = null!;

        public string Nacionalidad { get; set; } = null!;

        public int Foto { get; set; }
    }
}
