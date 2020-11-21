using MediatR;
using SuperHeroConnection.JsonResponses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperHeroConnection.Requests
{
    public class HeroById : IRequest<HeroStats>
    {
        public int Id { get; set; }

        public class ContractHandler : IRequestHandler<HeroById, HeroStats>
        {
            public async Task<HeroStats> Handle(HeroById request, CancellationToken cancellationToken)
            {
                HeroStats heroStats;
                using (var client = new HttpClient())
                {
                    var token = "tokenKey";
                    var result = await client.GetAsync($"https://superheroapi.com/api/{token}/"+request.Id);
                    Console.WriteLine(result.StatusCode);
                    var response = await result.Content.ReadAsStringAsync();
                    heroStats = HeroStats.FromJson(response);
                }

                return heroStats;
            }
        }
    }
}
