using Service.Contracts;
using Shared.DataTransferObjects;
using HamsterWarsV2API.Presentation;
using Microsoft.AspNetCore.Mvc;
using HamsterWarsV2API.Presentation.ActionFilters;
using Shared.RequestFeatures;

[Route("api/hamsters")]
[ApiController]
public class HamstersController : ControllerBase
{
    private readonly IServiceManager _service;

    public HamstersController(IServiceManager service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetHamsters([FromQuery] HamsterParameters hamsterParameters)
    {
        var hamsters = await _service.HamsterService.GetAllHamstersAsync(hamsterParameters, trackChanges: false);
        return Ok(hamsters);
    }

    [HttpGet("{id:guid}", Name = "HamsterById")]
    public async Task<IActionResult> GetHamster(Guid id)
    {
        var hamster = await _service.HamsterService.GetHamsterAsync(id, trackChanges: false);
        return Ok(hamster);
    }

    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> CreateHamster([FromBody] HamsterForCreationDto hamster)
    {
        var createdHamster = await _service.HamsterService.CreateHamsterAsync(hamster);
        return CreatedAtRoute("HamsterById", new { id = createdHamster.Id }, createdHamster);
    }

    [HttpGet("collection/({ids})", Name = "HamsterCollection")]
    public async Task<IActionResult> GetHamsterCollection
    ([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
    {
        var hamsters = await _service.HamsterService.GetByIdsAsync(ids, trackChanges: false);
        return Ok(hamsters);
    }

    [HttpPost("collection")]
    public async Task<IActionResult> CreateHamsterCollection
    ([FromBody] IEnumerable<HamsterForCreationDto> hamsterCollection)
    {
        var result = await _service.HamsterService.CreateHamsterCollectionAsync(hamsterCollection);
        return CreatedAtRoute("HamsterCollection", new { result.ids }, result.hamsters);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteHamster(Guid id)
    {
        await _service.HamsterService.DeleteHamsterAsync(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> UpdateHamster(Guid id, [FromBody] HamsterForUpdateDto hamster)
    {
        await _service.HamsterService.UpdateHamsterAsync(id, hamster, trackChanges: true);
        return NoContent();
    }

    [HttpGet("random")]
    public async Task<IActionResult> GetRandomHamster([FromQuery] HamsterParameters hamsterParameters)
    {
        var hamster = await _service.HamsterService.GetRandomHamsterAsync(hamsterParameters, trackChanges: false);
        return Ok(hamster);
    }

    [HttpGet("winners")]
    public async Task<IActionResult> GetWinnerHamsters([FromQuery] HamsterParameters hamsterParameters)
    {
        var hamster = await _service.HamsterService.GetWinnerHamstersAsync(hamsterParameters, trackChanges: false);
        return Ok(hamster);
    }

    [HttpGet("losers")]
    public async Task<IActionResult> GetLoserHamsters([FromQuery] HamsterParameters hamsterParameters)
    {
        var hamster = await _service.HamsterService.GetLoserHamstersAsync(hamsterParameters, trackChanges: false);
        return Ok(hamster);
    }
}
