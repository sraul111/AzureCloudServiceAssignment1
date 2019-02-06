using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Castle.MicroKernel;
using Castle.MicroKernel.Lifestyle;

namespace WebRole2.CastleWindsor
{
    public class DependencyScope : IDependencyScope
    {
        private readonly IKernel kernel;
        private readonly IDisposable disposable;

        public DependencyScope(IKernel kernel)
        {
            this.kernel = kernel;
            disposable = kernel.BeginScope();
        }
        public void Dispose()
        {
            disposable.Dispose();
        }

        public object GetService(Type serviceType)
        {
            return kernel.HasComponent(serviceType) ? kernel.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.ResolveAll(serviceType).Cast<object>();
        }
    }
}