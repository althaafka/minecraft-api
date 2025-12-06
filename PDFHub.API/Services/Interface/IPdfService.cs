using PDFHub.API.Models;
using PDFHub.API.Models.DTOs.Responses;

namespace PDFHub.API.Services;

public interface IPdfService
{
    Task<ServiceResult<UploadPdfResponse>> UploadPdfAsync(IFormFile file, string userId);
}