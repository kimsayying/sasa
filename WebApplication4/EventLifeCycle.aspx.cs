using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class EventLifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Total Application: "+ Application["TotalApplication"]);
            Response.Write("<br>");
            Response.Write("Total UserOnline: " + Application["TotalUserSession"]);
        }
    }
}