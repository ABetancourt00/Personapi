using personapi_dotnet.Models.Entities;

public interface ITelefonoRepository
{
    Task<List<Telefono>> GetAll();
    Task<Telefono> GetById(string num);
    Task Add(Telefono telefono);
    Task Update(Telefono telefono);
    Task Delete(string num);
}
