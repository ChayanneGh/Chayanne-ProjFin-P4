using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolePermissionController(RolePermissionSrv RolePermissionSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RolePermissionMdl rolePermission)
        {
            await RolePermissionSrv.Create(rolePermission);
            return Ok();
        }

        [HttpPut("{int}")]
        public async Task<IActionResult> Put(int Id, [FromBody] RolePermissionMdl rolePermission)
        {
            if (Id != rolePermission.IdRolePermission)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await RolePermissionSrv.Update(rolePermission);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await RolePermissionSrv.Read();
            return Ok(List);
        }

        [HttpGet("{int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            RolePermissionMdl rolePermission = await RolePermissionSrv.ReadOne(Id);

            if (rolePermission == null)
            {
                return NotFound("Direccion no encontrada");
            }
            return Ok(rolePermission);
        }

        [HttpDelete("{int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await RolePermissionSrv.Delete(Id);
            return Ok();
        }
    }
}
