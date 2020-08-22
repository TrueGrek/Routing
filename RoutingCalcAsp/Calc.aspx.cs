using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoutingCalcAsp
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string operation = Page.RouteData.Values["operation"] as string;
                int x = Convert.ToInt32(Page.RouteData.Values["x"]);
                int y = Convert.ToInt32(Page.RouteData.Values["y"]);

                switch (operation)
                {
                    case "sum":
                        Result.Text = (x + y).ToString();
                        break;
                    case "sub":
                        Result.Text = (x - y).ToString();
                        break;
                    case "mul":
                        Result.Text = (x * y).ToString();
                        break;
                    case "div":
                        Result.Text = (x / y).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                Result.Text = "ERROR";
                Result.ForeColor = Color.Red;
            }
        }
    }
}