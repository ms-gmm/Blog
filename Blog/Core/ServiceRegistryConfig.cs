using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class ServiceRegistryConfig
    {
        //consul地址 服务注册地址
        public string RegistryAddress { get; set; }
      

        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public int Port { get; set; }
        public string[] Tags { get; set; }
    }
}
