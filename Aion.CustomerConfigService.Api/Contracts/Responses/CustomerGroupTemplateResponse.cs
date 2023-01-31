using System;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Api.Contracts.Responses;

public record CustomerGroupTemplateResponse(string Channel, LoanBroker LoanBroker, string Name);

