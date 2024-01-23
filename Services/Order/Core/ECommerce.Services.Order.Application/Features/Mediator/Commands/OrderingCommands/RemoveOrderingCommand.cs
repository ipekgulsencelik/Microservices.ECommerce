﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands
{
	public class RemoveOrderingCommand : IRequest
	{
		public RemoveOrderingCommand(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
