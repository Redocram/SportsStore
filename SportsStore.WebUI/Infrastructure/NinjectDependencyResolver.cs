// compile with: /doc:Documentation.xml 

using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Infrastructure
{
    /// <summary>
    /// This class creates istances of the classes needed for solving DI and it's called by MVC thanks to NinjectWebCommon:RegisterServices().</summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        /// <summary>This field is the class that is responsible for resolving dependencies and creating new objects.</summary>
        private IKernel kernel;

        /// <summary>
        /// This method is called by App_start/NinjectWebCommon to solve the dependecy injection.</summary>
        /// <param name="kernelParam"></param>
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is called when MVC needs an instance of a class to service an incoming request.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns>An instance of the class that is binded to a specific interface or null when there is not suitable binding</returns>
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        /// <summary>
        /// This method is called when MVC needs an instance of a class to service an incoming request and supports multiple binding for a single type.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns>A series of instances of the service.</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}