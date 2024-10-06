using System;
using System.Data;

namespace RealMadrid
{
    public partial class EditNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                string strID = Request.QueryString["ID"].ToString();
                if (int.Parse(strID) > 0)
                {
                    ShowNew(strID);
                }
                else ButtonUpload.Visible = false;
            }
        }

        private void ShowNew(string strID)
        {
            try
            {
                DataTable dt = NewsClass.GetNewByID(strID);
                TextBoxTitle.Text = dt.Rows[0]["MyTitle"].ToString();
                TextBoxBody.Text = dt.Rows[0]["MyBody"].ToString();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            string strRealPath = Request.PhysicalApplicationPath;
            strRealPath += "Images\\";
            if (FileUpload1.HasFile)
            {
                if (!System.IO.Directory.Exists(strRealPath))
                {
                    LabelMsg.Text = "Docs directory does not exist";
                }
                else
                {
                    if (System.IO.File.Exists(strRealPath + FileUpload1.FileName))
                    {
                        LabelMsg.Text = "A file with this name already exists";
                    }
                    else
                    {
                        string strID = Request.QueryString["ID"];
                        if (int.Parse(strID) != 0)
                            FileUpload1.SaveAs(strRealPath + FileUpload1.FileName);
                        NewsClass.UpdateImage(strID, "Images/" + FileUpload1.FileName);
                        LabelMsg.Text = "Successfully Uploaded ";
                    }
                }

            }
            else
            {
                LabelMsg.Text = "Please Select An Image First";
            }
        }

        protected void Buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                string strID = Request.QueryString["ID"].ToString();
                string Title = TextBoxTitle.Text;
                string Body = TextBoxBody.Text;
                if (int.Parse(strID) == 0)
                {
                    string strRealPath = Request.PhysicalApplicationPath;
                    strRealPath += "Images\\";
                    if (FileUpload1.HasFile)
                    {
                        FileUpload1.SaveAs(strRealPath + FileUpload1.FileName);
                    }
                    else
                    {
                        LabelMsg.Text = "Please Select An Image First";
                    }
                    string strFileName = "Images/" + FileUpload1.FileName;
                    NewsClass.Insert(strFileName, Title, Body);
                }
                else NewsClass.UpdateNew(strID, Title, Body);
                Response.Redirect("NewsEditor.aspx");
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewsEditor.aspx");
        }
    }
}