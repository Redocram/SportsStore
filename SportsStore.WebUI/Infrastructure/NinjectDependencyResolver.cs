// compile with: /doc:SportStoreDoc.xml 

using Moq;
using Ninject;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
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

        /// <summary>
        /// This method bind a Interface to the implementing class the will be used to resolve the DI
        /// </summary>
        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Name = "Football", Price = 25},
                new Product { Name = "Surf board", Price = 179},
                new Product { Name = "Running shoes", Price = 95},
            });

            /*Thanks to ToConstant method, Ninject will return the same mock object whenever it gets a request for an implementation of the IProductRepository interface.
             * Rather than create a new istance of the implementation object each time, ninject will always satisfy requests for the IProductRepository interface with the same mock object
             */
            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
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