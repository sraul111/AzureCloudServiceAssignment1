using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using BussinessLogic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;



namespace WebRole2
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            GlobalConfiguration.Configuration.DependencyResolver = new CastleWindsor.DependencyResolver(container.Kernel);
            container.Register(Component.For<IStudentResultCalculator>().ImplementedBy<StudentResultCalculator>());
        }


        
    }
}
