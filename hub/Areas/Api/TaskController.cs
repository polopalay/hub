using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Signal.Signal;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Signal.Areas.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public IHubContext<TaskHub> _hubContext { get; set; }
        public TaskController(IHubContext<TaskHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public IActionResult Get()
        {
            Guid guid = Guid.NewGuid();
            _ = Handler(guid);
            return Ok(guid.ToString());
        }
        private async Task Handler(Guid id)
        {
            await Task.Delay(2000);
            await _hubContext.Clients.All.SendAsync(id.ToString(), "demo");
        }
    }
}
