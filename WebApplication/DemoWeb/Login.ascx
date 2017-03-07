<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Demo.Login" %>
<asp:Table ID="panel" runat="server">
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="label1" runat="server" Text="UserName" />
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="textBox1" runat="server" Width="100" />
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="label2" runat="server" Text="Password" />
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="textBox2" runat="server" TextMode="Password" Width="100" />
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell />
        <asp:TableCell>
            <asp:Button ID="button1" runat="server" Text="Login" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
