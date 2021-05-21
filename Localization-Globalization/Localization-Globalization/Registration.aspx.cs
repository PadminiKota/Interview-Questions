using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace Localization_Globalization
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void InitializeCulture()
        {
            string strculture = Request.Form["DDLCulture"];
            if(strculture!=null)
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(strculture);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(strculture);
            }
            base.InitializeCulture();
        }
    }
}