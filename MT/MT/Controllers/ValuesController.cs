using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace MT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBus _bus;

        public ValuesController(IBus bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public async Task Get()
        {
            Log.Information("Test");
            await _bus.Send(new TestEvent
            {
                Text = "TestMsg"
            });
        }
    }
}
