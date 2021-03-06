﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly2.Dtos;
using Vidly2.Models;

namespace Vidly2.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<GenreType, GenreTypeDto>();



            Mapper.CreateMap<CustomerDto, Customer>().
                ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().
                ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<NewRentalDto, Rental>().
                ForMember(r => r.Id, opt => opt.Ignore());


        }
    }
}