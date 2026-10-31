using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipController(ShipSrv shipSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShipMdl ship)
        {
            await shipSrv.Create(ship);
            return Ok();
        }

        [HttpPut("{int}")]
        public async Task<IActionResult> Put(int Id, [FromBody] ShipMdl ship)
        {
            if (Id != ship.IdShip)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await shipSrv.Update(ship);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await shipSrv.Read();
            return Ok(List);
        }

        [HttpGet("{int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            ShipMdl ship = await shipSrv.ReadOne(Id);

            if (ship == null)
            {
                return NotFound("Direccion no encontrada");
            }
            return Ok(ship);
        }

        [HttpDelete("{int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await shipSrv.Delete(Id);
            return Ok();
        }
    }
}
