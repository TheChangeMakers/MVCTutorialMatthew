using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace MVCTutorialMatthew.App_Start
{
    // This class is used to place settings from cookies
    public class Startup
    {
        /*
         * app: entry point to middleware pipeline
         * app.UseCookieAuthentication: now we're using cookie based authentication
         * CookieAuthenticationOptions: this is a class, as a parameter, that contains the options that will be used for cookie based authentication.
         * LoginPath: specifies what URL the user will be directed to if not authorized. This is assigned from the PathString Object
         */
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/auth/login")
            });
        }
    }
}