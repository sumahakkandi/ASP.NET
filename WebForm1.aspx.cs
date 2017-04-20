using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace management_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["clicks"] != null)
            {
                ViewState["clicks"] = (int)ViewState["clicks"] + 1;
            }
            else
            {
                ViewState["clicks"] = 1;
            }
            Label1.Text = String.Format($"ViewState.clicks:{((int)ViewState["clicks"])}");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}