<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductManager.aspx.cs" Inherits="ProductManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style5 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="auto-style5">

        <strong>
        <asp:HyperLink ID="HyperLink7" runat="server" BackColor="#669999" BorderColor="Silver" BorderStyle="Inset" BorderWidth="5px" Font-Bold="True" NavigateUrl="~/CustomProduct.aspx" ToolTip="Thêm sản phẩm mới">Tùy chỉnh sản phẩm</asp:HyperLink>
        </strong>
        <br />

        <asp:DataList ID="DataList1" runat="server" CellSpacing="5" DataKeyField="Ma" RepeatColumns="3" RepeatDirection="Horizontal">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("HinhAnh", "~/ProductImages/{0}") %>' Width="200px" />
                <br />
                <asp:HyperLink ID="HyperLink6" runat="server" Font-Bold="True" NavigateUrl='<%# Eval("Ma", "~/ProductDetail.aspx?MaSP={0}") %>' Text='<%# Eval("Ten") %>'></asp:HyperLink>
                <br />
                <asp:Label ID="GiaLabel" runat="server" Font-Bold="True" ForeColor="Red" Text='<%# Eval("Gia", "{0:C0}") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>

        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" id="tdPage" runat="server">&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>