using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empleado.Entities.DTO
{
    public class EmpleadoDto
    {
        public int Codigo { get; set; }


        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener minimo 2 y maximo 100 caracteres")]
        [Required(ErrorMessage = "El nombre del empleado es obligatorio")]
        public required string NombreEmpleado { get; set; } = string.Empty;


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public required DateTime FechaNacimientoEmpleado { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de contratacion es obligatoria")]
        public required DateTime FechaContratacionEmpleado { get; set; }


        public required int DepartamentoIdEmpleado { get; set; }


        [Range(1, 1000000, ErrorMessage = "El precio debe ser un valor positivo mayor a 1")]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "El salario del empleado es obligatorio")]
        public required decimal SalarioEmpleado { get; set; }


        public required string? DescripcionEmpleado { get; set; } = string.Empty;
    }
}
