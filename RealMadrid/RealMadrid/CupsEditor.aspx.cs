using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class CupsEditor : System.Web.UI.Page
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
                DataTable dt = CupsClass.GetALL();
                GridViewCups.DataSource = dt;
                GridViewCups.DataBind();
            }
            catch (Exception e)
            {
                LabelMsg.Text = e.Message;
            }
        }

        protected void GridViewCups_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Label id = (Label)GridViewCups.Rows[e.RowIndex].FindControl("LabelID");
                CupsClass.Delete(id.Text);
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewCups_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Label id = (Label)GridViewCups.Rows[e.RowIndex].FindControl("LabelEditID");
                TextBox TextBoxName = (TextBox)GridViewCups.Rows[e.RowIndex].FindControl("TextBoxName");
                TextBox TextBoxNumber = (TextBox)GridViewCups.Rows[e.RowIndex].FindControl("TextBoxNumber");
                CupsClass.UpdateCups(TextBoxName.Text, TextBoxNumber.Text, id.Text);
                GridViewCups.EditIndex = -1;
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewCups_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewCups.EditIndex = e.NewEditIndex;
            FillGridView();
        }

        protected void GridViewCups_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewCups.EditIndex = -1;
            FillGridView();
        }

        protected void GridViewCups_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewCups.SelectedIndex = e.NewSelectedIndex;
        }

        protected void Insert(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBoxName = (TextBox)GridViewCups.FooterRow.FindControl("TextBoxInsertName");
                TextBox TextBoxNumber = (TextBox)GridViewCups.FooterRow.FindControl("TextBoxInsertNumber");
                CupsClass.Insert(TextBoxName.Text, TextBoxNumber.Text);
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewCups_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Change"))
                {
                    Response.Redirect("CupImage.aspx");
                }
            }

            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}
