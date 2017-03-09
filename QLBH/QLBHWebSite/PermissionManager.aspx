<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PermissionManager.aspx.cs" Inherits="PermissionManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style7 {
            width: 184px;
        }

        .auto-style8 {
            width: 596px;
            text-align: center;
        }

        .auto-style11 {
            width: 596px;
            text-align: left;
        }

        .auto-style12 {
            margin-left: 0px;
        }

        .auto-style13 {
            width: 84px;
            text-align: left;
        }

        .auto-style14 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="auto-style2">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    <table>
        <tr>
            <td class="auto-style13">Mã</td>
            <td class="auto-style7">

                <asp:TextBox ID="TextBox1" runat="server" Width="594px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tên quyền</td>
            <td class="auto-style7">

                <asp:TextBox ID="TextBox2" runat="server" Width="593px" CssClass="auto-style12"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="2">

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Thêm" />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>

            </td>
        </tr>
        <tr>
            <td class="auto-style13">Mã</td>
            <td class="auto-style11">

                <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style12" Width="592px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">

                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Xóa" />
                <br />
                <asp:Label ID="Label3" runat="server"></asp:Label>

            </td>
        </tr>
        <tr>
            <td class="auto-style13">Mã</td>
            <td class="auto-style14">

                <asp:TextBox ID="TextBox4" runat="server" Width="594px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="auto-style13">Tên quyền</td>
            <td class="auto-style14">

                <asp:TextBox ID="TextBox5" runat="server" Width="593px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">

                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sửa" />
                <br />
                <asp:Label ID="Label4" runat="server"></asp:Label>

            </td>
        </tr>
    </table>
</asp:Content>

