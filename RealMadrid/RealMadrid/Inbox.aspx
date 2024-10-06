<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inbox.aspx.cs" Inherits="RealMadrid.Inbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <h2 style="height: 20px">Inbox</h2>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
        GridLines="Vertical" onpageindexchanging="GridView1_PageIndexChanging" 
        onsorting="GridView1_Sorting"
            onrowdeleting="GridView1_RowDeleting" ForeColor="Black">

        <Columns>
            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="ID">
                <ItemTemplate>
                    <asp:Label ID="LabelID" runat="server" Text='<%# Bind("MyID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fname" SortExpression="Fname">
                <ItemTemplate>
                    <asp:Label ID="LabelFname" runat="server" Text='<%# Bind("MyFname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lname" SortExpression="Lname">
                <ItemTemplate>
                    <asp:Label ID="LabeLname" runat="server" Text='<%# Bind("MyLname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title" SortExpression="Title">
                <ItemTemplate>
                    <asp:Label ID="LabelTitle" runat="server" Text='<%# Bind("MyTitle") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Body" SortExpression="Body">
                <ItemTemplate>
                    <asp:Label ID="LabelBody" runat="server" Text='<%# Bind("MyBody") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date1" SortExpression="Date1">
                <ItemTemplate>
                    <asp:Label ID="LabelDate" runat="server" Text='<%# Bind("MyDate1") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                        CommandName="Select" Text="Select"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                        CommandName="Delete" Text="Delete"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#CCCCCC" />
    </asp:GridView>
<br />
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="ButtonNew" runat="server" Text="Send Message" 
            onclick="ButtonNew_Click" />
</center>

</asp:Content>

