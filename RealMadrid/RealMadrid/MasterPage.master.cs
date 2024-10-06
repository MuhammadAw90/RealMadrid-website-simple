using System;
using System.Data;
using System.Web.UI.WebControls;

namespace RealMadrid
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillNews();
            FillFooter();
            if (Session["ValidUser"] != null &&
               ((bool)Session["ValidUser"]) == true)
            {
                if (Session["Admin"] == null)
                {
                    Menu2.Visible = false;
                    RenameMenuItem("Logout");
                }

                else
                {
                    RenameMenuItem("Logout");
                }
            }

            else
            {
                Menu2.Visible = false;
                RenameMenuItem("Login");
            }
        }


        private void RemoveMenuItem(string strValue)
        {
            MenuItem menuToRemove = Menu1.FindItem(strValue);
            if (menuToRemove != null)
            {
                Menu1.Items.Remove(menuToRemove);
            }
        }

        private void RenameMenuItem(string strText)
        {
            Menu mainmenu = (Menu)FindControl("Menu1");
            if (mainmenu != null)
            {
                MenuItem menuToRename = mainmenu.FindItem("LogInOut");
                if (menuToRename != null && menuToRename.Parent == null)
                {
                    menuToRename.Text = strText;
                }
            }
        }
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Value.Equals("LogInOut"))
            {
                if (e.Item.Text.Equals("Login"))
                    Response.Redirect("Login.aspx");
                else
                {
                    Session["ValidUser"] = false;
                    RenameMenuItem("Login");
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private void FillNews()
        {
            DataTable dt = NewsClass.LatestNews();
            string strTable = "<table><tr>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strTable += "<td><a href=LNew.aspx?ID=" + dt.Rows[i]["MyID"].ToString() + "><h9>";
                strTable += dt.Rows[i]["MyTitle"].ToString() + "</h9></a>";
                strTable += "</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>";
            }
            strTable += "</tr></table>";
            LabelNews.Text = strTable;
        }

        private void FillFooter()
        {
            DataTable dt = UsefulLinksClass.GetALL();
            string strTable = "<table>";
            strTable += "<tr>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strTable += "<td>" + dt.Rows[i]["MyTitle"].ToString();
                strTable += "</td>";
                strTable += "<td><a href=" + dt.Rows[i]["MyURL"].ToString() + "><img src='" + dt.Rows[i]["MyImg"].ToString() + "' height=50 width=50/></a>";
                strTable += "</td></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>";
            }
            strTable += "</tr>";
            strTable += "</table>";
            LabelFooter.Text = strTable;
        }

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Session["ValidUser"] != null &&
               ((bool)Session["ValidUser"]) == true)
            {
                Menu2.Visible = true;
            }
            else Menu2.Visible = false;
        }
    }
}