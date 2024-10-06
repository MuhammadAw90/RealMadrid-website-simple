using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class ImagesEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                    Response.Redirect("Login.aspx");
                else FillGrid();
            }
        }

        private void FillGrid()
        {
            DataTable dt = FilesClass.GetAllImages();
            GridViewImages.DataSource = dt;
            GridViewImages.DataBind();
        }
        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            string strRealPath = Request.PhysicalApplicationPath;
            strRealPath += "Docs\\";
            if (FileUpload1.HasFile)
            {
                if (!System.IO.Directory.Exists(strRealPath))
                {
                    LabelMsg.Text = "Docs directory does not exist";
                }
                else if (FileUpload1.PostedFile.ContentLength < 100000000)
                {

                    if (System.IO.File.Exists(strRealPath + FileUpload1.FileName))
                    {
                        LabelMsg.Text = "A file with this name already exists";
                    }
                    else
                    {
                        FileUpload1.SaveAs(strRealPath + FileUpload1.FileName);
                        string strFileName = "Docs/" + FileUpload1.FileName;
                        FilesClass.InsertImage(strFileName, FileUpload1.PostedFile.ContentLength, TextBoxDescription.Text);
                        LabelMsg.Text = "Successfully Uploaded ";
                    }
                }
                else
                {
                    LabelMsg.Text = "The Image Size Must Be <= To 100 MB ";
                }
            }
            else
            {
                LabelMsg.Text = "Please Select An Image First";
            }
            FillGrid();

        }

        protected void GridViewImages_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string strValue = DataBinder.Eval(e.Row.DataItem, "MyFileName").ToString();
                int nIndex = strValue.IndexOf("/");
                if (nIndex != -1)
                {
                    strValue = strValue.Substring(nIndex + 1);
                    e.Row.Cells[1].Text = strValue;
                }
            }
        }

        private void DeleteImage(string strID, string strFileName)
        {
            try
            {
                FilesClass.DeleteFileByID(strID);
                string strRealPath = Request.PhysicalApplicationPath;
                System.IO.File.Delete(strRealPath + strFileName);
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
        protected void DropDownListPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        protected void GridViewImages_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label strID = (Label)GridViewImages.Rows[e.RowIndex].FindControl("LabelID");
            DataTable dt = FilesClass.SelectImage(strID.Text);
            string strFileName = dt.Rows[0]["MyFileName"].ToString();
            DeleteImage(strID.Text, strFileName);
            FillGrid();
        }
    }
}
