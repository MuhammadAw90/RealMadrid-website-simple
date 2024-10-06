using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class UsefullLinksEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                FillGridView();
            }
        }

        private void FillGridView()
        {
            try
            {
                DataTable dt = UsefulLinksClass.GetALL();
                GridViewUL.DataSource = dt;
                GridViewUL.DataBind();
            }
            catch (Exception e)
            {
                LabelMsg.Text = e.Message;
            }
        }

        protected void GridViewUL_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Label id = (Label)GridViewUL.Rows[e.RowIndex].FindControl("LabelID");
                UsefulLinksClass.Delete(id.Text);
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewUL_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Label id = (Label)GridViewUL.Rows[e.RowIndex].FindControl("LabelEditID");
                TextBox TextBoxTitle = (TextBox)GridViewUL.Rows[e.RowIndex].FindControl("TextBoxTitle");
                TextBox TextBoxURL = (TextBox)GridViewUL.Rows[e.RowIndex].FindControl("TextBoxURL");
                UsefulLinksClass.UpdateUL(id.Text, TextBoxTitle.Text, TextBoxURL.Text);
                GridViewUL.EditIndex = -1;
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewUL_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUL.EditIndex = e.NewEditIndex;
            FillGridView();
        }

        protected void GridViewUL_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUL.EditIndex = -1;
            FillGridView();
        }

        protected void GridViewUL_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewUL.SelectedIndex = e.NewSelectedIndex;
        }

        protected void Insert(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBoxTitle = (TextBox)GridViewUL.FooterRow.FindControl("TextBoxInsertTitle");
                TextBox TextBoxURL = (TextBox)GridViewUL.FooterRow.FindControl("TextBoxInsertURL");
                UsefulLinksClass.Insert(TextBoxTitle.Text, TextBoxURL.Text);
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewUL_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Change"))
                {
                    Response.Redirect("ULImage.aspx");
                }
            }

            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}