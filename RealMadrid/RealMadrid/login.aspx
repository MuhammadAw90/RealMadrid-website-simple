<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="RealMadrid.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <table border="5">
            <tr>
                <td>username</td>
                <td>
                    <asp:TextBox ID="TextBoxusername" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>password</td>
                <td>
                    <asp:TextBox ID="TextBoxpassword" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><center>
                    <asp:Button ID="Buttonlogin" runat="server" Text="Login"
                        OnClick="Buttonlogin_Click" Width="53px" />
                    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Buttonreset" runat="server" Text="Reset" Width="54px"
        OnClick="Buttonreset_Click" />
               </center> </td>
            </tr>
            <tr>
                <td colspan="3">
                    <center>
                        <asp:LinkButton ID="LinkButtonSignUp" runat="server" Text ="Sign Up" OnClick="LinkButtonSignUp_Click"/></center>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Labelmessega" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </center>
</asp:Content>

