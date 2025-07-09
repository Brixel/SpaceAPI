using System;
using System.Collections.Generic;

namespace BrixelAPI.SpaceState.Features.GetStateChangedLogs
{
    public class GetStateChangedLogResponse
    {
        public List<GetStateChangeLogDTO> Logs { get; }

        public GetStateChangedLogResponse(List<GetStateChangeLogDTO> logs)
        {
            Logs = logs;
        }

        public class GetStateChangeLogDTO
        {
            public bool IsOpen { get; set; }
            public string ChangedByUser { get; set; }
            public DateTime ChangedAtDateTime { get; set; }
        }
    }
}