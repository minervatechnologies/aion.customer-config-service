using System;
using Aion.CustomerConfigService.Application.Commands;

namespace Aion.CustomerConfigService.Application.Handlers
{
	public interface ICommandHandler<TCommand> where TCommand : ICommand
	{
		Task Handle(TCommand command);
	}
}

