using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Cấu hình SignalR
            app.MapSignalR();

            // Để có thể sử dụng Cors trong SignalR, hãy thêm dòng sau:
            // app.UseCors(CorsOptions.AllowAll);
        }
    }
}

