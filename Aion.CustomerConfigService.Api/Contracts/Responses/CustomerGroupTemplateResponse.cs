using System;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Api.Contracts.Responses;

public record CustomerGroupTemplateResponse(string Channel, LoanBrokerType LoanBroker, string Name);

