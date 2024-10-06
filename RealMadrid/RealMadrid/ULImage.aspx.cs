using System;
using System.Data;

namespace RealMadrid
{
    public partial class ULImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                FillGridUL();
            }
        }

        private void FillGridUL()
        {
            try
            {
                DataTable dt = UsefulLinksClass.GetALL();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownListUL.Items.Add(dt.Rows[i]["MyTitle"].ToString());
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        private void ShowImage(string strTitle)
        {
            DataTable dt = UsefulLinksClass.GetByTitle(strTitle);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string strRealPath = Request.PhysicalApplicationPath;
                strRealPath += "UL Pics\\";
                if (FileUpload1.HasFile)
                {
                    if (System.IO.File.Exists(strRealPath + FileUpload1.FileName))
                    {
                        LabelMsg.Text = "A file with this name already exists";
                    }
                    else
                    {
                        string strType = DropDownListUL.SelectedValue.ToString();
                        FileUpload1.SaveAs(strRealPath + FileUpload1.FileName);
                        string Name = "UL Pics\\" + FileUpload1.FileName;
                        UsefulLinksClass.UpdateImg(strType, Name);
                        LabelMsg.Text = "Successfully Uploaded ";
                        ShowImage(strType);
                    }
                }
                else
                {
                    LabelMsg.Text = "Please Select An Image First";
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsefulLinksEditor.aspx");
        }
    }
}