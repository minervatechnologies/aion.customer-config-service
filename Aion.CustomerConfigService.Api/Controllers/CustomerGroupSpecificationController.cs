using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aion.CustomerConfigService.Api.Contracts.Responses;
using Aion.CustomerConfigService.Application.Queries;
using Aion.CustomerConfigService.Application.Queries.Handlers;
using Aion.CustomerConfigService.Domain.Entities;
using Aion.CustomerConfigService.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aion.CustomerConfigService.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerGroupSpecificationController : ControllerBase
    {
        private readonly IQueryHandler<GetCustomerGroupSpecificationQuery, (decimal Yield, decimal Roe)> getSpecification;

        public CustomerGroupSpecificationController(IQueryHandler<GetCustomerGroupSpecificationQuery, (decimal Yield, decimal Roe)> getSpecification)
        {
            this.getSpecification = getSpecification;
        }

        [Route("/loanbroker")]
        public async Task<IActionResult> GetByLoanBroker(LoanBrokerType loanBroker)
        {
            // get customer id from token
            try
            {
                var customerGroupSpecfication = await getSpecification.Execute(new GetCustomerGroupSpecificationQuery(Guid.NewGuid(), loanBroker));
                return Ok(new CustomerGroupSpecificationResponse(customerGroupSpecfication.Yield, customerGroupSpecfication.Roe));
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
        }
    }
}