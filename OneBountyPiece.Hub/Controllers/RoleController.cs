using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController(RoleSrv roleSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleMdl role)
        {
            await roleSrv.Create(role);
            return Ok();
        }

        [HttpPut("{int}")]
        public async Task<IActionResult> Put(int Id, [FromBody] RoleMdl role)
        {
            if (Id != role.IdRole)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await roleSrv.Update(role);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await roleSrv.Read();
            return Ok(List);
        }

        [HttpGet("{int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            RoleMdl role = await roleSrv.ReadOne(Id);

            if (role == null)
            {
                return NotFound("Rol no encontrado");
            }
            return Ok(role);
        }

        [HttpDelete("{int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await roleSrv.Delete(Id);
            return Ok();
        }
    }
}
