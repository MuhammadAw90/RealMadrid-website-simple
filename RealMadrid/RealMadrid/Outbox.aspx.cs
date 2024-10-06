using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Outbox : System.Web.UI.Page
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
                DataTable dt = MessagesClass.GetAllOutbox(Session["ValidUserID"].ToString());
                GridView1.DataSource = dt;
                GVDataSource = dt;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }


        private void SortGridView(string sortExpression, string direction)
        {
            if (GVDataSource == null)
                return;
            DataView dv = new DataView(GVDataSource);
            dv.Sort = sortExpression + " " + direction;
            this.GridView1.DataSource = dv;
            GridView1.DataBind();
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

        public string SortExpression
        {
            get
            {
                if (ViewState["m_Sortexpresion"] == null)
                    ViewState["m_Sortexpresion"] =
                    this.GridView1.DataKeyNames[0].ToString();
                return ViewState["m_Sortexpresion"].ToString();
            }
            set
            {
                ViewState["m_Sortexpresion"] = value;
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
            Response.Redirect("SendMessage.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label strID = (Label)GridView1.Rows[e.RowIndex].FindControl("LabelID");
            MessagesClass.DeleteOutBox(strID.Text);
            FillGridView();
        }
    }
}