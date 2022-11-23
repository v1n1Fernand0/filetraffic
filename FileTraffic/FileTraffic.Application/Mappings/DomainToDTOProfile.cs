using AutoMapper;
using FileTraffic.Application.DTOs;
using FileTraffic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Application.Mappings
{
    public class DomainToDTOProfile:Profile
    {
        public DomainToDTOProfile()
        {
            CreateMap<Archive, ArchiveDTO>();
            CreateMap<SystemReference, SystemReferenceDTO>();
        }
    }
}
