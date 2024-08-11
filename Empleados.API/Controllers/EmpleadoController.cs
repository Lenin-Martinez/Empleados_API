using Empleado.BL.Interfaces;
using Empleado.Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Net;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Empleados.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService service;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>

        public EmpleadoController(IEmpleadoService service)
        {
            this.service = service;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<EmpleadoDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<EmpleadoDto> result = (IEnumerable<EmpleadoDto>)await this.service.GetEmpleadosAsync();
            return (result != null && result.Any()) ? (IActionResult)this.Ok(result) : (IActionResult)this.NoContent();
        }



        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EmpleadoDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Get(int id)
        {
            EmpleadoDto obj = (EmpleadoDto)await this.service.GetEmpleadosByIdAsync(id);
            return (obj != null) ? (IActionResult)this.Ok(obj) : (IActionResult)this.NoContent();
        }


        //// POST api/<EmpleadoController>
        //[HttpPost]
        //[ProducesResponseType(typeof(int), (int)HttpStatusCode.Created)]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //public async Task<IActionResult> Post(EmpleadoDto model)
        //{
            //if (model == null)
            //{
            //    return (IActionResult)this.BadRequest();
            //}
            //int result = await this.service.InsertEmpleadoAsync(model);
            //return (result > 0) ? (IActionResult)this.CreatedAtAction("Post", result) : (IActionResult)this.BadRequest();
        //}


        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(EmpleadoDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put(int id, EmpleadoDto model)
        {
            if (model == null)
            {
                return (IActionResult)this.BadRequest();
            }
            EmpleadoDto result = await this.service.UpdateEmpleadoAsync(model);
            return (result != null) ? (IActionResult)this.Ok(result) : (IActionResult)this.BadRequest();
        }


        //// DELETE api/<EmpleadoController>/5
        //[HttpDelete("{id}")]
        //[ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    bool result = await this.service.DeleteAutorAsync(id);
        //    return (result) ? (IActionResult)this.Ok(result) : (IActionResult)this.BadRequest(result);
        //}





        //================= Elementos originales =================================================

        //// GET: api/<EmpleadoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<EmpleadoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<EmpleadoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EmpleadoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EmpleadoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
