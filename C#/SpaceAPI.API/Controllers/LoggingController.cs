using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;

namespace SpaceAPI.Controllers
{
    public class LoggingController : ControllerBase
    {
        private LogContext _context;

        public LoggingController(LogContext context)
        {
            _context = context;
        }

        public LoggingController()
        {
            _context = new LogContext();
        }

        [Route("api/log")]
        [HttpGet]
        public ActionResult Get(string order = "desc", int limit = 10)
        {
            using (_context = new LogContext())
            {
                 List<StateLog> stateLogs = new List<StateLog>();
                switch (order)
                {
                    case "asc":
                       stateLogs = _context.StateLogs.Take(limit).ToList();
                        break;
                    case "desc":
                        stateLogs = _context.StateLogs.Take(limit).OrderByDescending(x => x.CreatedDate).ToList();
                        break;
                }
                
                return Ok(stateLogs);
            }
        }
        [Route("api/log/{id:int}")]
        [HttpGet]
        public ActionResult GetById(int id)
        {
            using (_context = new LogContext())
            {
                StateLog stateLog = _context.StateLogs.SingleOrDefault(x=> x.Id == id);
                if(stateLog == null)
                    return NotFound();
                return Ok(stateLog);
            }
        }

        [Route("api/log/last")]
        [HttpGet]
        public ActionResult GetLast(string field = "")
        {
            using (_context = new LogContext())
            {
                StateLog stateLog = _context.StateLogs.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
               
                if (stateLog == null)
                    return NotFound();
                if (field == "open")
                {
                    return Ok(stateLog.Open);
                }
                return Ok(stateLog);
            }
        } 
    }
}
