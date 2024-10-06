using System;
using System.Data;
using System.Reflection.Emit;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillItems();
            }
        }

        private void NoRepeat(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i]["ItemID"].ToString() == dt.Rows[i + 1]["ItemID"].ToString())
                {
                    dt.Rows.RemoveAt(i);
                }
            }
        }

        private void FillItems()
        {
            try
            {
                DataTable dt = ShopItems.GetAll();
                GridViewItems.DataSource = dt;
                NoRepeat(dt);
                GridViewItems.DataBind();
            }
            catch (Exception e)
            {
                LabelMsg.Text = e.Message;
            }
        }

        protected void GridViewItems_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddToCart"))
                {
                    string ItemId = e.CommandArgument.ToString();
                    DataTable dt = ShopItems.GetItem(ItemId);
                    var name = dt.Rows[0].ItemArray[1].ToString();
                    var price = dt.Rows[0].ItemArray[2].ToString();
                    var quantity = "1";
                    CartClass.Insert(name, quantity, price);
                }
            }

            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
            }
        }


        protected void ButtonAdd_Click()
        {

        }
    }
}