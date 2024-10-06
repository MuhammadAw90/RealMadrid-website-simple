<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ImagesEditor.aspx.cs" Inherits="RealMadrid.ImagesEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
<center>
<br /><br />
    <asp:Label ID="LabelDescription" runat="server" Text="Description :"></asp:Label>
    <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox><br />
    <asp:Label ID="LabelUpload" runat="server" Text="Upload New Image :"></asp:Label>&nbsp; &nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" /> &nbsp; &nbsp;
    <asp:Button ID="ButtonUpload" runat="server" Text="Upload" onclick="ButtonUpload_Click" /> 
    <br /><br />
<asp:GridView ID="GridViewImages" runat="server" CellPadding="3" AutoGenerateColumns="False"
    ForeColor="Black" GridLines="Vertical" Caption="Images"
    onrowdeleting="GridViewImages_RowDeleting" 
    onselectedindexchanged="GridViewImages_SelectedIndexChanged" 
    onrowdatabound="GridViewImages_RowDataBound" BackColor="White" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
    <FooterStyle BackColor="#CCCCCC"/>
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"/>
    <AlternatingRowStyle BackColor="#CCCCCC" />
    <Columns>
    <asp:TemplateField HeaderText="ID">
    <ItemTemplate> <asp:Label ID="LabelID" runat="server" Text='<%#Bind("MyID") %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="FileName">
    <ItemTemplate>
    <asp:Label ID="LabelFileName" runat="server" Text='<%#Bind("MyFileName") %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="FileSize">
    <ItemTemplate>
    <asp:Label ID="LabelFileSize" runat="server" Text='<%#Bind("MyFileSize") %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Description">
    <ItemTemplate>
    <asp:Label ID="LabelDescription" runat="server" Text='<%#Bind("MyDescription") %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="UploadDate">
    <ItemTemplate>
    <asp:Label ID="LabelUploadDate" runat="server" Text='<%#Bind("MyUploadDate") %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Type">
    <ItemTemplate>
    <asp:Label ID="LabelType" runat="server" Text='<%#Bind("MyType") %>'></asp:Label>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Image">
    <ItemTemplate>
    <asp:Image ID="Image1" ImageUrl='<%#Eval("MyFileName") %>' runat="server" Width="100px" Height="100px"></asp:Image>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Download">
    <ItemTemplate>
    <asp:HyperLink ID="HyperLinkFileName" NavigateUrl='<%#Bind("MyFileName") %>'
    Text="Download" runat="server">
    </asp:HyperLink>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Delete">
    <ItemTemplate>
    <asp:LinkButton ID="LinkButtonDelete" CausesValidation="False"
    CommandName="Delete"
    OnClientClick='return confirm("Are you sure?")'
    runat="server">Delete</asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField></asp:TemplateField>
    </Columns>
    </asp:GridView>
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    </center>
</asp:Content>

