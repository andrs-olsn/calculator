using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
using Microsoft.Extensions.Logging;

namespace CalculatorService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly IEventBus _eventBus;

        public CalculatorController(ILogger<CalculatorController> logger, IEventBus eventBus)
        {
            _logger = logger;
            _eventBus = eventBus;
        }

        [HttpGet]
        public Result Get(int n)
        {
            int fib = 0;
            int square = 0;

            _eventBus.Publish(new CalculateFibonacciEvent(n));
            _eventBus.Publish(new CalculateSquareEvent(n));

            //ToDo: Hvordan læses resultatet. Måske noget med?
            //var fib = _eventBus.Publish<int>(new CalculateFibonacciEvent(n));
            //var square = _eventBus.Publish<int>(new CalculateSquareEvent(n));

            return new Result
            {
                FibonacciResult = fib,
                SquareResult = square
            };
        }
    }
}
