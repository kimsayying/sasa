using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class ViewState : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            //if it is a get request 
            if (!IsPostBack)
            {
                if(ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }
                txtInput.Text = ViewState["Clicks"].ToString(); 
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            int CountClick = (int)ViewState["Clicks"] + 1;
            txtInput.Text = CountClick.ToString();
            // send back data to viewState variable to store value
            ViewState["Clicks"] = CountClick;
        }
    }
}