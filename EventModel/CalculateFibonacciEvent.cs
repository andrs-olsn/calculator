using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

namespace EventModel
{
    public class CalculateFibonacciEvent : IntegrationEvent
    {
        public int N { get; }

        public CalculateFibonacciEvent(int n)
        {
            N = n;
        }
    }
}
