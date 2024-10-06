<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlayerInfo.aspx.cs" Inherits="RealMadrid.PlayerInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <asp:Label ID="LabelInfo" runat="server" Text=""></asp:Label>
    <asp:Label ID="Image" runat="server" Text=""></asp:Label><br /><br />
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    </center>    
</asp:Content> 