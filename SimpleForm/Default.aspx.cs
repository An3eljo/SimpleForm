using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Session.Timeout = 10;
        }


        protected void Submit_OnClick(object sender, EventArgs e)
        {
            Session.Add("UserName", TextBoxName.Text);
            Session.Add("UserEmail", TextBoxEmail.Text);

            //Session["UserName"] = TextBoxName.Text;
            //Session["UserEmail"] = TextBoxEmail.Text;
            //var name = TextBoxName.Text;
            //var email = TextBoxEmail.Text;

            
            RadioButton selectedSex = null;
            if (RadioButtonSexMale.Checked)
            {
                selectedSex = RadioButtonSexMale;
            }
            else if (RadioButtonSexFemale.Checked)
            {
                selectedSex = RadioButtonSexFemale;
            }
            Session.Add("UserSelectedSex", selectedSex);
            //Session["UserSelectedSex"] = selectedSex;

            Session.Add("UserAge", DropDownAge.SelectedItem);
            Session.Add("UserComment", TextBoxComment.Text);
            //Session["UserAge"] = DropDownAge.SelectedItem;
            //Session["UserComment"] = TextBoxComment.Text;
            //var age = DropDownAge.SelectedItem;
            //var comment = TextBoxComment.Text;

            Response.Redirect("About.aspx");
        }
    }
}