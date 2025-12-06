using PDFHub.API.Models.Domains;

namespace PDFHub.API.Repositories;

public interface IPdfRepository
{
    Task<PdfFiles> AddAsync(PdfFiles pdfFile);
    Task<PdfFiles?> GetByIdAsync(int id);
    Task<IEnumerable<PdfFiles>> GetAllAsync();
    Task<IEnumerable<PdfFiles>> GetByUserIdAsync(string userId);
    Task<PdfFiles?> UpdateAsync(PdfFiles pdfFile);
    Task<bool> DeleteAsync(int id);
}
