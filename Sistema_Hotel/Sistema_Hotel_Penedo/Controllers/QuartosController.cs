using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sistema_Hotel_Penedo.Models;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Hotel_Penedo.Controllers
{
    [Route("api/quartos")]
    public class QuartosController : ControllerBase
    {
        //api/quartos
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        //api/quartos/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CadastrarQuartoModel cadastrarQuarto)
        {
            if(cadastrarQuarto.QuantidadeHospedes < 1)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = cadastrarQuarto.Id }, cadastrarQuarto);
        }

        //api/quartos/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  )
        {
            return Ok();
        }
    }
}
