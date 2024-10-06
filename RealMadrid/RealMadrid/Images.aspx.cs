using System;
using System.Data;

namespace RealMadrid
{
    public partial class images : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                FillPlayersNames();
        }

        private void FillPlayersNames()
        {
            DataTable dt = PlayersClass.GetAllPlayers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownListFileType.Items.Add(dt.Rows[i]["MyName"].ToString());
            }
        }

        private void FillGrid()
        {
            string strType;
            strType = DropDownListFileType.SelectedValue.ToString();
            DataTable dt = PlayersClass.GetAllPlayerImagesByName(strType);
            GridViewFiles.DataSource = dt;
            GridViewFiles.DataBind();
        }

        protected void DropDownListFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
        protected void GridViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
