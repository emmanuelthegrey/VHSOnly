using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VHSOnly.DTOs;
using VHSOnly.Models;

namespace VHSOnly.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();



            Mapper.CreateMap<CustomerDTO, Customer>();
            Mapper.CreateMap<MovieDTO, Movie>();
        }
    }
}