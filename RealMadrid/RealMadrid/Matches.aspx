<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Matches.aspx.cs" Inherits="RealMadrid.Matches" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ClubID" onrowcommand="GridView1_RowCommand" BackColor="White" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
            ForeColor="Black" GridLines="Vertical">
        <Columns>
            <asp:TemplateField HeaderText="ClubID" InsertVisible="False" 
                SortExpression="ClubID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ClubID") %>'></asp:Label> 
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country" SortExpression="Country">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("MyCountry") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cname" SortExpression="Cname">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("MyCname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
            <ItemTemplate>
                        <asp:LinkButton ID="LinkButtonSHOW" CommandName="SHOW" CommandArgument='<%# Bind("ClubID") %>'  runat="server">Show maches</asp:LinkButton>
        
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#CCCCCC" />
    </asp:GridView>
    <br /><br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" BackColor="White" BorderColor="#999999" BorderStyle="Solid" 
            BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <Columns>
            <asp:TemplateField HeaderText="ID" Visible="false" InsertVisible="False" SortExpression="ID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="VS" SortExpression="VS">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("MyVS") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Place" SortExpression="Place">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("MyPlace") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hour" SortExpression="Hour">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("MyHour") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date1" SortExpression="Date">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("MyDate1") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ClubID" Visible="false" SortExpression="ClubID">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("MyClubID") %>'></asp:Label>
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

