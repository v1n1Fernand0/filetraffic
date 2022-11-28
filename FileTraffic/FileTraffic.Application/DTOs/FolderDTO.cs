using FileTraffic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Application.DTOs
{
    public class FolderDTO:Entity
    {
        [Required(ErrorMessage = "The Name is Required")]
        public string? Name { get; set; }
        public string Key { get; set; }


    }
}
