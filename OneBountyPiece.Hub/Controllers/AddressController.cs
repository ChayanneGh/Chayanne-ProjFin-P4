using Microsoft.AspNetCore.Mvc;
using OneBountyPiece.Hub.Service;
using OneBountyPiece.Shared.Entities;

namespace OneBountyPiece.Hub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController(AddressSrv addressSrv) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AddressMdl address)
    {
        await addressSrv.Create(address);
        return Ok();
    }

    [HttpPut("{int}")]
    public async Task<IActionResult> Put(int Id, [FromBody] AddressMdl address)
    {
        if (Id != address.IdAddress)
        {
            return BadRequest("Los IDs proporcionados no Coinciden");
        }

        await addressSrv.Update(address);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var List = await addressSrv.Read();
        return Ok(List);
    }

    [HttpGet("{int}")]
    public async Task<IActionResult> GetById(int Id)
    {
        AddressMdl address = await addressSrv.ReadOne(Id);

        if (address == null)
        {
            return NotFound("Direccion no encontrada");
        }
        return Ok(address);
    }

    [HttpDelete("{int}")]
    public async Task<IActionResult> Delete(int Id)
    {
        await addressSrv.Delete(Id);
        return Ok();
    }
}
