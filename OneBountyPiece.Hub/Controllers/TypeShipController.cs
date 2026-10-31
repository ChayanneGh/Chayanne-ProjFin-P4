using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeShipController(TypeShipSrv typeShipSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TypeShipMdl typeShip)
        {
            await typeShipSrv.Create(typeShip);
            return Ok();
        }

        [HttpPut("{int}")]
        public async Task<IActionResult> Put(int Id, [FromBody] TypeShipMdl typeShip)
        {
            if (Id != typeShip.IdTypeShip)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await typeShipSrv.Update(typeShip);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await typeShipSrv.Read();
            return Ok(List);
        }

        [HttpGet("{int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            TypeShipMdl typeShip = await typeShipSrv.ReadOne(Id);

            if (typeShip == null)
            {
                return NotFound("Direccion no encontrada");
            }
            return Ok(typeShip);
        }

        [HttpDelete("{int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await typeShipSrv.Delete(Id);
            return Ok();
        }
    }
}
