using personapi_dotnet.Models.Entities;

public interface IEstudioRepository
{
    Task<List<Estudio>> GetAll();
    Task<Estudio> GetById(int id);
    Task Add(Estudio estudio);
    Task Update(Estudio estudio);
    Task Delete(int id);
}
