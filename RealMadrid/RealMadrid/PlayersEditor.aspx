<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlayersEditor.aspx.cs" Inherits="RealMadrid.PlayersEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div dir="ltr">
    <center>
        <asp:Button ID="ButtonAdd" runat="server" Text="Add new Player" 
            onclick="ButtonAdd_Click" />
    <br />
    <asp:GridView ID="GridViewPlayers" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="MyPlayerID"
    onrowcancelingedit="GridViewPlayers_RowCancelingEdit" 
    onrowdeleting="GridViewPlayers_RowDeleting" 
    onrowediting="GridViewPlayers_RowEditing" 
    onrowupdating="GridViewPlayers_RowUpdating"
    onselectedindexchanging="GridViewPlayers_SelectedIndexChanging"
     ForeColor="Black" GridLines="Vertical">
        <Columns>
            <asp:TemplateField HeaderText="PlayerID">
               <EditItemTemplate> 
                    <asp:Label ID="LabelEditID" runat="server" Text='<%# Eval("MyPlayerID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyPlayerID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxName" runat="server" Text='<%# Bind("MyName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelName" runat="server" Text='<%# Bind("MyName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxNumber" runat="server" Text='<%# Bind("MyNumber") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelNumber" runat="server" Text='<%# Bind("MyNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Position">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxPosition" runat="server" Text='<%# Bind("MyPosition") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelPosition" runat="server" Text='<%# Bind("MyPosition") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DateOfBirth">
               <EditItemTemplate>
                    <asp:TextBox ID="TextBoxDateOfBirth" runat="server" Text='<%# Bind("MyDateOfBirth") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelDateOfBirth" runat="server" Text='<%# Bind("MyDateOfBirth") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country">
              <EditItemTemplate>
                    <asp:TextBox ID="TextBoxCountry" runat="server" Text='<%# Bind("MyCountry") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelCountry" runat="server" Text='<%# Bind("MyCountry") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Info">
             <EditItemTemplate>
                    <asp:TextBox ID="TextBoxInfo" runat="server" Text='<%# Bind("MyInfo") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LabelInfo" runat="server" Text='<%# Bind("MyInfo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete" OnClientClick="return confirm('Are You Sure?');">Delete</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Select">Select</asp:LinkButton>
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
    </div>
    </center>
</asp:Content>

