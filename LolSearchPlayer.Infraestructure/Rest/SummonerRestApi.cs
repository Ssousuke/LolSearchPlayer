using LolSearchPlayer.Dto.Dto;
using LolSearchPlayer.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LolSearchPlayer.Infraestructure.Rest
{
    public class SummonerRestApi : ISumonnerServices
    {
        public async Task<SummonerDto> GetSummoner(string name)
        {
            SummonerDto requestLol = new SummonerDto();

            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri($"https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}");
            request.Headers.Add("Accept-Language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36");
            //quest.Headers.Add("Accept-Charset", "application/x-www-form-urlencoded; charset=UTF-8");
            request.Headers.Add("Origin", "https://developer.riotgames.com");
            request.Headers.Add("X-Riot-Token", "");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.SendAsync(request);
                string contentResponse = await response.Content.ReadAsStringAsync();
                SummonerDto? json = JsonSerializer.Deserialize<SummonerDto>(contentResponse);



                if (response.IsSuccessStatusCode)
                {
                    requestLol = json;
                }
            }

            return requestLol;
        }
    }
}
