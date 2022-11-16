using Microsoft.AspNetCore.Mvc;
using transporte_datos;
using transporte_datos.facade;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace transporte_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamionController : ControllerBase
    {
        private IdataApi datosApi;

        public CamionController(abstractDataApiFactory  factory)
        {
           
            datosApi = factory.crearDataApi();
        }

        // GET: api/<CamionController>
        [HttpGet("/camion")]
        public IActionResult GetCamion()
        {
            List<camion> lst = null;
            try
            {

                lst = datosApi.GetCamion();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        // POST api/<CamionController>
        [HttpPost("/transporte")]
        public IActionResult PostCamion(camion Ocamion)
        {
            try
            {
                if (Ocamion==null)
                {
                    return BadRequest("Datos de presupuesto incorrectos!");
                }

                return Ok(datosApi.PostCamion(Ocamion));

            }
            catch (Exception)
            {
                return StatusCode(500, "error interno");
            }
        }

        // DELETE api/<CamionController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteLogico(int id)
        {
            if (id == 0)
                return BadRequest("idmal");

            return Ok(datosApi.DeleteLogico(id));
                        
        }
    }
}
