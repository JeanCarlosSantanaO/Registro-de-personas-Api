using System;
using System.Collections.Generic;

namespace Registro_de_Personas.Modelos;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public string Genero { get; set; } = null!;

    public string EstadoCivil { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public DateTime? FechaDeReguistro { get; set; }

    public int Foto { get; set; }
}
