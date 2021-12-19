using System.Threading;
using Makaretu.Dns;

namespace TaskManager
{
    public class ServerAdvertizer
    {
        private readonly EventWaitHandle _event;
        private bool _started;
        private Thread _executor;

        public ServerAdvertizer()
        {
            _event = new ManualResetEvent(true);
        }

        public void Start()
        {
            if (_started)
            {
                return;
            }

            _executor = new Thread(_start);
            _executor.Start();
        }

        public void Stop()
        {
            _event.Set();
            _executor.Join();
            _started = false;
        }


        private void _start()
        {
            _started = true;
            _event.Reset();

            var mdns = new MulticastService();
            var sd = new ServiceDiscovery(mdns);

            // TODO get instance name from startup settings (and port ... )
            sd.Advertise(new ServiceProfile("alx-tm", "alx-grpc-tm", 5001));
            mdns.Start();
            _event.WaitOne();
        }
    }
}