using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BETRAGATEWAY.Data;
using BETRAGATEWAY.Models;
using Microsoft.Extensions.Logging;

namespace BETRAGATEWAY.Controllers
{
    using TcpStandard_Server;
    [ApiController]
    [Route("[controller]")]
    public class GatesController : ControllerBase
    {
        private readonly BETRAGATEWAYContext _context;
        private readonly ILogger<GatesController> _logger;

        public GatesController(BETRAGATEWAYContext context, ILogger<GatesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost]
        public string GateAction(Gate gate)
        {
            var rng = new Random();
            TcpStandard_Server.StandTcpController.StandTCPControllerManager ControllerManager = new TcpStandard_Server.StandTcpController.StandTCPControllerManager(null);
            TcpStandard_Server.StandTcpController.TCPController TCPController = ControllerManager.GetController(gate.ControllerId);
            bool re = false;
            if(TCPController != null)
            {
                re = TCPController.OpenDoor(true, (byte)0);
                Console.Out.WriteLine("Action", TCPController.CmdResult());
            }
            return "Successful >>>>>>>>>>" + TCPController?.CmdResult() + " .......Type >>>>>>>>" +TCPController.GetType();
        }
    }
}
