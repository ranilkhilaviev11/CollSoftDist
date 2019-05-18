using DAL.Models;
using System.Collections.Generic;

namespace ColSoftDist.Models
{
    public class FileIndexViewModel
    {
        public IEnumerable<FileModel> Files { get; set; }
        public string SearchQuery { get; set; }
    }
}
