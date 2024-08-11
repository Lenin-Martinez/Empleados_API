using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado.DAL.Interfaces;
using Empleado.Entities.Models;
using Dapper;


namespace Empleado.DAL
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public EmpleadoRepository(IDatabaseRepository databaseRepository)
        {
            this.databaseRepository = databaseRepository;
        }


       public async  Task<List<EmpleadoM>> GetEmpleadosAsync()
        {
            string query = "SELECT * FROM Empleados";
            return await databaseRepository.GetDataByQueryAsync<EmpleadoM>(query);
        }

        public async Task<EmpleadoM> GetEmpleadoByIdAsync(int id)
        {
            string query = "SELECT * FROM Empleados WHERE Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return (await databaseRepository.GetDataByQueryAsync<EmpleadoM>(query, parameters)).FirstOrDefault();
        }


        public async Task<EmpleadoM> UpdateEmpleadoAsync(EmpleadoM empleado)
        {
            string query = "UPDATE Empleados SET Salario = @Salario WHERE Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", empleado.Id);
            parameters.Add("@Salario", empleado.Salario);
            await databaseRepository.Update<EmpleadoM>(query, parameters);
            return empleado;
        }
    }
}
