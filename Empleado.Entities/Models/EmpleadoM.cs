using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Empleado.Entities.Models
{
    public class EmpleadoM
    {
        [Key]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required DateTime FechaNacimiento { get; set; }
        public required DateTime FechaContratacion { get; set; }
        public required int DepartamentoId { get; set; }
        public required decimal Salario { get; set; }
        public required string? Descripcion { get; set; }
    }
}
