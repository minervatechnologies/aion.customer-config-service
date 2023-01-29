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
    public class SegmentTemplateController : ControllerBase
    {
        private readonly IQueryHandler<GetAllSegmentTemplateQuery, IReadOnlyList<SegmentTemplate>> getAllQuery;
        private readonly IQueryHandler<GetSegmentTemplateQuery, SegmentTemplate> getSingle;

        public SegmentTemplateController(
            IQueryHandler<GetAllSegmentTemplateQuery, IReadOnlyList<SegmentTemplate>> getAllQuery,
            IQueryHandler<GetSegmentTemplateQuery, SegmentTemplate> getSingle)
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
                .Select(s => new SegmentTemplateResponse(s.Channel, s.Yield))
                .ToList();

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var template = await getSingle.Execute(new GetSegmentTemplateQuery(id));
            if (template is null)
                return NotFound();

            var response = new SegmentTemplateResponse(template.Channel, template.Yield);

            return Ok(response);
        }
    }
}