using personapi_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;


public class PersonaRepository : IPersonaRepository
{
    private readonly PersonaDbContext _context;

    public PersonaRepository(PersonaDbContext context)
    {
        _context = context;
    }

    public async Task<List<Persona>> GetAll()
    {
        return await _context.Personas.ToListAsync();
    }

    public async Task<Persona> GetById(int cc)
    {
        return await _context.Personas.FindAsync(cc);
    }

    public async Task Add(Persona persona)
    {
        _context.Personas.Add(persona);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Persona persona)
    {
        _context.Personas.Update(persona);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int cc)
    {
        var persona = await _context.Personas.FindAsync(cc);
        if (persona != null)
        {
            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();
        }
    }
}
