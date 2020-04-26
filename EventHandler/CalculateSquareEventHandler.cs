using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EventModel;
using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;

namespace EventHandler
{
    public class CalculateSquareEventHandler : IIntegrationEventHandler<CalculateSquareEvent>
    {
        public Task Handle(CalculateSquareEvent @event)
        {
            var task = new Task<int>(() => Square(@event.N));
            task.Start();
            return task;
        }

        private static int Square(int n)
        {
            return n*n;
        }
    }
}
