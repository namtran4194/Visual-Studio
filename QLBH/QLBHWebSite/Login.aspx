<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }

        .auto-style8 {
            width: 326px;
            height: 26px;
            text-align: right;
        }

        .auto-style9 {
            height: 26px;
            text-align: left;
        }

        .auto-style10 {
            text-align: left;
        }

        .auto-style11 {
            width: 326px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8">Tài khoản</td>
            <td class="auto-style9">
                <asp:TextBox ID="TextBox1" runat="server" Width="450px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">Mật khẩu</td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="450px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Đăng nhập" />
                <br />
                <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Tên đăng nhập hoặc mật khẩu không đúng"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>