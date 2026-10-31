using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CrewController(CrewSrv crewSrv) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CrewMdl crew)
    {
        await crewSrv.Create(crew);
        return Ok();
    }

    [HttpPut("{int}")]
    public async Task<IActionResult> Put(int Id, [FromBody] CrewMdl crew)
    {
        if (Id != crew.IdCrew)
        {
            return BadRequest("Los IDs proporcionados no Coinciden");
        }

        await crewSrv.Update(crew);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var List = await crewSrv.Read();
        return Ok(List);
    }

    [HttpGet("{int}")]
    public async Task<IActionResult> GetById(int Id)
    {
        CrewMdl crew = await crewSrv.ReadOne(Id);

        if (crew == null)
        {
            return NotFound("Direccion no encontrada");
        }
        return Ok(crew);
    }

    [HttpDelete("{int}")]
    public async Task<IActionResult> Delete(int Id)
    {
        await crewSrv.Delete(Id);
        return Ok();
    }
}
