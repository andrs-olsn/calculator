using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EventModel;
using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;

namespace EventHandler
{
    public class CalculateFibonacciEventHandler : IIntegrationEventHandler<CalculateFibonacciEvent>
    {
        public Task Handle(CalculateFibonacciEvent @event)
        {
            var task = new Task(() => Fib(@event.N));
            task.Start();
            return task;
        }

        private static int Fib(int n)
        {
            return n <= 1 ? n : Fib(n - 1) + Fib(n - 2);
        }
    }
}
