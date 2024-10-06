using System;
using System.Data;

namespace RealMadrid
{
    public partial class Stadium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        {
            try
            {
                string strType = "Stadium";
                DataTable dt = InfoClass.GetInfo(strType);
                LabelStadium.Text = dt.Rows[0]["MyData"].ToString();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }
    }
}