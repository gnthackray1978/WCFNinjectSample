using System;
using Ninject;
using Ninject.Extensions.Wcf;
using Ninject.Parameters;
using Ninject.Web.Common;
using TancWebApp.Helpers;


namespace GenOnline
{
    public class ServiceModule : WcfModule
    {
        public override void Load()
        {
            this.Bind<ISampleDll>().To<SampleDll>().InRequestScope();       
        }
    }
}