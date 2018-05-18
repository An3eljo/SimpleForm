using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleForm
{
    public partial class Contact : Page
    {
        public string gg = "lsgh";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void OnClick(object sender, EventArgs e)
        {
            var allVariables = Request.Form.AllKeys;

            var t = Request.Form["fname"];
        }
    }
}