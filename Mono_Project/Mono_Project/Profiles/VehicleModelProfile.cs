﻿using AutoMapper;
using Mono_Project.Models;
using Project.Model.Model;


namespace Mono_Project.Profiles
{
    public class VehicleModelProfile : Profile
    {
        public VehicleModelProfile()
        {
            CreateMap<VehicleModel, VehicleModelViewModel>()
                .ReverseMap();
        }
    }
}
