using personapi_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;


public class EstudioRepository : IEstudioRepository
{
    private readonly PersonaDbContext _context;

    public EstudioRepository(PersonaDbContext context)
    {
        _context = context;
    }

    public async Task<List<Estudio>> GetAll()
    {
        return await _context.Estudios.ToListAsync();
    }

    public async Task<Estudio> GetById(int id)
    {
        return await _context.Estudios.FindAsync(id);
    }

    public async Task Add(Estudio estudio)
    {
        _context.Estudios.Add(estudio);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Estudio estudio)
    {
        _context.Estudios.Update(estudio);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var estudio = await _context.Estudios.FindAsync(id);
        if (estudio != null)
        {
            _context.Estudios.Remove(estudio);
            await _context.SaveChangesAsync();
        }
    }
}
