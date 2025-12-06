using Microsoft.AspNetCore.Identity;

namespace PDFHub.API.Models.Domains;

public class PdfFiles
{
    public int Id {get; set;}
    public string OriginalFileName {get; set;} = string.Empty;
    public string StoredFilePath {get; set;} = string.Empty;
    public long FileSize {get; set;} // bytes

    // Relation
    public IdentityUser User;
}