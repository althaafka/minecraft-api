using AutoMapper;
using PDFHub.API.Models.Domains;
using PDFHub.API.Models.DTOs;

namespace PDFHub.API.MappingProfiles;

public class PdfMappingProfile : Profile
{
    public PdfMappingProfile()
    {
        CreateMap<PdfFiles, PdfResponse>()
            .ForMember(dest => dest.UploadedAt, opt => opt.MapFrom(src => DateTime.UtcNow));

        CreateMap<PdfFiles, EditPdfResponse>()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}
