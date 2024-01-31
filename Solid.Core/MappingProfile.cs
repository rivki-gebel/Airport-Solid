﻿using AirPort_API.Entities;
using AutoMapper;
using Solid.Core.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<PassangerDto, Passanger>().ReverseMap();
            CreateMap<FlightDto, Flight>().ReverseMap();
            CreateMap<FlightToPassangerDto, Flight>().ReverseMap();
        }
    }
}
