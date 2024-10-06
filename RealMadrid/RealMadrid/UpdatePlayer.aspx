<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="UpdatePlayer.aspx.cs" Inherits="RealMadrid.UpdatePlayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<h1>This Is Players Editor Page</h1>
<br /><br />
<h3>
<table dir="ltr">
<tr>
<td>
    <asp:Label ID="LabelName" runat="server" Text="Name :" ></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    </td>
    <td>
    <asp:RequiredFieldValidator ID="rvl1" runat="server" ErrorMessage="Name is missing" ControlToValidate="TextBoxName"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
   <asp:Label ID="LabelNumber" runat="server" Text="Number :"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBoxNumber" runat="server"></asp:TextBox>
    </td>
    <td>
    <asp:RequiredFieldValidator ID="rvl2" runat="server" ErrorMessage="Number is missing" ControlToValidate="TextBoxNumber"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="LabelPosition" runat="server" Text="Position :"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBoxPosition" runat="server"></asp:TextBox>
    </td>
    <td>
    <asp:RequiredFieldValidator ID="rvl3" runat="server" ErrorMessage="Position is missing" ControlToValidate="TextBoxPosition"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="LabelDateOfBirth" runat="server" Text="Date Of Birth :"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBoxDateOfBirth" runat="server"></asp:TextBox>
      </td>
    <td>
    <asp:RequiredFieldValidator ID="rvl4" runat="server" ErrorMessage="Date Of Birth is missing" ControlToValidate="TextBoxDateOfBirth"></asp:RequiredFieldValidator>  
</td>
</tr>
<tr>
<td>
    <asp:Label ID="LabelCountry" runat="server" Text="Country :"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBoxCountry" runat="server"></asp:TextBox>
      </td>
    <td>
    <asp:RequiredFieldValidator ID="rvl5" runat="server" ErrorMessage="Country is missing" ControlToValidate="TextBoxCountry"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="LabelInfo" runat="server" Text="Information :"></asp:Label>
</td>
<td>
    <asp:TextBox ID="TextBoxInfo" runat="server">
    </asp:TextBox>
        <asp:RequiredFieldValidator ID="rvl6" runat="server" ErrorMessage="Information is missing" ControlToValidate="TextBoxInfo"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td colspan="2">
<center>
<asp:Button ID="Buttonsave" runat="server" Text="Save" onclick="Buttonsave_Click"/> &nbsp; &nbsp; &nbsp;
<asp:Button ID="ButtonCancel"  CausesValidation="false" runat="server" Text="Cancel" onclick="ButtonCancel_Click" />
</center>
</td>
</tr>
</table>
</h3>
<br />
    <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
</center>
</asp:Content> 