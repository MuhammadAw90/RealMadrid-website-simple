<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UsefulLinksEditor.aspx.cs" Inherits="RealMadrid.UsefullLinksEditor" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center>
    <asp:GridView ID="GridViewUL" runat="server" AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="4" DataKeyNames="MyID" onrowdeleting="GridViewUL_RowDeleting" 
            onrowupdating="GridViewUL_RowUpdating" 
            onrowcancelingedit="GridViewUL_RowCancelingEdit" 
            onrowediting="GridViewUL_RowEditing" 
            onselectedindexchanging="GridViewUL_SelectedIndexChanging" ShowFooter=True
            CellSpacing="2" AllowSorting="False" ForeColor="Black" 
             onrowcommand="GridViewUL_RowCommand">
            <RowStyle BackColor="White" />
            <Columns>
               <asp:TemplateField HeaderText="">
                <FooterTemplate>
                    <asp:LinkButton ID="LinkButtonInsert" ValidationGroup="Insert" OnClick="Insert" runat="server">Insert</asp:LinkButton>
                </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ID" InsertVisible="False">
                    <EditItemTemplate>
                        <asp:Label ID="LabelEditID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:Label ID="LabelInsertID" runat="server" Text="**"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Title">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxTitle" runat="server" Text='<%# Bind("MyTitle") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFVTitle" runat="server" ErrorMessage="Title Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxTitle" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelTitle" runat="server" Text='<%# Bind("MyTitle") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertTitle" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RFVTitle1" ValidationGroup="Insert" runat="server" ErrorMessage="Title Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxInsertTitle" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="URL">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxURL" runat="server" Text='<%# Bind("MyURL") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFVURL" runat="server" ErrorMessage="URL Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxURL" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelURL" runat="server" Text='<%# Bind("MyURL") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertURL" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFVURL1" ValidationGroup="Insert" runat="server" ErrorMessage="URL Is Required Field" ForeColor="Red" 
                        ControlToValidate="TextBoxInsertURL" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date">
                    <EditItemTemplate>
                         <asp:Label ID="LabelEditDate" runat="server" Text=""></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelDate" runat="server" Text='<%# Bind("MyDate") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                       <asp:Label ID="LabeInsertDate" runat="server" Text="**"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Icon Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" ImageUrl='<%#Eval("MyImg") %>' runat="server" Width="100px" Height="100px" >
                       </asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButtonDelete" CommandName="Delete" OnClientClick="return confirm('Are You Sure?');" runat="server">Delete</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonEdit" CommandName="Edit" runat="server">Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButtonUpdate" CommandName="Update" runat="server">Update</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonCancel" CausesValidation="false" CommandName="Cancel" runat="server">Cancel</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonImage" CausesValidation="false" CommandName="Change" runat="server">Change Image</asp:LinkButton>
                </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle ForeColor="Black" HorizontalAlign="Left" BackColor="#CCCCCC" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    <br />
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please Fix The Following Errors:" />
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
</center>
</asp:Content>

