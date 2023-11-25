using Consul;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ServiceDiscoveryConfig 
    {
        public string RegistryAddress { get; set; }
    }
}
