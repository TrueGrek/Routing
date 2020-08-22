using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing; // Пространство имен необходимое для маршрутизации в ASP.NET WebForms


namespace Routing
{
    public class Global : System.Web.HttpApplication
    {

        // Обработчик события старта приложения. Срабатывает один раз при первом запросе к веб приложению.
        protected void Application_Start(object sender, EventArgs e)
        {
            // RouteTable.Routes - коллекция всех маршрутов текущего приложения.
            RegisterRoutes(RouteTable.Routes);
        }

        // Метод для регистрации маршрутов.
        void RegisterRoutes(RouteCollection routes)
        {
            // Маршрут для запросов brosers/ie, browsers/сhrome и т.д.
            // Переходя по адресу browser/имя будет создаваться экземпляр страницы Browsers.aspx для которой будет доступен параметр с именем name
            routes.MapPageRoute("BrowsersCollection", "browsers/{name}", "~/Browsers.aspx");
        }

    }
}