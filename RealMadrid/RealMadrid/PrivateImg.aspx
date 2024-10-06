<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PrivateImg.aspx.cs" Inherits="RealMadrid.PrivateImg" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Private Images Page</h1>
<center>
    <asp:DataList ID="DataListImages" runat="server" DataKeyField="MyFileName"  RepeatColumns="3"  RepeatDirection="Horizontal" Width="100%">
        <ItemTemplate>
        <table>
        <tr>
         <td>
                <asp:Label ID="LabeDecription" runat="server" Text='<%# Eval("MyDescription") %>'></asp:Label></td>
        <td>
        </tr>
        <tr>
           <td><asp:Image ID="Image1" ImageUrl='<%#Eval("MyFileName") %>' runat="server" Width="300px" Height="300px"></asp:Image></td>
          </tr></table>
              <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
</center>  
</asp:Content>

