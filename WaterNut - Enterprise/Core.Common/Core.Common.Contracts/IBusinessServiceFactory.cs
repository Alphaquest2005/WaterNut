using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Common.Contracts
{
    public interface IDataLayerServiceFactory
    {
        T CreateDataLayerService<T>() where T : IDataLayerService;
    }
}
