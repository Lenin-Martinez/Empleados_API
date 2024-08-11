using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado.Entities.Models;

namespace Empleado.DAL.Interfaces
{
    public interface IEmpleadoRepository
    {
        public Task<List<EmpleadoM>> GetEmpleadosAsync();
        public Task<EmpleadoM> GetEmpleadoByIdAsync(int id);
        public Task<EmpleadoM> UpdateEmpleadoAsync(EmpleadoM empleado);
    }
}
