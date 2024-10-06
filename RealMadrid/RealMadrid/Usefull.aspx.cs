using System;
using System.Data;

namespace RealMadrid
{
    public partial class Usefull : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            DataTable dt = UsefulLinksClass.GetALL();
            GridViewUsefulLinks.DataSource = dt;
            GridViewUsefulLinks.DataBind();
        }
    }
}