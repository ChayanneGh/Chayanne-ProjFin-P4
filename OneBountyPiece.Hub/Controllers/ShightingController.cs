using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers;

public class ShightingController(ShightingsSrv shightingsSrv) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ShightingMdl shighting)
    {
        await shightingsSrv.Create(shighting);
        return Ok();
    }

    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(int Id, [FromBody] ShightingMdl shighting)
    {
        if (Id != shighting.IdShighting)
        {
            return BadRequest("Los IDs proporcionados no Coinciden");
        }

        await shightingsSrv.Update(shighting);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var List = await shightingsSrv.Read();
        return Ok(List);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById(int Id)
    {
        ShightingMdl shighting = await shightingsSrv.ReadOne(Id);

        if (shighting == null)
        {
            return NotFound("Reporte no encontrado");
        }
        return Ok(shighting);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(int Id)
    {
        await shightingsSrv.Delete(Id);
        return Ok();
    }
}
