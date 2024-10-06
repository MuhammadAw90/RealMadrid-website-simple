<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CupsEditor.aspx.cs" Inherits="RealMadrid.CupsEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
<center>
    <asp:GridView ID="GridViewCups" runat="server" AutoGenerateColumns="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" DataKeyNames="MyID"
        ForeColor="Black" ShowFooter="True"
        onrowdeleting="GridViewCups_RowDeleting" 
            onrowupdating="GridViewCups_RowUpdating" 
            onrowcancelingedit="GridViewCups_RowCancelingEdit" 
            onrowediting="GridViewCups_RowEditing" 
            onselectedindexchanging="GridViewCups_SelectedIndexChanging"
            onrowcommand="GridViewCups_RowCommand" CellSpacing="2">
        <FooterStyle BackColor="#CCCCCC" />
        <RowStyle BackColor="White" />
        <Columns>
         <asp:TemplateField HeaderText="">
              <FooterTemplate>
                   <asp:LinkButton ID="LinkButtonInsert" ValidationGroup="Insert" OnClick="Insert" runat="server">Insert</asp:LinkButton>
              </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="LabelEditID" runat="server" Text='<%# Eval("MyID") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Img">
                <ItemTemplate>
                    <asp:Image ID="Image1" ImageUrl='<%# Bind("MyImg") %>' runat="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButtonChangePic" CausesValidation="false" CommandName="Change" runat="server">Change Image</asp:LinkButton>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="LabelName" runat="server" Text='<%# Bind("MyName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxName" runat="server" Text='<%# Bind("MyName") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVName" runat="server" ErrorMessage="The Name Of The Cup Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxName" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxInsertName" runat="server"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="RFVInsertName" ValidationGroup="Insert" runat="server" ErrorMessage="The Name Of The Cup Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxInsertName" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number">
                <ItemTemplate>
                    <asp:Label ID="LabelNumber" runat="server" Text='<%# Bind("MyNumber") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBoxNumber" runat="server" Text='<%# Bind("MyNumber") %>'></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RFVNumber" runat="server" ErrorMessage="The Number Of The Cup Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxNumber" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBoxInsertNumber" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVInsertNumber" ValidationGroup="Insert" runat="server" ErrorMessage="The Number Of The Cup Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxInsertNumber" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButtonDelete" CommandName="Delete" OnClientClick="return confirm('Are You Sure?');" runat="server">Delete</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonEdit" CommandName="Edit" runat="server">Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButtonUpdate" CommandName="Update" runat="server">Update</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonCancel" CausesValidation="false" CommandName="Cancel" runat="server">Cancel</asp:LinkButton>
                </EditItemTemplate>
                </asp:TemplateField>
        </Columns>
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
      <br />
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please Fix The Following Errors:" />
         <asp:ValidationSummary ID="ValidationSummary2" ValidationGroup="Insert" runat="server" HeaderText="Please Fix The Following Errors:" />
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    </center>
</asp:Content>

