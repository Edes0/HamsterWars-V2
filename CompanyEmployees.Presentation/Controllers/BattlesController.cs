using Service.Contracts;
using Shared.DataTransferObjects;
using HamsterWarsV2API.Presentation;
using Microsoft.AspNetCore.Mvc;
using HamsterWarsV2API.Presentation.ActionFilters;
using Shared.RequestFeatures;

[Route("api/battles")]
[ApiController]
public class BattlesController : ControllerBase
{
    private readonly IServiceManager _service;

    public BattlesController(IServiceManager service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetBattles([FromQuery] BattleParameters battleParameters)
    {
        var battles = await _service.BattleService.GetAllBattlesAsync(battleParameters, trackChanges: false);

        return Ok(battles);
    }

    [HttpGet("{id:guid}", Name = "BattleById")]
    public async Task<IActionResult> GetBattle(Guid id)
    {
        var battle = await _service.BattleService.GetBattleAsync(id, trackChanges: false);
        return Ok(battle);
    }

    [HttpPost]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> CreateBattle([FromBody] BattleForCreationDto battle)
    {
        var createdBattle = await _service.BattleService.CreateBattleAsync(battle);
        return CreatedAtRoute("BattleById", new { id = createdBattle.Id }, createdBattle);
    }

    [HttpGet("collection/({ids})", Name = "BattleCollection")]
    public async Task<IActionResult> GetBattleCollection
    ([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
    {
        var battles = await _service.BattleService.GetByIdsAsync(ids, trackChanges: false);
        return Ok(battles);
    }

    [HttpPost("collection")]
    public async Task<IActionResult> CreateBattleCollection
    ([FromBody] IEnumerable<BattleForCreationDto> battleCollection)
    {
        var result = await _service.BattleService.CreateBattleCollectionAsync(battleCollection);
        return CreatedAtRoute("BattleCollection", new { result.ids }, result.battles);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteBattle(Guid id)
    {
        await _service.BattleService.DeleteBattleAsync(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public async Task<IActionResult> UpdateBattle(Guid id, [FromBody] BattleForUpdateDto battle)
    {
        await _service.BattleService.UpdateBattleAsync(id, battle, trackChanges: true);
        return NoContent();
    }

    [HttpGet("matchWinners/{id:guid}")]
    public async Task<IActionResult> GetMatchWinner(Guid id, [FromQuery] BattleParameters battleParameters)
    {
        var matchWinners = await _service.BattleService.GetMatchWinnersAsync(id, battleParameters, trackChanges: false);

        return Ok(matchWinners);
    }
}
