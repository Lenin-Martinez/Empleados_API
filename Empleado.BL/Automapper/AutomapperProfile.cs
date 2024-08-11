using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Empleado.Entities.DTO;
using Empleado.Entities.Models;

namespace Empleado.BL.Automapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile() 
        {
            CreateMap<EmpleadoM, EmpleadoDto>()
                .ForMember(destination => destination.Codigo, options => options.MapFrom(source => source.Id))
                .ForMember(destination => destination.NombreEmpleado, options => options.MapFrom(source => source.Nombre))
                .ForMember(destination => destination.FechaNacimientoEmpleado, options => options.MapFrom(source => source.FechaNacimiento))
                .ForMember(destination => destination.FechaContratacionEmpleado, options => options.MapFrom(source => source.FechaContratacion))
                .ForMember(destination => destination.DepartamentoIdEmpleado, options => options.MapFrom(source => source.DepartamentoId))
                .ForMember(destination => destination.SalarioEmpleado, options => options.MapFrom(source => source.Salario))
                .ForMember(destination => destination.DescripcionEmpleado, options => options.MapFrom(source => source.Descripcion))
                .ReverseMap();
        }
    }
}
