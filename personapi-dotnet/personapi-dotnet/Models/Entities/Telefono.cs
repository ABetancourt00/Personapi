using System.Text.Json.Serialization;

public partial class Telefono
{
    public string Num { get; set; }

    public string Oper { get; set; }

    public int Duenio { get; set; }

    [JsonIgnore] // Ignorar en Swagger
    public virtual Persona? DuenioNavigation { get; set; }
}
