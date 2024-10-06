using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class SendMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                FillDropBox();
            }

        }

        private void FillDropBox()
        {
            DataTable dt = UsersClass.GetAllUsers();
            DropDownListUsers.DataSource = dt;
            DropDownListUsers.DataTextField = "Myusername";
            DropDownListUsers.DataValueField = "MyID";
            DropDownListUsers.DataBind();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strSenderID = Session["ValidUserID"].ToString();
                string strRecieverID = DropDownListUsers.Text;
                string strTitle = TextBoxTitle.Text;
                string strBody = TextBox2.Text;
                MessagesClass.InsertInbox(strRecieverID, strSenderID, strTitle, strBody);
                MessagesClass.InsertOutbox(strRecieverID, strSenderID, strTitle, strBody);
                Response.Redirect("Outbox.aspx");
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }

        }
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}