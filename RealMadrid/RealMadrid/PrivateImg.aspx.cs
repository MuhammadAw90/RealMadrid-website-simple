using System;
using System.Data;

namespace RealMadrid
{
    public partial class PrivateImg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                        Response.Redirect("Login.aspx");
                    else ShowImages();
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        private void ShowImages()
        {
            try
            {
                DataTable dt = FilesClass.GetAllImages();
                DataListImages.DataSource = dt;
                DataListImages.DataBind();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}