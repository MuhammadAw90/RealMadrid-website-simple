using System;

namespace RealMadrid
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillMonthDDL();
                FillYearsDDL();
                FillDaysDDL();
            }
        }

        protected void DropDownListMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDaysDDL();
        }


        protected void DropDownListYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDaysDDL();
        }

        protected void DropDownListDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillMonthDDL()
        {
            DropDownListMonths.Items.Clear();
            for (int i = 1; i <= 12; i++)
                DropDownListMonths.Items.Add(i.ToString());
        }

        private void FillYearsDDL()
        {
            DropDownListYears.Items.Clear();
            for (int i = 1965; i <= 2010; i++)
                DropDownListYears.Items.Add(i.ToString());
        }

        private void FillDaysDDL()
        {
            DropDownListDays.Items.Clear();
            int month = int.Parse(DropDownListMonths.SelectedValue.ToString());
            int year = int.Parse(DropDownListYears.SelectedValue.ToString());
            int days = GetNumOfDays(month, year);
            for (int i = 1; i <= days; i++)
                DropDownListDays.Items.Add(i.ToString());
        }

        private int GetNumOfDays(int month, int year)
        {
            switch (month)
            {
                case 1: return 31;
                case 2:
                    if (IsLeapYear(year)) return 29;
                    else return 28;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
            }
            return 0;
        }

        private bool IsLeapYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }

        private string ShowSelectedDate()
        {
            string strDate = DropDownListDays.Text + "/" + DropDownListMonths.Text + "/" + DropDownListYears.Text;
            return strDate;
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void ButtonSignUp_Click(object sender, EventArgs e)
        {
            string strFname = TextBoxFname.Text;
            string strLname = TextBoxLname.Text;
            string strDateOfBirth = ShowSelectedDate();
            string strEmail = TextBoxEmail.Text;
            string strGender;
            if (RadioButton1.Checked)
            {
                strGender = RadioButton1.Text;
            }
            else strGender = RadioButton2.Text;
            string strUsername = TextBoxUserName.Text;
            string strPW = TextBoxPW.Text;
            if (UsersClass.IfUserExist(strUsername))
            {
                LabelMsgUsername.Text = "Sorry But This Is Exist UserName";
            }
            else
            {
                UsersClass.InsertUser1(strFname, strLname, strDateOfBirth, strEmail, strGender, strUsername, strPW, "No");
                Session["ValidUser"] = true;
                Response.Redirect("Default.aspx");
            }
        }
    }
}