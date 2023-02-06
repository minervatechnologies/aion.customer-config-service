using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aion.CustomerConfigService.Api.Contracts.Responses;
using Aion.CustomerConfigService.Application.Queries;
using Aion.CustomerConfigService.Application.Queries.Handlers;
using Aion.CustomerConfigService.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aion.CustomerConfigService.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerGroupTemplateController : ControllerBase
    {
        private readonly IQueryHandler<GetAllSegmentTemplateQuery, IReadOnlyList<CustomerGroupTemplate>> getAllQuery;
        private readonly IQueryHandler<GetGroupTemplateQuery, CustomerGroupTemplate> getSingle;

        public CustomerGroupTemplateController(
            IQueryHandler<GetAllSegmentTemplateQuery, IReadOnlyList<CustomerGroupTemplate>> getAllQuery,
            IQueryHandler<GetGroupTemplateQuery, CustomerGroupTemplate> getSingle)
        {
            this.getAllQuery = getAllQuery;
            this.getSingle = getSingle;
        }


        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            var templates = await getAllQuery.Execute(new GetAllSegmentTemplateQuery());
            if (templates is null || !templates.Any())
                return NotFound();

            var response = templates
                .Select(s => new CustomerGroupTemplateResponse(s.Channel, s.LoanBroker.Title, s.Name))
                .ToList();

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var template = await getSingle.Execute(new GetGroupTemplateQuery(id));
            if (template is null)
                return NotFound();

            var response = new CustomerGroupTemplateResponse(template.Channel, template.LoanBroker.Title, template.Name);

            return Ok(response);
        }
    }
}