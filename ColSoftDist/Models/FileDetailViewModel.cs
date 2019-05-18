
using System.Collections.Generic;

namespace ColSoftDist.Models
{
    public class FileDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string About { get; set; }

        public List<string> Posts { get; set; }
    }
}
