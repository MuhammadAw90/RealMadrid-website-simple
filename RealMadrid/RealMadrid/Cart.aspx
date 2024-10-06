<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="RealMadrid.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h1>This is the cart</h1>
        <asp:GridView ID="GridViewItems" runat="server" AutoGenerateColumns="False"
            DataKeyNames="ID" BackColor="White" BorderColor="#999999"
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
            GridLines="Vertical"
            OnRowCommand="GridViewItems_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="LabelID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="LabelName" runat="server" Text='<%# Bind("ItemName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label ID="LabelNumber" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="ButtonAdd" Text="remove From Cart" CommandArgument='<%# Bind("ID") %>' CommandName="RemoveFromCart" runat="server"></asp:Button>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#CCCCCC" />
        </asp:GridView>
        <asp:Button ID="BuyButton" runat="server" Text="Buy"
            OnClick="ButtonSignUp_Buy" />
        &nbsp; &nbsp;
    </center>
    <br />
    <br />
    <center>
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label></center>

</asp:Content>
