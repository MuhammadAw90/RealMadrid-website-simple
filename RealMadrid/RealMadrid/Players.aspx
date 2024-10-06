<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Players.aspx.cs" Inherits="RealMadrid.Players" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<h1>This Is Players Editor Page</h1>
<br /><br />
    <asp:Label ID="LabelSeeAll" runat="server" ForeColor="Red" Text="To See All Player Information Click on 'See All'"></asp:Label>
    <asp:GridView ID="GridViewPlayers" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="MyPlayerID" BackColor="White" BorderColor="#999999" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" 
        GridLines="Vertical"
        onselectedindexchanging="GridViewPlayers_SelectedIndexChanging" 
        onrowcommand="GridViewPlayers_RowCommand">
        <Columns> 
        <asp:TemplateField HeaderText="ID" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyPlayerID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="LabelName" runat="server" Text='<%# Bind("MyName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number">
                <ItemTemplate>
                    <asp:Label ID="LabelNumber" runat="server" Text='<%# Bind("MyNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Position">
                <ItemTemplate>
                    <asp:Label ID="LabelPosition" runat="server" Text='<%# Bind("MyPosition") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DateOfBirth">
                <ItemTemplate>
                    <asp:Label ID="LabelDateOfBirth" runat="server" Text='<%# Bind("MyDateOfBirth") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country">
                <ItemTemplate>
                    <asp:Label ID="LabelCountry" runat="server" Text='<%# Bind("MyCountry") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                       <asp:Label ID="LabelImage" runat="server" Text="**"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Information">
                <ItemTemplate>
                    <asp:Label ID="LabelInfo" runat="server" Text="**"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButtonSeeAll" CommandArgument='<%# Bind("MyPlayerID") %>' CommandName="SeeAll" runat="server">See All</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#CCCCCC" />
    </asp:GridView>
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
</center>
</asp:Content>