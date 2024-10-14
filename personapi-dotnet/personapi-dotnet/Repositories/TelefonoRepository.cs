using personapi_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;


public class TelefonoRepository : ITelefonoRepository
{
    private readonly PersonaDbContext _context;

    public TelefonoRepository(PersonaDbContext context)
    {
        _context = context;
    }

    public async Task<List<Telefono>> GetAll()
    {
        return await _context.Telefonos.ToListAsync();
    }

    public async Task<Telefono> GetById(string num)
    {
        return await _context.Telefonos.FindAsync(num);
    }

    public async Task Add(Telefono telefono)
    {
        _context.Telefonos.Add(telefono);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Telefono telefono)
    {
        _context.Telefonos.Update(telefono);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(string num)
    {
        var telefono = await _context.Telefonos.FindAsync(num);
        if (telefono != null)
        {
            _context.Telefonos.Remove(telefono);
            await _context.SaveChangesAsync();
        }
    }
}
