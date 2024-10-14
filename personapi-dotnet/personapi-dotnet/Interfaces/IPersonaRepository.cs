using personapi_dotnet.Models.Entities;

public interface IPersonaRepository
{
    Task<List<Persona>> GetAll();
    Task<Persona> GetById(int cc);
    Task Add(Persona persona);
    Task Update(Persona persona);
    Task Delete(int cc);
}
