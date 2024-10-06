<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="SendMessage.aspx.cs" Inherits="RealMadrid.SendMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
<tr>
<td>
    <asp:Label ID="LabelSelectUser" runat="server" Text="Select User :"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownListUsers" runat="server">
    </asp:DropDownList>
</td>
</tr> 
<tr><td>
    <asp:Label ID="LabelTitle" runat="server" Text="Title :"></asp:Label>
</td><td>
    <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
</td></tr>
<tr><td>
    <asp:Label ID="LabelBody" runat="server" Text="Body :"></asp:Label>
</td><td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</td></tr>
<tr>
<td colspan="2">
<center>  <asp:Button ID="ButtonSave" runat="server" Text="Send" 
        onclick="ButtonSave_Click" /> &nbsp; &nbsp; &nbsp;
  <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" 
        onclick="ButtonCancel_Click" /></center>
</td></tr>
</table>
    <center><asp:Label ID="LabelMsg" runat="server" ForeColor="Red" Text=""></asp:Label></center>
</asp:Content>