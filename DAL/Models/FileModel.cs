﻿using System.Collections.Generic;

namespace DAL.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public string About { get; set; } 
        public virtual IEnumerable<Role> Roles { get; set; }
    }
}