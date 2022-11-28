using FileTraffic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Application.DTOs
{
    public class ArchiveDTO :Entity
    {
        [Required(ErrorMessage = "The Name is Required")]
        public string Name { get; set; }
        public long Size { get; set; }
        public long? FriendlySize { get; set; }
        public string Extension { get; set; }
        public Folder Folder { get; set; }
    }
}
