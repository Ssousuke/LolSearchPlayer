using LolSearchPlayer.Infraestructure.Interfaces;
using LolSearchPlayer.Infraestructure.Rest;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolSearchPlayer.Infraestructure.DependencyInjection
{
    public static class DependencyInjectionApi
    {
        public static IServiceCollection AddInfraestrureDependencyInjection(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<ISumonnerServices, SummonerRestApi>();

            return services;
        }
    }
}
