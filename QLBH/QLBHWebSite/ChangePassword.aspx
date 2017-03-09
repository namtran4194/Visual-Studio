<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: 148px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">Mật khẩu cũ</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="320px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Mật khẩu mới</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="320px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Nhập lại mật khẩu mới</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="320px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Đổi mật khẩu" />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>