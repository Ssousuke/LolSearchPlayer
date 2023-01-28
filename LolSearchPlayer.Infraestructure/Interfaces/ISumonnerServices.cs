using LolSearchPlayer.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolSearchPlayer.Infraestructure.Interfaces
{
    public interface ISumonnerServices
    {
        Task<SummonerDto> GetSummoner(string name);
    }
}
