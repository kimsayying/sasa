using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Contact : Page
    {
        int countClick = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtInput.Text = "0";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //if(ViewState["click"] != null)
            //{
            //    countClick = Convert.ToInt32(ViewState["click"]) + 1;
            //    txtInput.Text = countClick.ToString();
            //}
            //ViewState["click"] = countClick;
            countClick = Convert.ToInt32(txtInput.Text) + 1;
            txtInput.Text = countClick.ToString();
        }
    }
}