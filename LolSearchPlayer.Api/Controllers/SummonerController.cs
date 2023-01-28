using LolSearchPlayer.Dto.Dto;
using LolSearchPlayer.Infraestructure.Interfaces;
using LolSearchPlayer.Infraestructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LolSearchPlayer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummonerController : ControllerBase
    {
        private ISumonnerServices _services;
        public SummonerController(ISumonnerServices services)
        {
            _services = services;
        }

        [HttpGet("buscar/{name}")]
        public async Task<ActionResult<SummonerDto>> Get(string name)
        {
            var summoner = await _services.GetSummoner(name);
            return summoner;
        }
    }
}
