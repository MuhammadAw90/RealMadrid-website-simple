<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="NewInfo.aspx.cs" Inherits="RealMadrid.NewInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h1>New Information Page</h1>
        <table>
            <tr>
                <td>
                    <asp:Label ID="LabelType" runat="server" Text="Type Of Information :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxType" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RFV1" runat="server" ControlToValidate="TextBoxType" ErrorMessage="The Information Type Is Missing"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelData" runat="server" Text="Data :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="FreeTextBoxData" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RFV2" runat="server" ControlToValidate="FreeTextBoxData" ErrorMessage="The Data Is Missing"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <center>
                        <asp:Button ID="ButtonSave" runat="server" Text="Save"
                            OnClick="ButtonSave_Click" />
                        &nbsp; &nbsp;
    <asp:Button ID="ButtonCancel" CausesValidation="false" runat="server"
        Text="Cancel" OnClick="ButtonCancel_Click" /></center>
                </td>
            </tr>
        </table>
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    </center>
</asp:Content>

