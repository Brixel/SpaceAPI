using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;

namespace SpaceAPI.Host.Controllers
{
    [Route("api/slack")]
    public class SlackController : ControllerBase
    {
        private LogContext _context;

        public SlackController(LogContext context)
        {
            _context = context;
        }
        [Route("open")]
        [HttpGet]
        public ActionResult GetStatus()
        {
            var outputString = "";
            using (_context)
            {
                StateLog stateLog = _context.StateLogs.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
                if (stateLog.Open)
                {
                    outputString = "We are open";
                }
                else
                {
                    outputString = "We are closed";
                }
            }
            return Ok(outputString);
        }
    }
}
