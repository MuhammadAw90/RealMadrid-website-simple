<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cups.aspx.cs" Inherits="RealMadrid.Trophies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <asp:DataList ID="DataList1" runat="server" BackColor="#CCCCCC" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
        CellSpacing="2"  ForeColor="Black" RepeatColumns="3"
        GridLines="Both">
        <FooterStyle BackColor="#CCCCCC" />
        <ItemTemplate>
            <center>
            <asp:Image ID="Image1" ImageUrl='<%# Eval("MyImg") %>'  runat="server" />
            <br />
            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("MyName") %>' />
            <br />
            Real Madrid Win It 
            <asp:Label ID="NumberLabel" runat="server" Text='<%# Eval("MyNumber") %>' />
            Times
            <br />
            <br />
            </center>
        </ItemTemplate>
        <ItemStyle BackColor="White" />
        <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
    </center>
    
</asp:Content>

