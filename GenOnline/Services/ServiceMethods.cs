using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web.Security;
using GenOnline.Services.Contracts;

using System.Net;
using TancWebApp.Helpers;

namespace GenOnline.Services
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class APIServices : IAnd
    {

        public ISampleDll _iSampleDll;

        public APIServices(ISampleDll isampleDll)
        {
            _iSampleDll = isampleDll;


        }


        public string DoNothing()
        {


            return "GetLoggedInUser";
        }
        public string GetLoggedInUserId()
        {          
            return _iSampleDll.GetUser("test");
        }
    }
}







