using personapi_dotnet.Models.Entities;

public interface IProfesionRepository
{
    Task<List<Profesion>> GetAll();
    Task<Profesion> GetById(int id);
    Task Add(Profesion profesion);
    Task Update(Profesion profesion);
    Task Delete(int id);
}
