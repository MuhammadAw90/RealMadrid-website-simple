using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillComments();
            }
        }

        private void FillComments()
        {
            DataTable dt = CommentsClass.GetALL();
            GridViewComments.DataSource = dt;
            GridViewComments.DataBind();
        }

        public void Add(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBoxName = (TextBox)GridViewComments.FooterRow.FindControl("TextBoxName");
                TextBox TextBoxCity = (TextBox)GridViewComments.FooterRow.FindControl("TextBoxCity");
                TextBox TextBoxTitle = (TextBox)GridViewComments.FooterRow.FindControl("TextBoxTitle");
                TextBox TextBoxData = (TextBox)GridViewComments.FooterRow.FindControl("TextBoxData");
                CommentsClass.Insert(TextBoxName.Text, TextBoxCity.Text, TextBoxTitle.Text, TextBoxData.Text);
                FillComments();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}
