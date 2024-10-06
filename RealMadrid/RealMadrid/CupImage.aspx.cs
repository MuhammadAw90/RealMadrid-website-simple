using System;
using System.Data;

namespace RealMadrid
{
    public partial class CupImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        {
            try
            {
                DataTable dt = CupsClass.GetALL();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownListCups.Items.Add(dt.Rows[i]["MyName"].ToString());
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        private void ShowImage(string strName)
        {
            try
            {
                DataTable dt = CupsClass.GetByName(strName);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            string strType = DropDownListCups.Text;
            string strRealPath = Request.PhysicalApplicationPath;
            strRealPath += "Cups Pics\\";
            if (FileUpload1.HasFile)
            {
                if (!System.IO.Directory.Exists(strRealPath))
                {
                    LabelMsg.Text = "Image directory does not exist";
                }
                else
                {
                    if (System.IO.File.Exists(strRealPath + FileUpload1.FileName))
                    {
                        LabelMsg.Text = "This Image Already Exists";
                    }
                    else
                    {
                        DataTable dt = CupsClass.GetByName(strType);
                        string strID = dt.Rows[0]["MyID"].ToString();
                        FileUpload1.SaveAs(strRealPath + FileUpload1.FileName);
                        string Name = "Cups Pics\\" + FileUpload1.FileName;
                        NewsClass.UpdateImage(strID, Name);
                        LabelMsg.Text = "Successfully Uploaded ";
                    }
                }

            }
            else
            {
                LabelMsg.Text = "Please Select An Image First";
            }
        }


        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CupsEditor.aspx");
        }

        protected void DropDownListCups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowImage(DropDownListCups.Text);
        }
    }
}
