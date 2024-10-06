using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class CommentsEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                    Response.Redirect("Login.aspx");
                else FillComments();
            }
        }

        private void FillComments()
        {
            try
            {
                DataTable dt = CommentsClass.GetALL();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillComments();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("LabelID");
                CommentsClass.Delete(id.Text);
                FillComments();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillComments();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Label TextBoxID = (Label)GridView1.Rows[e.RowIndex].FindControl("LabelEditID");
                TextBox TextBoxName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBoxName");
                TextBox TextBoxCity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBoxCity");
                TextBox TextBoxTitle = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBoxTitle");
                TextBox TextBoxData = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBoxData");
                CommentsClass.UpdateComment(TextBoxName.Text, TextBoxCity.Text, TextBoxTitle.Text, TextBoxData.Text, TextBoxID.Text);
                GridView1.EditIndex = -1;
                FillComments();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        public void Add(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBoxName = (TextBox)GridView1.FooterRow.FindControl("TextBoxInsertName");
                TextBox TextBoxCity = (TextBox)GridView1.FooterRow.FindControl("TextBoxInsertCity");
                TextBox TextBoxTitle = (TextBox)GridView1.FooterRow.FindControl("TextBoxInsertTitle");
                TextBox TextBoxData = (TextBox)GridView1.FooterRow.FindControl("TextBoxInsertData");
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
