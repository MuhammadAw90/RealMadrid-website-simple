<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CommentsEditor.aspx.cs" Inherits="RealMadrid.CommentsEditor" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="MYID" 
        ForeColor="Black" GridLines="Vertical" Caption="Available Comments" 
        ShowFooter="True" onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowdeleting="GridView1_RowDeleting" 
        onrowediting="GridView1_RowEditing" 
        onrowupdating="GridView1_RowUpdating">
        <Columns>
        <asp:TemplateField HeaderText="Add Comment">
        <FooterTemplate>
            <asp:LinkButton ID="LinkButtonAdd" OnClick="Add" runat="server">Add Comment</asp:LinkButton> 
        </FooterTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="ID" Visible="False">
             <EditItemTemplate>
             <asp:Label ID="LabelEditID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
             </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
            <EditItemTemplate>
                <asp:TextBox ID="TextBoxName" runat="server" Text='<%# Bind("MyName") %>'></asp:TextBox>
            </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelName" runat="server" Text='<%# Bind("MyName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxInsertName" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <EditItemTemplate>
                <asp:TextBox ID="TextBoxCity" runat="server" Text='<%# Bind("MyCity") %>'></asp:TextBox>
            </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelCity" runat="server" Text='<%# Bind("MyCity") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxInsertCity" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title">
                 <EditItemTemplate>
                <asp:TextBox ID="TextBoxTitle" runat="server" Text='<%# Bind("MyTitle") %>'></asp:TextBox>
            </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelTitle" runat="server" Text='<%# Bind("MyTitle") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxInsertTitle" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Data">
          <EditItemTemplate>
                <asp:TextBox ID="TextBoxData" runat="server" Text='<%# Bind("MyData") %>'></asp:TextBox>
            </EditItemTemplate>
          <ItemTemplate>
                    <asp:Label ID="LabelData" runat="server" Text='<%# Bind("MyData") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxInsertData" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButtonDelete" CommandName="Delete" OnClientClick="return confirm('Are You Sure?');" runat="server">Delete</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonEdit" CommandName="Edit" runat="server">Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButtonUpdate" CommandName="Update" runat="server">Update</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonCancel" CommandName="Cancel" runat="server">Cancel</asp:LinkButton>
                </EditItemTemplate>
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

