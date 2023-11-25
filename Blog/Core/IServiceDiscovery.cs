using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IServiceDiscovery
    {

        Task<IList<ServiceUrl>> Discovery(string serviceName);
    }

}
