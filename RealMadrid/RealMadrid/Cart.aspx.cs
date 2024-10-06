using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                DataTable dt = CartClass.GetAll();
                GridViewItems.DataSource = dt;
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
                if (e.CommandName.Equals("RemoveFromCart"))
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

        protected void ButtonSignUp_Buy(object sender, EventArgs e)
        {
            
        }
    }
}
