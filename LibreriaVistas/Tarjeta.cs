using System.Dynamic;

namespace LibreriaVistas;

public class Tarjeta
{
    public string Imagen { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public DateTime Fecha {get ; set; }
   
}