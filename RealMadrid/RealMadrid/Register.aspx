<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="RealMadrid.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1 {
            width: 242px;
        }

        .style2 {
            width: 194px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h1><b>This Is Register Page</b></h1>
        <br />
        <br />
        <table border="5">
            <tr>
                <td>
                    <asp:Label ID="LabelFname" runat="server" Text="First Name:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBoxFname" runat="server" Style="margin-left: 0px"
                        Width="228px"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RFV1" runat="server" ControlToValidate="TextBoxFname" ErrorMessage="First Name Is Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelLname" runat="server" Text="Last Name:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBoxLname" runat="server" Width="227px"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RFV2" runat="server" ControlToValidate="TextBoxLname" ErrorMessage="Last Name Is Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelDateOfBirth" runat="server" Text="Date Of Birth:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:DropDownList ID="DropDownListYears" runat="server" AutoPostBack="True"
                        OnSelectedIndexChanged="DropDownListYears_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownListMonths" runat="server" AutoPostBack="True"
                        OnSelectedIndexChanged="DropDownListMonths_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownListDays" runat="server" AutoPostBack="True"
                        OnSelectedIndexChanged="DropDownListDays_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBoxEmail" runat="server" Width="223px"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RFV3" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email Is Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelGender" runat="server" Text="Gender :"></asp:Label></td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male"
                        GroupName="Gender" Checked="True" />
                    &nbsp; &nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female"
                        GroupName="Gender" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelUserName" runat="server" Text="UserName:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBoxUserName" runat="server" Width="225px"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RFV4" runat="server" ControlToValidate="TextBoxUserName" ErrorMessage="UserName Is Required Field"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="LabelMsgUsername" runat="server" ForeColor="Red" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelPW" runat="server" Text="Password:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="TextBoxPW" runat="server" Width="221px"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RFV5" runat="server" ControlToValidate="TextBoxPW" ErrorMessage="Password Is Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="ButtonSignUp" runat="server" Text="Sign Up"
                        OnClick="ButtonSignUp_Click" />
                    &nbsp; &nbsp;
    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel"
        OnClick="ButtonCancel_Click" CausesValidation="false" />
                </td>
            </tr>
        </table>
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    </center>
</asp:Content>
