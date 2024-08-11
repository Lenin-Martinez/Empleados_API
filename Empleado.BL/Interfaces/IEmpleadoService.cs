using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado.Entities.DTO;

namespace Empleado.BL.Interfaces
{
    public interface IEmpleadoService
    {
        public Task<List<EmpleadoDto>> GetEmpleadosAsync();
        public Task<EmpleadoDto> GetEmpleadosByIdAsync(int id);
        public Task<EmpleadoDto> UpdateEmpleadoAsync(EmpleadoDto empleado);
    }
}
