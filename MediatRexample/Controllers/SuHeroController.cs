using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroConnection.JsonResponses;
using SuperHeroConnection.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRexample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuHeroController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SuHeroController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<HeroStats> GetHero([FromRoute] HeroById request)
        {
            return await _mediator.Send(request);
        }

    }
}
