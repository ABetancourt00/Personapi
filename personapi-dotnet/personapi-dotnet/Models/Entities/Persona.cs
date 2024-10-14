using personapi_dotnet.Models.Entities;
using System.Text.Json.Serialization;

public partial class Persona
{
    public int Cc { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public int? Edad { get; set; }

    [JsonIgnore] // Ignorar en Swagger
    public virtual ICollection<Estudio>? Estudios { get; set; } = new List<Estudio>();

    [JsonIgnore] // Ignorar en Swagger
    public virtual ICollection<Telefono>? Telefonos { get; set; } = new List<Telefono>();
}
