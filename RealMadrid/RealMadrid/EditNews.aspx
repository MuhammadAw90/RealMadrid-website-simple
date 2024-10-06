<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="EditNews.aspx.cs" Inherits="RealMadrid.EditNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h1>This Is Players Editor Page</h1>
        <br />
        <br />
        <h3>
            <table dir="ltr">
                <tr>
                    <td>
                        <asp:Label ID="LabelTitle" runat="server" Text="Title :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rvl1" runat="server" ErrorMessage="Title is missing" ControlToValidate="TextBoxTitle"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelImg" runat="server" Text="Image :"></asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <br />
                        <font color="red">**If You Didn't Want To Change The Image Dont Select An Image</font>
                    </td>
                    <td>
                        <asp:Button ID="ButtonUpload" runat="server" Text="Upload" CausesValidation="false"
                            OnClick="ButtonUpload_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelBody" runat="server" Text="Body :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxBody" runat="server">
                        </asp:TextBox>
                        <td>
                            <asp:RequiredFieldValidator ID="rvl2" runat="server" ErrorMessage="Body is missing" ControlToValidate="TextBoxBody"></asp:RequiredFieldValidator>
                        </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <center>
                            <asp:Button ID="Buttonsave" runat="server" Text="Save" OnClick="Buttonsave_Click" />
                            &nbsp; &nbsp; &nbsp;
                            <asp:Button ID="ButtonCancel" CausesValidation="false" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                        </center>
                    </td>
                </tr>
            </table>
        </h3>
        <br />
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
    </center>
</asp:Content>

