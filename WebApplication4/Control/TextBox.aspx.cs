using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Control
{
    public partial class TextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGender.Checked)
            {
                Response.Write("Male checked");
            }
            else 
            {
                Response.Write("Female checked");
            }
        }
    }
}