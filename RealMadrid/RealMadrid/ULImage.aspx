<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ULImage.aspx.cs" Inherits="RealMadrid.ULImage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<h1>UsefulLinks Image Editor</h1>
   <table>
   <tr><td>
       <asp:Label ID="Label1" runat="server" Text="Please Choose The UsefulLink You Want to Change Image"></asp:Label></td>
   <td><asp:DropDownList ID="DropDownListUL" runat="server">
    </asp:DropDownList></td></tr>
    <tr><td>
        <asp:FileUpload ID="FileUpload1" runat="server" /> 
    </td><td>
        <asp:Button ID="ButtonUpload" runat="server" Text="Upload" 
                onclick="ButtonUpload_Click" /> &nbsp; &nbsp;
        <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" 
                onclick="ButtonCancel_Click" />
    </td>
    </tr>
    <tr><td>
        <font color="red">**If you Upload An Image The Old One Will Be Deleted</font>
    </td></tr>
    </table>
    <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
            CellPadding="3" ForeColor="Black" 
            GridLines="Vertical">
            <Columns>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("MyTitle") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="URL">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("MyURL") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Img">
                    <ItemTemplate>
                 <asp:Image ID="Image1" ImageUrl='<%#Eval("MyImg") %>' runat="server" Width="100px" Height="100px" >
                       </asp:Image>
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

