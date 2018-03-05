using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class SessionState2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Counts"] == null)
                {
                    Session["Counts"] = 0;
                }
                txtInput.Text = Session["Counts"].ToString();
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            int CountClick = (int)Session["Counts"] + 1;
            txtInput.Text = CountClick.ToString();
            Session["Counts"] = CountClick;
        }
    }
}