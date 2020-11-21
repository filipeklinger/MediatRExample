using MediatR;
using MediatRexample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static MediatRexample.Data.ContractContext;

namespace MediatRexample.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<Contact> GetContact([FromRoute]Query query)
        {
            return await _mediator.Send(query);
        }

        #region Nested Classes
        public class Query : IRequest<Contact>
        {
            public int Id { get; set; }
        }

        public class ContractHandler : IRequestHandler<Query, Contact>
        {
            private ContractContext db;

            public ContractHandler(ContractContext db) => this.db = db;

            public Task<Contact> Handle(Query request, CancellationToken cancellationToken)
            {
                return this.db.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
            }
        }
        #endregion
    }
}
