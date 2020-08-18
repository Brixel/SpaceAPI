#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;
using SpaceAPI.Data.Models.API;
using SpaceAPI.Models.API;

#endregion

namespace SpaceAPI.Host.Controllers
{
    [Obsolete]
    public class StatusController : ControllerBase
    {
        private readonly LogContext _context;


        public StatusController(LogContext logContext)
        {
            _context = logContext;
        }

        [HttpGet]
        public Root Get()
        {
            var root = GetRootObject();
            var lastLog = _context.StateLogs.OrderByDescending(x => x.Id).FirstOrDefault();
            var open = lastLog != null && lastLog.Open;
            root.State.Open = open;
            return root;
        }

        private Root GetRootObject()
        {
            var reportChannels = new List<string> { "email" };
            Root root = new Root
            {
                Api = "0.13",
                Cache = new Cache
                {
                    Schedule = "h.01"
                },
                Contact = new Contact
                {
                    Email = "info@brixel.be",
                    Irc = "irc://irc.freenode.net/brixel",
                    Ml = "brixel-public@discuss.brixel.be",
                    Twitter = "@hs_hasselt"
                },
                Issue_Report_Channels = reportChannels.ToArray(),
                Location = new Location
                {
                    Address = "Spalbeekstraat 34, 3510 Spalbeek, Belgium",
                    Lat = (float)50.9509978,
                    Lon = (float)5.2305834
                },
                Logo = "https://wiki.brixel.be/images/Brixel_Logo.png",
                Projects = new[] { "https://wiki.brixel.be/w/Category:Projects" },
                Space = "Brixel",
                State  = new State()
                {
                    Open = false,
                },
                Spacefed = new Spacefed
                {
                    Spacenet = false,
                    Spacephone = false,
                    Spacesaml = false
                },
                Url = "http://brixel.be"
            };
            return root;
        }

        [Authorize]
        [HttpGet]
        public async Task<Root> Open()
        {

            var root = GetRootObject();
            root.State = new State()
            {
                Open = true
            };

            var stateLogging = new StateLog() { Open = true };
            await _context.StateLogs.AddAsync(stateLogging);
            await _context.SaveChangesAsync();
            //await _serverLessRequestService.SpaceStateChanged(true);
            return root;
        }

        [Authorize]
        [HttpGet]
        public async Task<Root> Close()
        {
            var root = GetRootObject();
            root.State = new State()
            {
                Open = false
            };
            var stateLogging = new StateLog() { Open = false };
            await _context.StateLogs.AddAsync(stateLogging);
            await _context.SaveChangesAsync();

            //await _serverLessRequestService.SpaceStateChanged(false);

            return root;
        }
    }
}