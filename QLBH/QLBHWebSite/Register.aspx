<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: 141px;
        }

        .auto-style6 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">Tên đăng nhập</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="320px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox1" ErrorMessage="Bạn chưa nhập tên đăng nhập"
                    Display="Dynamic" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Mật khẩu</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="320px" TextMode="Password"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox2" ErrorMessage="Mật khẩu phải từ 3 đến 50 kí tự"
                    ValidationExpression="\d{3,50}" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Nhập lại mật khẩu</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="320px" TextMode="Password"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox3" ErrorMessage="Mật khẩu phải từ 3 đến 50 kí tự"
                    ValidationExpression="\d{3,50}" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Email</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="320px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox4" ErrorMessage="Bạn chưa nhập email"
                    Display="Static" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Họ tên</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="320px"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox5" ErrorMessage="Bạn chưa nhập họ tên"
                    Display="Static" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Đăng kí" OnClick="Button1_Click" />
                <br />
                <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>