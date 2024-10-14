using personapi_dotnet.Models.Entities;
using System.Text.Json.Serialization;

public partial class Estudio
{
    public int IdProf { get; set; }

    public int Cc { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Univer { get; set; }

    [JsonIgnore] // Ignorar en Swagger
    public virtual Persona? CcNavigation { get; set; }

    [JsonIgnore] // Ignorar en Swagger
    public virtual Profesion? IdProfNavigation { get; set; }
}
