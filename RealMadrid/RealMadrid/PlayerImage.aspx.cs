using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class PlayerImage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                    Response.Redirect("Login.aspx");
                else FillPlayers();
            }
        }

        private void FillPlayers()
        {
            DataTable dt = PlayersClass.GetAllPlayers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownListPlayers.Items.Add(dt.Rows[i]["MyName"].ToString());
            }


        }
        private void FillGrid()
        {
            string strType;
            strType = "'" + DropDownListPlayers.SelectedValue.ToString() + "'";
            string strSQL = "SELECT * FROM [tblPlayersImages] WHERE [MyType]=" + strType;
            strSQL += " ORDER BY [MyUploadDate] DESC";
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            GridViewImages.DataSource = dt;
            GridViewImages.DataBind();
        }
        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            string strRealPath = Request.PhysicalApplicationPath;
            strRealPath += "Players\\";
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

                        string strType = DropDownListPlayers.SelectedValue.ToString();
                        string playerID = (PlayersClass.PlayerByName(strType)).Rows[0]["MyPlayerID"].ToString();
                        FileUpload1.SaveAs(strRealPath + FileUpload1.FileName);

                        string strSQL = "INSERT INTO [tblPlayersImages]([MyPlayerID],[MyFileName], [MyFileSize], [MyDescription], [MyUploadDate], [MyType]) ";
                        strSQL += " VALUES (";
                        strSQL += playerID + ",";
                        strSQL += "'" + "Players/" + FileUpload1.FileName + "',";
                        strSQL += FileUpload1.PostedFile.ContentLength + ",";
                        strSQL += "'" + TextBoxDescription.Text + "',";
                        strSQL += "#" + DateTime.Now.ToString() + "#,";
                        strSQL += "'" + strType + "'" + ")";
                        Dbase.ChangeTable(strSQL, "db.accdb");
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
                string strSQL = "DELETE * FROM [tblPlayersImages] WHERE MyID=" + strID;
                Dbase.ChangeTable(strSQL, "db.accdb");

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
            string strSQL = "SELECT * FROM [tblPlayersImages] WHERE [MyID]=" + strID.Text;
            DataTable dt = Dbase.SelectFromTable(strSQL, "db.accdb");
            string strFileName = dt.Rows[0]["MyFileName"].ToString();
            DeleteImage(strID.Text, strFileName);
            FillGrid();
        }
    }
}