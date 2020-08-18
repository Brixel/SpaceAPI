using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;

namespace SpaceAPI.Host.Controllers
{
    [Obsolete]
    public class LoggingController : ControllerBase
    {
        private readonly LogContext _context;

        public LoggingController(LogContext context)
        {
            _context = context;
        }
            
        [HttpGet]
        public IReadOnlyList<StateLog> Get(string order = "desc", int limit = 10)
        {
            List<StateLog> stateLogs;
            switch (order)
            {
                case "asc":
                    stateLogs = _context.StateLogs.Take(limit).ToList();
                    break;
                case "desc":
                    default:
                    stateLogs = _context.StateLogs.Take(limit).OrderByDescending(x => x.CreatedDate).ToList();
                    break;
            }

            return stateLogs;
        }

        [HttpGet]
        public StateLog GetById(int id)
        {
            return _context.StateLogs.SingleOrDefault(x => x.Id == id);
        }

        [HttpGet]
        public StateLog GetLast(string field = "")
        {
            var stateLog = _context.StateLogs.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
            return stateLog;
        }

        [HttpGet]
        public bool IsOpen()
        {
            var stateLog = _context.StateLogs.OrderByDescending(x => x.CreatedDate).FirstOrDefault();
            return stateLog.Open;
        }
    }
}
