using Microsoft.EntityFrameworkCore;
using PDFHub.API.Data;
using PDFHub.API.Models.Domains;
using PDFHub.API.Repositories;

namespace PDFHub.API.Repositories;

public class PdfRepository : IPdfRepository
{
    private readonly PDFHubDbContext _context;

    public PdfRepository(PDFHubDbContext context)
    {
        _context = context;
    }

    public async Task<PdfFiles> AddAsync(PdfFiles pdfFile)
    {
        await _context.PdfFiles.AddAsync(pdfFile);
        await _context.SaveChangesAsync();
        return pdfFile;
    }

    public async Task<PdfFiles?> GetByIdAsync(int id)
    {
        return await _context.PdfFiles
            .Include(p => p.User)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<PdfFiles>> GetAllAsync()
    {
        return await _context.PdfFiles
            .Include(p => p.User)
            .ToListAsync();
    }

    public async Task<IEnumerable<PdfFiles>> GetByUserIdAsync(string userId)
    {
        return await _context.PdfFiles
            .Include(p => p.User)
            .Where(p => p.UserId == userId)
            .ToListAsync();
    }

    public async Task<PdfFiles?> UpdateAsync(PdfFiles pdfFile)
    {
        var existingPdf = await _context.PdfFiles.FindAsync(pdfFile.Id);
        if (existingPdf == null)
        {
            return null;
        }

        _context.Entry(existingPdf).CurrentValues.SetValues(pdfFile);
        await _context.SaveChangesAsync();
        return existingPdf;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var pdfFile = await _context.PdfFiles.FindAsync(id);
        if (pdfFile == null)
        {
            return false;
        }

        _context.PdfFiles.Remove(pdfFile);
        await _context.SaveChangesAsync();
        return true;
    }
}
