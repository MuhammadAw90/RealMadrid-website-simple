using System;
using System.Linq;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Userseditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
            {
                Response.Redirect("Login.aspx");
            }
            else if (!IsPostBack)
            {
                FillGridView();
            }
        }

        private void FillGridView()
        {
            try
            {
                DataTable dt = UsersClass.GetAllUsers();
                GridViewUsers.DataSource = dt;
                GridViewUsers.DataBind();
            }
            catch (Exception e)
            {
                LabelMsg.Text = e.Message;
            }
        }

        protected void GridViewUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Label admin = (Label)GridViewUsers.Rows[e.RowIndex].FindControl("LabelAdmin");

                if (UsersClass.GetAllAdmins().Rows.Count == 1 && admin.Text == "Yes")
                {
                    LabelMsg.Text = "It's Impossible Because You Are The Last Admin In This Website";
                }

                else
                {
                    Label id = (Label)GridViewUsers.Rows[e.RowIndex].FindControl("LabelID");
                    UsersClass.DeleteUser(id.Text);
                    FillGridView();
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Label id = (Label)GridViewUsers.Rows[e.RowIndex].FindControl("LabelEditID");
                TextBox TextBoxFname = (TextBox)GridViewUsers.Rows[e.RowIndex].FindControl("TextBoxFname");
                TextBox TextBoxLname = (TextBox)GridViewUsers.Rows[e.RowIndex].FindControl("TextBoxLname");
                TextBox TextBoxDateOfBirth = (TextBox)GridViewUsers.Rows[e.RowIndex].FindControl("TextBoxDateOfBirth");
                RadioButton RadioButtonMale = (RadioButton)GridViewUsers.Rows[e.RowIndex].FindControl("RadioButton1");
                RadioButton RadioButtonFemale = (RadioButton)GridViewUsers.Rows[e.RowIndex].FindControl("RadioButton2");
                string strGender;
                if (RadioButtonMale.Checked)
                {
                    strGender = RadioButtonMale.Text;
                }
                else strGender = RadioButtonFemale.Text;
                TextBox TextBoxEmail = (TextBox)GridViewUsers.Rows[e.RowIndex].FindControl("TextBoxEmail");
                TextBox TextBoxusername = (TextBox)GridViewUsers.Rows[e.RowIndex].FindControl("TextBoxusername");
                TextBox TextBoxpw = (TextBox)GridViewUsers.Rows[e.RowIndex].FindControl("TextBoxpw");
                DropDownList strAdmin = (DropDownList)GridViewUsers.Rows[e.RowIndex].FindControl("DropDownListEditAdmin");
                UsersClass.UpdateUser(id.Text, TextBoxFname.Text, TextBoxLname.Text, TextBoxDateOfBirth.Text, TextBoxEmail.Text, strGender, TextBoxusername.Text, TextBoxpw.Text, strAdmin.Text);

                GridViewUsers.EditIndex = -1;
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUsers.EditIndex = e.NewEditIndex;
            FillGridView();
        }

        protected void GridViewUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUsers.EditIndex = -1;
            FillGridView();
        }

        protected void GridViewUsers_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewUsers.SelectedIndex = e.NewSelectedIndex;
        }

        protected void Insert(object sender, EventArgs e)
        {
            try
            {
                TextBox TextBoxFname = (TextBox)GridViewUsers.FooterRow.FindControl("TextBoxInsertFname");
                TextBox TextBoxLname = (TextBox)GridViewUsers.FooterRow.FindControl("TextBoxInsertLname");
                TextBox TextBoxDateOfBirth = (TextBox)GridViewUsers.FooterRow.FindControl("TextBoxInsertDateOfBirth");
                TextBox TextBoxEmail = (TextBox)GridViewUsers.FooterRow.FindControl("TextBoxInsertEmail");
                RadioButton RadioButtonMale = (RadioButton)GridViewUsers.FooterRow.FindControl("RadioButton3");
                RadioButton RadioButtonFemale = (RadioButton)GridViewUsers.FooterRow.FindControl("RadioButton4");
                string strGender;
                if (RadioButtonMale.Checked)
                {
                    strGender = RadioButtonMale.Text;
                }
                else strGender = RadioButtonFemale.Text;
                TextBox TextBoxusername = (TextBox)GridViewUsers.FooterRow.FindControl("TextBoxInsertusername");
                TextBox TextBoxpw = (TextBox)GridViewUsers.FooterRow.FindControl("TextBoxInsertpw");
                DropDownList strAdmin = (DropDownList)GridViewUsers.FooterRow.FindControl("DropDownListInsertAdmin");
                UsersClass.InsertUser(TextBoxFname.Text, TextBoxLname.Text, TextBoxDateOfBirth.Text, TextBoxEmail.Text, strGender, TextBoxusername.Text, TextBoxpw.Text, strAdmin.Text);
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}