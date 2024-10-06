<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewsEditor.aspx.cs" Inherits="RealMadrid.NewsEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Here Is The News Editor Page</h1>
<center>
    <asp:Button ID="ButtonNew" runat="server" Text="Add New" 
        onclick="ButtonNew_Click" /><br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
        DataKeyNames="MyID"  ForeColor="Black"
        GridLines="Vertical"
        onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        onrowcreated="GridView1_RowCreated" 
        onpageindexchanging="GridView1_PageIndexChanging" 
        onsorting="GridView1_Sorting"> 
        <Columns>
            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID">
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Img" SortExpression="Img">
                <ItemTemplate>
                  <asp:Image ID="Image1" ImageUrl='<%# Bind("MyImg") %>' runat="server" Height="150" Width="150" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title" SortExpression="Title">
                <ItemTemplate>
                    <asp:Label ID="LabelTitle" runat="server" Text='<%# Bind("MyTitle") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Body" SortExpression="Body">
                <ItemTemplate>
                    <asp:Label ID="LabelBody" runat="server" Text='<%# Bind("MyBody") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete" OnClientClick="return confirm('Are You Sure?');">Delete</asp:LinkButton>
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

