using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpaceAPI.Controllers
{
    [RoutePrefix("api/slack")]
    public class SlackController : ApiController
    {
        private LogContext _context;

        public SlackController()
        {
            _context = new LogContext();

        }
        [Route("open")]
        [HttpGet]
        public IHttpActionResult GetStatus()
        {
            var outputString = "";
            using (_context = new LogContext())
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
