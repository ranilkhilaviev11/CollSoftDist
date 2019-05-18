using Microsoft.AspNetCore.Http;

namespace ColSoftDist.Models
{
    public class FileUploadViewModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string About { get; set; }
        public IFormFile FileUpload { get; set; }
    }
}
