using System;
using System.Data;

namespace RealMadrid
{
    public partial class UpdatePlayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ValidUser"] == null || (bool)Session["ValidUser"] == false)
                    Response.Redirect("Login.aspx");
                else
                {
                    string strID = Request.QueryString["MyPlayerID"].ToString();
                    if (strID != "0")
                        ShowPlayerData(strID);
                }
            }

        }
        protected void Buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExistUser())
                {
                    LabelMsg.Text = "This Player Already Exist";
                    return;
                }
                bool WasOK = false;
                string strID = Request.QueryString["MyPlayerID"].ToString();
                if (strID != "0")
                {
                    WasOK = UpdatePlayerdata(strID);
                }
                else
                {
                    WasOK = SavePlayerdata(strID);
                }
                if (WasOK)
                    Response.Redirect("PlayersEditor.aspx");
            }
            catch (Exception ex)
            {
                LabelMsg.Text = "There Is An Error";
            }

        }


        private void ShowPlayerData(string strID)
        {
            try
            {
                DataTable dt = PlayersClass.PlayerByID(strID);
                if (dt.Rows.Count == 1)
                {
                    TextBoxName.Text = dt.Rows[0]["MyName"].ToString();
                    TextBoxNumber.Text = dt.Rows[0]["MyNumber"].ToString();
                    TextBoxPosition.Text = dt.Rows[0]["MyPosition"].ToString();
                    TextBoxDateOfBirth.Text = ((DateTime)dt.Rows[0]["MyDateOfBirth"]).ToString("dd/MM/yyyy");
                    TextBoxCountry.Text = dt.Rows[0]["MyCountry"].ToString();
                    TextBoxInfo.Text = dt.Rows[0]["MyInfo"].ToString();
                }
            }
            catch (Exception ex)
            {
                LabelMsg.Text = "1";
            }
        }

        private bool UpdatePlayerdata(string strID)
        {
            try
            {
                string Name = TextBoxName.Text;
                string Number = TextBoxNumber.Text;
                string Position = TextBoxPosition.Text;
                string DateOfBirth = TextBoxDateOfBirth.Text;
                string Country = TextBoxCountry.Text;
                string strInfo = TextBoxInfo.Text.Replace("'", "''");
                PlayersClass.UpdatePlayer(Name, Number, Position, DateOfBirth, Country, strInfo, strID);
                return true;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = "2";
                return false;
            }
        }

        private bool SavePlayerdata(string strID)
        {
            try
            {
                string Name = TextBoxName.Text;
                string Number = TextBoxNumber.Text;
                string Position = TextBoxPosition.Text;
                string DateOfBirth = TextBoxDateOfBirth.Text;
                string Country = TextBoxCountry.Text;
                string strInfo = TextBoxInfo.Text.Replace("'", "''");
                PlayersClass.InsertPlayer(Name, Number, Position, DateOfBirth, Country, strInfo);
                return true;
            }
            catch (Exception ex)
            {
                LabelMsg.Text = ex.Message;
                return false;
            }
        }

        private bool ExistUser()
        {
            bool Flag;
            string strID = Request.QueryString["MyPlayerID"].ToString();
            string strName = TextBoxName.Text;
            Flag = PlayersClass.IsPlayerExist(strName, strID);
            return Flag;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlayersEditor.aspx");
        }
    }
}