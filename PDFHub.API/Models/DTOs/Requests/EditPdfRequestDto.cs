namespace PDFHub.API.Models.DTOs;

public class EditPdfRequestDto
{
    public string Filename{get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
}