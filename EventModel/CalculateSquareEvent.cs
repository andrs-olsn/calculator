using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

namespace EventModel
{
    public class CalculateSquareEvent : IntegrationEvent
    {
        public int N { get; }

        public CalculateSquareEvent(int n)
        {
            N = n;
        }
    }
}
