using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace RoutingCalc
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        void RegisterRoutes(RouteCollection routes)
        {
            // Маршрут будет срабатывать при поступлении запроса подобного следующему calc/sum/10/20
            routes.MapPageRoute("Calculator", "calc/{operation}/{x}/{y}", "~/Calc.aspx");
        }
    }
}