<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="InfoEditor.aspx.cs" Inherits="RealMadrid.InfoEditor" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<h1><b>Here Is An Information Editor</b></h1>
    <asp:Button ID="ButtonNewInfo" runat="server" Text="New Information" 
        onclick="ButtonNewInfo_Click" />
    <br /><br />
    <asp:DropDownList ID="DropDownListType" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownListType_SelectedIndexChanged">
    </asp:DropDownList> <br /><br />
    <asp:Label ID="TextBoxInfo" Width="1000" Height="100" runat="server">
    </asp:Label>
    <br />
    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" 
        onclick="ButtonSave_Click" /> &nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" 
        onclick="ButtonCancel_Click" />&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonDelete" runat="server" Text="Delete" 
        onclick="ButtonDelete_Click" />
        <br />
         <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
</center>
</asp:Content>

