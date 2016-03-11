using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TancWebApp.Helpers
{
    public class SampleDll : ISampleDll
    {
        public string GetUser(string user)
        {
            return "George : " + user;
        }
    }
}