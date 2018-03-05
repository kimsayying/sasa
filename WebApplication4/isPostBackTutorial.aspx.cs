using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class isPostBackTutorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                loadDropDownList();
            }
        }

        public void loadDropDownList()
        {
            // instance of a list item object
            ListItem l1 = new ListItem("London");
            ddlCity.Items.Add(l1);

            ListItem l2 = new ListItem("Kuala Lumpur");
            ddlCity.Items.Add(l2);

            ListItem l3 = new ListItem("Penang");
            ddlCity.Items.Add(l3);
        }
    }
}