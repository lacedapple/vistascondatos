using System.Dynamic;

namespace LibreriaVistas;

public class HojaPresentacion
{
    public string Plantel { get; set; } = string.Empty;
    public string NombrePlantel { get; set; } = string.Empty;
    public string Grupo { get; set; } = string.Empty;
    public string Carrera { get; set; } = string.Empty;
    public int Semestre { get; set; }
    public List<Alumno> Alumnos { get; set; } = new List<Alumno>();
}