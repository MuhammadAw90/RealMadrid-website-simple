<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="images.aspx.cs" Inherits="RealMadrid.images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <asp:Label ID="Label1" runat="server" Text="Please Select The Player Name"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownListFileType" runat="server" AutoPostBack="True" onselectedindexchanged="DropDownListFileType_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
        <asp:GridView ID="GridViewFiles" runat="server" CellPadding="3" AutoGenerateColumns="False"
    ForeColor="Black" GridLines="Vertical" Caption="Available Files"
    onselectedindexchanged="GridViewFiles_SelectedIndexChanged" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" >
    <FooterStyle BackColor="#CCCCCC"/>
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"/>
    <AlternatingRowStyle BackColor="#CCCCCC" />
    <Columns>

    
    <asp:TemplateField HeaderText="Image">
    <ItemTemplate>
    <asp:Image ID="Image1" ImageUrl='<%#Eval("MyFileName") %>' runat="server" Width="500px" Height="500px"></asp:Image>
    </ItemTemplate>
    </asp:TemplateField>

    </Columns>
    </asp:GridView>
    <br />
    <br />  
    <br />
  
  
  
</center>  
        </asp:Content>

