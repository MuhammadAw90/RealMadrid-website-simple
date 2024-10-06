using System;
using System.Data;

namespace RealMadrid
{
    public partial class Trophies : System.Web.UI.Page
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
                DataTable dt = CupsClass.GetALL();
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }

            catch (Exception ex)
            {
            }
        }
    }
}
