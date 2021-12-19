using System;
using System.Collections.Generic;
using System.Net;

namespace ControlPanel.Core
{
    public class ServerInfo
    {
        public string ServiceInstanceName { get; set; }
        public List<string> ServiceLabels { get; }


        private readonly object _dateTimeLock = new();
        private DateTime _lastUpdate;

        public DateTime LastUpdate
        {
            get
            {
                lock (_dateTimeLock)
                {
                    return _lastUpdate;
                }
            }
            set
            {
                lock (_dateTimeLock)
                {
                    _lastUpdate = value;
                }

                DataUpdated?.Invoke();
            }
        }

        private readonly object _dataStateLock = new();
        private DataState _currentState;

        public DataState CurrentState
        {
            get
            {
                lock (_dataStateLock)
                {
                    return _currentState;
                }
            }
            set
            {
                lock (_dataStateLock)
                {
                    _currentState = value;
                }

                DataUpdated?.Invoke();
            }
        }


        private readonly object _portLock = new();
        private ushort _port;

        public ushort Port
        {
            get
            {
                lock (_portLock)
                {
                    return _port;
                }
            }
            set
            {
                lock (_portLock)
                {
                    _port = value;
                }

                DataUpdated?.Invoke();
            }
        }

        private readonly object _addressLock = new();
        private IPAddress _address;

        public IPAddress Address
        {
            get
            {
                lock (_addressLock)
                {
                    return _address;
                }
            }
            set
            {
                lock (_addressLock)
                {
                    _address = value;
                }

                DataUpdated?.Invoke();
            }
        }

        public event Action? DataUpdated;

        public ServerInfo()
        {
            ServiceLabels = new List<string>();
            ServiceInstanceName = string.Empty;
            CurrentState = DataState.Collecting;
            LastUpdate = DateTime.Now;
            _address = IPAddress.None;
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