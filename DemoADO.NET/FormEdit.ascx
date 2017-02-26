<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormEdit.ascx.cs" Inherits="DemoADO.NET.FormEdit" %>

<asp:TextBox ID="textBox0" runat="server" Visible="false" />
<table cellpadding="5">
    <tr>
        <td style="width: 80px; text-align: right">Họ tên</td>
        <td>
            <asp:TextBox ID="textBox1" runat="server" Width="100" />
            <asp:TextBox ID="textBox2" runat="server" Width="50" /></td>
    </tr>
    <tr>
        <td style="width: 80px; text-align: right">Năm sinh</td>
        <td>
            <asp:TextBox ID="textBox3" runat="server" Width="50" /></td>
    </tr>
    <tr>
        <td style="width: 80px; text-align: right">Điện thoại</td>
        <td>
            <asp:TextBox ID="textBox4" runat="server" Width="250" /></td>
    </tr>
    <tr>
        <td style="width: 80px; text-align: right">EMail</td>
        <td>
            <asp:TextBox ID="textBox5" runat="server" Width="250" /></td>
    </tr>
    <tr>
        <td style="width: 80px; text-align: right; vertical-align: top;">Ghi chú</td>
        <td>
            <asp:TextBox ID="textBox6" runat="server" Width="250"
                Rows="4" TextMode="MultiLine" /></td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:Button ID="buttonUpdate" runat="server"
                Text="Xác nhận" CommandName="Update" />
            <asp:Button ID="buttonDelete" runat="server"
                Text="Xóa" CommandName="Delete" />
            <asp:Button ID="buttonCancel" runat="server"
                Text="Hủy" CommandName="Cancel" />
        </td>
    </tr>
</table>
