using System;
using System.Collections.Generic;

namespace DesignPatterns.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server { Id = Guid.NewGuid(), Name = "Server 1", IP = "120.14.220.18" },
                new Server { Id = Guid.NewGuid(), Name = "Server 2", IP = "120.14.220.19" },
                new Server { Id = Guid.NewGuid(), Name = "Server 3", IP = "120.14.220.20" },
                new Server { Id = Guid.NewGuid(), Name = "Server 4", IP = "120.14.220.21" },
                new Server { Id = Guid.NewGuid(), Name = "Server 5", IP = "120.14.220.22" }
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var serverRandomIndex = _random.Next(_servers.Count);
                return _servers[serverRandomIndex];
            }
        }
    }
}