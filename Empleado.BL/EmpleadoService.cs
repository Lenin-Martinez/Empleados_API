using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Empleado.BL.Interfaces;
using Empleado.DAL.Interfaces;
using Empleado.Entities.DTO;
using Empleado.Entities.Models;

namespace Empleado.BL
{
    public class EmpleadoService: IEmpleadoService
    {
        private readonly IEmpleadoRepository repository;
        private readonly IMapper mapper;

        public EmpleadoService(IEmpleadoRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<EmpleadoDto>> GetEmpleadosAsync()
        {
            try
            {
                var result = await repository.GetEmpleadosAsync();
                return mapper.Map<List<EmpleadoM>, List<EmpleadoDto>>(result);
            }
            catch (Exception ex)
            {
                return new List<EmpleadoDto>();
            }
        }

        public async Task<EmpleadoDto> GetEmpleadosByIdAsync(int id)
        {
            try
            {
                var result = await repository.GetEmpleadoByIdAsync(id);
                return mapper.Map<EmpleadoM, EmpleadoDto>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<EmpleadoDto> UpdateEmpleadoAsync(EmpleadoDto empleado)
        {
            try
            {
                var entity = mapper.Map<EmpleadoDto, EmpleadoM>(empleado);
                var result = await repository.UpdateEmpleadoAsync(entity);
                return mapper.Map<EmpleadoM, EmpleadoDto>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
