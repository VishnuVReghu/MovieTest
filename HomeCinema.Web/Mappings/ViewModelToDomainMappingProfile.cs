﻿using AutoMapper;
using HomeCinema.Entities;
using HomeCinema.Web.Models;

namespace HomeCinema.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<MovieViewModel, Movie>();
        }
    }
}