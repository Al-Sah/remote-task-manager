using System;
using System.Collections.Generic;
using System.Net;

namespace ControlPanel.Core
{
    public class ServerInfo
    {
        public string ServiceInstanceName { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<string> ServiceLabels { get; }
        public DataState CurrentState { get; set; }
        public ushort Port { get; set; }
        public IPAddress Address { get; set; }

        public ServerInfo()
        {
            ServiceLabels = new List<string>();
            ServiceInstanceName = string.Empty;
            CurrentState = DataState.Collecting;
            LastUpdate = DateTime.Now;
            Address = IPAddress.None;
            Port = 0;
        }

        public enum DataState
        {
            Valid,
            Deprecated,
            Collecting,
            Failed
        }
    }
}