<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Shop.aspx.cs" Inherits="RealMadrid.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h1>Welcome to the shop</h1>
        <asp:GridView ID="GridViewItems" runat="server" AutoGenerateColumns="False"
            DataKeyNames="ItemID" BackColor="White" BorderColor="#999999"
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
            GridLines="Vertical"
            OnRowCommand="GridViewItems_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="LabelID" runat="server" Text='<%# Bind("ItemID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="LabelName" runat="server" Text='<%# Bind("MyItem") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="LabelNumber" runat="server" Text='<%# Bind("ItemPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                        <asp:Image ID="Picture" ImageUrl='<%# Eval("ItemPicture") %>'  runat="server" height=100 width=100 />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="ButtonAdd" Text="Add To Cart" CommandArgument='<%# Bind("ItemID") %>' CommandName="AddToCart" runat="server"></asp:Button>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#CCCCCC" />
        </asp:GridView>
    </center>
    <br />
    <br />
    <center>
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label></center>

</asp:Content>

