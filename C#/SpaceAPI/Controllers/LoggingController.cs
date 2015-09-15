using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;
using SpaceAPI.Models.API;

namespace SpaceAPI.Controllers
{
    public class LoggingController : ApiController
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
        public IHttpActionResult Get(string order = "desc")
        {
            using (_context = new LogContext())
            {
                 List<StateLog> stateLogs = new List<StateLog>();
                switch (order)
                {
                    case "asc":
                       stateLogs = _context.StateLogs.ToList();
                        break;
                    case "desc":
                        stateLogs = _context.StateLogs.OrderByDescending(x => x.CreatedDate).ToList();
                        break;
                }
                
                return Ok(stateLogs);
            }
        }
        [Route("api/log/{id:int}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            using (_context = new LogContext())
            {
                StateLog stateLog = _context.StateLogs.SingleOrDefault(x=> x.Id == id);
                if(stateLog == null)
                    return NotFound();
                return Ok(stateLog);
            }
        } 
    }
}