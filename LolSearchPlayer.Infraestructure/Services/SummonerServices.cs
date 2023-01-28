using LolSearchPlayer.Dto.Dto;
using LolSearchPlayer.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolSearchPlayer.Infraestructure.Services
{
    public class SummonerServices : ISumonnerServices
    {
        private ISumonnerServices _services;
        public SummonerServices(ISumonnerServices services)
        {
            _services = services;
        }
        public async Task<SummonerDto> GetSummoner(string name)
        {
            var summoner = await _services.GetSummoner(name);
            return summoner;
        }
    }
}
