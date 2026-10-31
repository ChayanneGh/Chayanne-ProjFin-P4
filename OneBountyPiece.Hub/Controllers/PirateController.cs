using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PirateController(PirateSrv pirateSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PirateMdl pirate)
        {
            await pirateSrv.Create(pirate);
            return Ok();
        }

        [HttpPut("{int}")]
        public async Task<IActionResult> Put(int Id, [FromBody] PirateMdl pirate)
        {
            if (Id != pirate.IdPirate)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await pirateSrv.Update(pirate);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await pirateSrv.Read();
            return Ok(List);
        }

        [HttpGet("{int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            PirateMdl pirate = await pirateSrv.ReadOne(Id);

            if (pirate == null)
            {
                return NotFound("Direccion no encontrada");
            }
            return Ok(pirate);
        }

        [HttpDelete("{int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await pirateSrv.Delete(Id);
            return Ok();
        }
    }
}
