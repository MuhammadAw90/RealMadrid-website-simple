<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Userseditor.aspx.cs" Inherits="RealMadrid.Userseditor" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <asp:GridView ID="GridViewUsers" runat="server" AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="4" DataKeyNames="MyID"
            OnRowDeleting="GridViewUsers_RowDeleting" 
            OnRowUpdating="GridViewUsers_RowUpdating" 
            OnRowCancelingedit="GridViewUsers_RowCancelingEdit"
            OnRowEditing="GridViewUsers_RowEditing" 
            OnSelectedIndexChanging="GridViewUsers_SelectedIndexChanging"
            ShowFooter="true"
            CellSpacing="2" AllowSorting="False" ForeColor="Black">
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
                        <asp:Label ID="LabelInsertID" runat="server" Text=""></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fname">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxFname" runat="server" Text='<%# Bind("MyFname") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV1" runat="server" ErrorMessage="First Name Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxFname" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelFname" runat="server" Text='<%# Bind("MyFname") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertFname" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RFV2" ValidationGroup="Insert" runat="server" ErrorMessage="First Name Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxInsertFname" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Lname">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxLname" runat="server" Text='<%# Bind("MyLname") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV3" runat="server" ErrorMessage="Last Name Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxLname" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelLname" runat="server" Text='<%# Bind("MyLname") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertLname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ValidationGroup="Insert" ID="RFV4" runat="server" ErrorMessage="Last Name Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxInsertLname" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DateOfBirth">
                    <EditItemTemplate>
                         <asp:TextBox ID="TextBoxDateOfBirth" runat="server" Text='<%# Bind("MyDateOfBirth") %>'></asp:TextBox>
                        <asp:RangeValidator ID="RV1" runat="server" ErrorMessage="Date Of Birth Is Required Field" Type="Date"
                         ControlToValidate="TextBoxDateOfBirth" Display="Dynamic" Text="*" MinimumValue="1/1/1900" MaximumValue="1/1/2023"></asp:RangeValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelDateOfBirth" runat="server" Text='<%# Bind("MyDateOfBirth") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertDateOfBirth" runat="server"></asp:TextBox>
                         <asp:RangeValidator ID="RV2" ValidationGroup="Insert" runat="server" ErrorMessage="Date Of Birth Is Required Field" Type="Date"
                         ControlToValidate="TextBoxInsertDateOfBirth" Display="Dynamic" Text="*" MinimumValue="1/1/1900" MaximumValue="1/1/2023"></asp:RangeValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                         <asp:TextBox ID="TextBoxEmail" runat="server" Text='<%# Bind("MyEmail") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RFV9" runat="server" ErrorMessage="Email Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxEmail" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelEmail" runat="server" Text='<%# Bind("MyEmail") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertEmail" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ValidationGroup="Insert" ID="RFV10" runat="server" ErrorMessage="Email Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxInsertEmail" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Gender">
                    <EditItemTemplate>
                         <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" 
                               GroupName="Gender" Checked="True"/><br />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" 
                             GroupName="Gender"/> 
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelGender" runat="server" Text='<%# Bind("MyGender") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="Male" 
                               GroupName="Gender" Checked="True"/> <br />
                        <asp:RadioButton ID="RadioButton4" runat="server" Text="Female" 
                             GroupName="Gender"/> 
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Username">
                    <EditItemTemplate>
                         <asp:TextBox ID="TextBoxusername" runat="server" Text='<%# Bind("Myusername") %>'></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RFV5" runat="server" ErrorMessage="UserName Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxusername" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Labelusername" runat="server" Text='<%# Bind("Myusername") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertusername" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ValidationGroup="Insert" ID="RFV6" runat="server" ErrorMessage="UserName Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxInsertusername" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="password">
                    <EditItemTemplate>
                         <asp:TextBox ID="TextBoxpw" runat="server" Text='<%# Bind("Mypw") %>'></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RFV7" runat="server" ErrorMessage="Password Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxpw" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Labelpw" runat="server" Text='<%# Bind("Mypw") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBoxInsertpw" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ValidationGroup="Insert" ID="RFV8" runat="server" ErrorMessage="Password Is Required Field" ForeColor="Red"
                         ControlToValidate="TextBoxInsertpw" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Admin">
                    <EditItemTemplate>
                   <asp:DropDownList ID="DropDownListEditAdmin" runat="server">
                          <asp:ListItem>Yes</asp:ListItem>
                          <asp:ListItem>No</asp:ListItem>
                      </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LabelAdmin" runat="server" Text='<%# Bind("MyAdmin") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="DropDownListInsertAdmin" runat="server">
                          <asp:ListItem>Yes</asp:ListItem>
                          <asp:ListItem>No</asp:ListItem>
                      </asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButtonDelete" CommandName="Delete" OnClientClick="return confirm('Are You Sure?');" runat="server">Delete</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonEdit" CommandName="Edit" runat="server">Edit</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonSelect" CommandName="Select" runat="server">Select</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButtonUpdate" CommandName="Update" runat="server">Update</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonCancel" CommandName="Cancel" runat="server">Cancel</asp:LinkButton>
                </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle ForeColor="Black" HorizontalAlign="Left" BackColor="#CCCCCC" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    <br />
        <asp:Label ID="LabelMsg" ForeColor="Red" runat="server" Text=""></asp:Label>
</center>
</asp:Content>

