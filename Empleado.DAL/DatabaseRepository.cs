using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado.Common;
using Empleado.DAL.Interfaces;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Collections;

namespace Empleado.DAL
{
    public class DatabaseRepository: IDatabaseRepository
    {
        private readonly string connectionString;

        public DatabaseRepository(IOptions<AppSettings> appSettings)
        {
            connectionString = appSettings.Value.ConnectionString;
        }

        public async Task<List<T>> GetDataByQueryAsync<T>(string query, DynamicParameters? parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<T>(query, parameters);
                    connection.Close();
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en GetDataByQuery : " + ex.Message);
            }
        }

        public async Task<T?> Update<T>(string query, DynamicParameters? parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<T>(query, parameters);
                    connection.Close();
                    if(result != null && result.Any())
                    {
                        return result.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en GetDataByQuery : " + ex.Message);
            }
            return default;
        }
    }
}
