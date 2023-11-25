using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public interface IServiceRegistry
    {
        void Registry(ServiceRegistryConfig serviceNode);

        void DeRegistry(ServiceRegistryConfig serviceNode);
    }
}
