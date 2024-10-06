<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="RealMadrid.News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><h1>Here Is The News Page</h1></center>
    <asp:Label ID="LabelNews" runat="server" Text="LabelNews"></asp:Label>
    <br /><br />
    <center><asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label></center>
    
</asp:Content>

