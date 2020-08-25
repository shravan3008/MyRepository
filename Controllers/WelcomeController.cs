using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        public WelcomeMessage _message;
        public WelcomeController(WelcomeMessage message)
        {
            this._message = message;
        }
        public string SayHello() => _message.Message;
    }
}
