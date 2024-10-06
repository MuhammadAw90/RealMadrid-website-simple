using System;
using System.Data;

namespace RealMadrid
{
    public partial class InfoEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                FillDropDownList();
            }
        }


        private void FillDropDownList()
        {
            try
            {
                DropDownListType.Items.Clear();
                DataTable dt = InfoClass.GetAll();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownListType.Items.Add(dt.Rows[i]["MyType"].ToString());
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        private void FillGrid()
        {
            string strType;
            strType = DropDownListType.SelectedValue.ToString();
            DataTable dt = InfoClass.GetInfo(strType);
            if (dt.Rows.Count != 0)
            {
                TextBoxInfo.Text = dt.Rows[0]["MyData"].ToString();
            }
            else LabelMsg.Text = "There Is No Result";
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxInfo.Text != "")
            {
                string strType = DropDownListType.SelectedValue.ToString();

                InfoClass.UpdateInfo(strType, TextBoxInfo.Text);
                Response.Redirect(strType + ".aspx");
            }
            else LabelMsg.Text = "There Is No Text";
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            string strType = DropDownListType.SelectedValue.ToString();
            Response.Redirect(strType + ".aspx");
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        protected void ButtonNewInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewInfo.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strType = DropDownListType.SelectedValue.ToString();
                InfoClass.DeleteInfo(strType);
                FillDropDownList();
                FillGrid();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}