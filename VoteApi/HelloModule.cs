using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace VoteApi
{
   public class HelloModule : NancyModule
{
        const String IndexPage = @"
            <html><body>
            <h1>It works</h1>
Please use correct data access;)
            </body></html>
            ";
        public HelloModule()
    {
        Get["/"] = parameters => { return IndexPage; };
          
            After += ctx =>
            {
                if (ctx.Response.ContentType == "text/html")
                    ctx.Response.ContentType = "text/html; charset=utf-8";
            };
        }
}
}
