using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevilFruitController(DevilFruitSrv devilFruitSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DevilFruitMdl devilFruit)
        {
            await devilFruitSrv.Create(devilFruit);
            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(int Id, [FromBody] DevilFruitMdl devilFruit)
        {
            if (Id != devilFruit.IdDevilFruit)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await devilFruitSrv.Update(devilFruit);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await devilFruitSrv.Read();
            return Ok(List);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            DevilFruitMdl devilFruit = await devilFruitSrv.ReadOne(Id);

            if (devilFruit == null)
            {
                return NotFound("Direccion no encontrada");
            }
            return Ok(devilFruit);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await devilFruitSrv.Delete(Id);
            return Ok();
        }
    }
}
