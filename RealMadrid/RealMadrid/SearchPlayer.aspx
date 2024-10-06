<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchPlayer.aspx.cs" Inherits="RealMadrid.SearchPlayer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<h1>This Is The Search Page</h1>
<table border=0>
<tr>
    <td><asp:Label ID="LabelNumber" runat="server" Text="Search By Number"></asp:Label>&nbsp;&nbsp;</td>
    <td><asp:DropDownList ID="DropDownListNumber" runat="server" AutoPostBack="true" 
            onselectedindexchanged="DropDownListNumber_SelectedIndexChanged"></asp:DropDownList> &nbsp;&nbsp;</td>
    </tr>
    <tr>
    <td><asp:Label ID="LabelName" runat="server" Text="Search By Name"></asp:Label>&nbsp;&nbsp;</td>
    <td><asp:DropDownList ID="DropDownListName" runat="server" AutoPostBack="true" 
            onselectedindexchanged="DropDownListName_SelectedIndexChanged"></asp:DropDownList>&nbsp;&nbsp;</td>
    </tr>
    </table>
    <br />
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    <br />
    <br /><br />
        <asp:Label ID="LabelData" runat="server" Text=""></asp:Label>
</center>
</asp:Content>

