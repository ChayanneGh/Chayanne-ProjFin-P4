using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemUserController(SystemUserSrv systemUserSrv) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SystemUserMdl systemUser)
        {
            await systemUserSrv.Create(systemUser);
            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(int Id, [FromBody] SystemUserMdl systemUser)
        {
            if (Id != systemUser.IdSystemUser)
            {
                return BadRequest("Los IDs proporcionados no Coinciden");
            }

            await systemUserSrv.Update(systemUser);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var List = await systemUserSrv.Read();
            return Ok(List);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            SystemUserMdl systemUser = await systemUserSrv.ReadOne(Id);

            if (systemUser == null)
            {
                return NotFound("Usuario no encontrado");
            }
            return Ok(systemUser);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await systemUserSrv.Delete(Id);
            return Ok();
        }
    }
}
