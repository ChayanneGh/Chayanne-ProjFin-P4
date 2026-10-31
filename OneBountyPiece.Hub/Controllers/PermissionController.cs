using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController(PermissionSrv permissionSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PermissionMdl permission)
        {
            await permissionSrv.Create(permission);
            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(int Id, [FromBody] PermissionMdl permission)
        {
            if (Id != permission.IdPermission)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await permissionSrv.Update(permission);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await permissionSrv.Read();
            return Ok(List);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            PermissionMdl permission = await permissionSrv.ReadOne(Id);

            if (permission == null)
            {
                return NotFound("Direccion no encontrada");
            }
            return Ok(permission);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await permissionSrv.Delete(Id);
            return Ok();
        }
    }
}
