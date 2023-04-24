using AutoMapper;
using LenaSoftware.Dto;
using LenaSoftware.Entities.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.Business.Profiles
{
    public class FormProfile : Profile
    {
        public FormProfile()
        {
            CreateMap<FormCreateDto, Form>().ReverseMap();
        }
    }
}
