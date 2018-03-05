using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["Counts"] == null)
                {
                    Application["Counts"] = 0;
                }
                txtInput.Text = Application["Counts"].ToString();
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            int CountClick = (int)Application["Counts"] + 1;
            txtInput.Text = CountClick.ToString();
            Application["Counts"] = CountClick;
        }
    }
}