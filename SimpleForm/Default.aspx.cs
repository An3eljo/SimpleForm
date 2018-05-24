using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Submit_OnClick(object sender, EventArgs e)
        {
            var name = TextBoxName.Text;
            var email = TextBoxEmail.Text;

            RadioButton selectedSex;
            if (RadioButtonSexMale.Checked)
            {
                selectedSex = RadioButtonSexMale;
            }
            else if (RadioButtonSexFemale.Checked)
            {
                selectedSex = RadioButtonSexFemale;
            }

            var age = DropDownAge.SelectedItem;
            var comment = TextBoxComment.Text;

            Response.Redirect("About.aspx");
        }
    }
}