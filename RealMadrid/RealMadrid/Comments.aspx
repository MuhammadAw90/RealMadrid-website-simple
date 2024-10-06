<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Comments.aspx.cs" Inherits="RealMadrid.Comments" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <asp:GridView ID="GridViewComments" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="MyID" 
        ForeColor="Black" GridLines="Vertical" Caption="Available Comments" 
        ShowFooter="True">
        <Columns>
        <asp:TemplateField HeaderText="Add Comment">
        <FooterTemplate>
            <asp:LinkButton ID="LinkButtonAdd" OnClick="Add" runat="server" ValidationGroup="AddComment">AddComment</asp:LinkButton> 
        </FooterTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="ID" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="LabelName" runat="server" Text='<%# Bind("MyName") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*" ValidationGroup="AddComment"
                        Display="Dynamic" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxName">
                    </asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:Label ID="LabelCity" runat="server" Text='<%# Bind("MyCity") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*" ValidationGroup="AddComment"
                        Display="Dynamic" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxCity">
                    </asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title">
                <ItemTemplate>
                    <asp:Label ID="LabelData" runat="server" Text='<%# Bind("MyTitle") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="*" ValidationGroup="AddComment"
                        Display="Dynamic" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxTitle">
                    </asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Data">
          <ItemTemplate>
                    <asp:Label ID="LabelData" runat="server" Text='<%# Bind("MyData") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxData" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="*" ValidationGroup="AddComment"
                        Display="Dynamic" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxData">
                    </asp:RequiredFieldValidator>
                </FooterTemplate>
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

