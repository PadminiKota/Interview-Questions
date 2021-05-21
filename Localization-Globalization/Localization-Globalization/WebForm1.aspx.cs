using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Localization_Globalization
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double requiredamount = 900;
        protected void Page_Load(object sender, EventArgs e)
        {
            LblDate.Text = DateTime.Now.ToShortDateString();
            LblRequiredamount.Text = requiredamount.ToString("C");
        }
    }
}