﻿
namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class RankController : ApiControllerBase
{
    private readonly IRankService _rankService;

    public RankController(IRankService rankService)
    {
        _rankService = rankService;
    }

    [HttpGet("GetRanks")]
    public async Task<ActionResult<List<RankListDto>>> GetAllRankAsync()
    {
        return Ok(await _rankService.GetAllAsync());
    }

    [HttpGet("GetRankByUser/{userId:int}")]
    public async Task<ActionResult<RankListDto>> GetRankByUserAsync(int userId)
    {
        return Ok(await _rankService.GetByUserIdAsync(userId));
    }

}
