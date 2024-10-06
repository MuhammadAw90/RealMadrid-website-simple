<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="RealMadrid._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .newStyle1 {
        font-family: Arial;
    }
    .newStyle2 {
        font-family: Algerian;
    }
        .newStyle3 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
        }
        .newStyle4 {
            font-family: "Agency FB";
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
    <tr><td dir="ltr" class="newStyle1" style="font-size: large"><asp:Button ID="ButtonMessages" runat="server" 
            Text="Send Message" onclick="ButtonMessages_Click" Height="60px" Width="180px" CssClass="newStyle2" style="color: #000000; font-size: large; background-color: #9999FF"  />
</td></tr>
<tr><td>
    <center>
<img src="Images/realMadrid24.jpg" width="100%" height="60%" />
        </center>
</td></tr>
  <tr><td dir="rtl"><asp:Button ID="ButtonComments" runat="server" Text="Comments" 
          onclick="ButtonComments_Click" Height="60px" Width="180px" CssClass="newStyle4" style="font-size: x-large; font-weight: 700; color: #000000; background-color: #999999" />
</td></tr> 
</table>
</asp:Content>
