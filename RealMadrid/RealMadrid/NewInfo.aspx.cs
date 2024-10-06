using System;

namespace RealMadrid
{
    public partial class NewInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
        }
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("InfoEditor.aspx");
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strType = TextBoxType.Text;
                string strData = FreeTextBoxData.Text;
                InfoClass.InsertInfo(strType, strData);
                Response.Redirect("InfoEditor.aspx");
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}