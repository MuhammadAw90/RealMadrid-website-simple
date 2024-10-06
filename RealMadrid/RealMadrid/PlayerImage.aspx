<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlayerImage.aspx.cs" Inherits="RealMadrid.PlayerImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="LabelPlayers" runat="server" Text="Please Select The Player Name"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownListPlayers" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListPlayers_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="LabelDescription" runat="server" Text="Description"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxDescription" Width="500px" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    <br />
    <asp:FileUpload ID="FileUpload1" Width="500px" runat="server" />
    &nbsp;
    <asp:Button ID="ButtonUpload" runat="server" Text="Upload"
        OnClick="ButtonUpload_Click" />
    <hr />
    <center>
        <asp:GridView ID="GridViewImages" runat="server" CellPadding="3" AutoGenerateColumns="False" ForeColor="Black" GridLines="Vertical" Caption="Images"
            OnRowDeleting="GridViewImages_RowDeleting" OnSelectedIndexChanged="GridViewImages_SelectedIndexChanged" OnRowDataBound="GridViewImages_RowDataBound" BackColor="White"
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="LabelID" runat="server" Text='<%#Bind("MyID") %>'></asp:Label>
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
                        <asp:Image ImageUrl='<%#Eval("MyFileName") %>' runat="server" Width="100px" Height="100px"></asp:Image>
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
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>

