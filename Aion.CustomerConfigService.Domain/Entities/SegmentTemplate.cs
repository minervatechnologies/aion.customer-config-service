﻿using System;
using Aion.CustomerConfigService.Domain.Enums;

namespace Aion.CustomerConfigService.Domain.Entities;

public class SegmentTemplate
{
	public SegmentTemplate()
	{
	}

    public string Channel { get; set; }
    public string Name { get; set; }
	public LoanBroker LoanBroker { get; set; }
}