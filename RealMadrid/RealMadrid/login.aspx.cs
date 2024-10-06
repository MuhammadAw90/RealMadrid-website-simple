using System;
using System.Data;

namespace RealMadrid
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = UsersClass.ReturnUser(TextBoxusername.Text, TextBoxpassword.Text);

                if (dt.Rows.Count == 0)
                {
                    Labelmessega.Text = "Please enter Valid username and password";
                }

                else
                {
                    if (dt.Rows[0]["MyAdmin"].ToString() == "Yes")
                    {
                        Session["Admin"] = true;
                    }
                    Session["ValidUserID"] = dt.Rows[0]["MyID"].ToString();
                    Session["ValidUser"] = true;
                    Response.Redirect("Default.aspx");
                }
            }
            catch (Exception ex)
            {
                Labelmessega.Text = ex.Message;
            }
        }

        protected void Buttonreset_Click(object sender, EventArgs e)
        {
            TextBoxusername.Text = "";
            TextBoxpassword.Text = "";
            Labelmessega.Text = "";
        }

        protected void LinkButtonSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}