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
        private readonly LogContext _context;

        public LoggingController(LogContext context)
        {
            _context = context;
        }

        [Route("api/log")]
        [HttpGet]
        public IHttpActionResult Get(string order = "desc", int limit = 10)
        {
            using (_context)
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
        public IHttpActionResult GetById(int id)
        {
            using (_context)
            {
                StateLog stateLog = _context.StateLogs.SingleOrDefault(x=> x.Id == id);
                if(stateLog == null)
                    return NotFound();
                return Ok(stateLog);
            }
        }

        [Route("api/log/last")]
        [HttpGet]
        public IHttpActionResult GetLast(string field = "")
        {
            using (_context)
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
