using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class NewsEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                Response.Redirect("Login.aspx");
            else if (!IsPostBack)
            {
                FillGridView();
            }
        }

        private void FillGridView()
        {
            try
            {
                DataTable dt = NewsClass.GetAll();
                GridView1.DataSource = dt;
                GVDataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridView();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label strID = (Label)GridView1.Rows[e.NewEditIndex].FindControl("LabelID");
            Response.Redirect("EditNews.aspx?ID=" + strID.Text);
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            string strSortExpression = e.SortExpression;
            ViewState["m_Sortexpresion"] = e.SortExpression;
            if (GridViewSortDirection == SortDirection.Ascending)
            {
                GridViewSortDirection = SortDirection.Descending;
                SortGridView(strSortExpression, "DESC");
            }
            else
            {
                GridViewSortDirection = SortDirection.Ascending;
                SortGridView(strSortExpression, "ASC");
            }
        }

        private void SortGridView(string sortExpression, string direction)
        {
            if (GVDataSource == null)
                return;
            DataView dv = new DataView(GVDataSource); // 1
            dv.Sort = sortExpression + " " + direction; // 2
            this.GridView1.DataSource = dv; // 3
            GridView1.DataBind(); // 4
        }

        public string SortExpression
        {
            get
            {
                if (ViewState["m_Sortexpresion"] == null)
                    ViewState["m_Sortexpresion"] = this.GridView1.DataKeyNames[0].ToString();
                return ViewState["m_Sortexpresion"].ToString();
            }
            set
            {
                ViewState["m_Sortexpresion"] = value;
            }
        }

        public DataTable GVDataSource
        {
            get
            {
                if (ViewState["m_GVDataSource"] == null)
                    ViewState["m_GVDataSource"] =
                    this.GridView1.DataSource as DataTable;
                return ViewState["m_GVDataSource"] as DataTable;
            }
            set
            {
                ViewState["m_GVDataSource"] = value;
            }
        }

        public SortDirection GridViewSortDirection
        {
            get
            {
                if (ViewState["m_SortDirection"] == null)
                    ViewState["m_SortDirection"] =
                    SortDirection.Ascending;
                return (SortDirection)ViewState["m_SortDirection"];
            }
            set
            {
                ViewState["m_SortDirection"] = value;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Label strID = (Label)GridView1.Rows[e.RowIndex].FindControl("LabelID");
                NewsClass.DeleteNew(strID.Text);
                FillGridView();
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (GridViewSortDirection == SortDirection.Ascending)
            {
                SortGridView(SortExpression, "asc");
            }
            else
            {
                SortGridView(SortExpression, "desc");
            }
        }

        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditNews.aspx?ID=0");
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                if (String.Empty != SortExpression)
                {
                    AddSortImage(e.Row);
                }
            }
        }

        void AddSortImage(GridViewRow headerRow)
        {
            int iCol = GetSortColumnIndex(SortExpression);
            if (-1 == iCol)
            {
                return;
            }
            Image sortImage = new Image();
            if (SortDirection.Ascending == GridViewSortDirection)
            {
                sortImage.ImageUrl = "Images/down.jpg";
                sortImage.Height = 20;
                sortImage.Width = 20;
                sortImage.AlternateText = "Ascending Order";
            }
            else
            {
                sortImage.ImageUrl = "Images/up.jpg";
                sortImage.Height = 20;
                sortImage.Width = 20;
                sortImage.AlternateText = "Descending Order";
            }
            headerRow.Cells[iCol].Controls.Add(sortImage);
        }

        int GetSortColumnIndex(String strCol)
        {
            foreach (DataControlField field in GridView1.Columns)
            {
                if (field.SortExpression == strCol)
                {
                    return GridView1.Columns.IndexOf(field);
                }
            }
            return -1;
        }
    }
}