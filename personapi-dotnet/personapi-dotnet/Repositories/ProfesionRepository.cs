using personapi_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;


public class ProfesionRepository : IProfesionRepository
{
    private readonly PersonaDbContext _context;

    public ProfesionRepository(PersonaDbContext context)
    {
        _context = context;
    }

    public async Task<List<Profesion>> GetAll()
    {
        return await _context.Profesions.ToListAsync();
    }

    public async Task<Profesion> GetById(int id)
    {
        return await _context.Profesions.FindAsync(id);
    }

    public async Task Add(Profesion profesion)
    {
        _context.Profesions.Add(profesion);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Profesion profesion)
    {
        _context.Profesions.Update(profesion);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var profesion = await _context.Profesions.FindAsync(id);
        if (profesion != null)
        {
            _context.Profesions.Remove(profesion);
            await _context.SaveChangesAsync();
        }
    }
}
