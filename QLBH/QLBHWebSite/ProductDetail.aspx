<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
    .auto-style5 {
        width: 171px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="Ma" DataSourceID="SqlDataSource1" OnDataBound="FormView1_DataBound">
        <EditItemTemplate>
            Ma:
            <asp:Label ID="MaLabel1" runat="server" Text='<%# Eval("Ma") %>' />
            <br />
            MaLoai:
            <asp:TextBox ID="MaLoaiTextBox" runat="server" Text='<%# Bind("MaLoai") %>' />
            <br />
            Ten:
            <asp:TextBox ID="TenTextBox" runat="server" Text='<%# Bind("Ten") %>' />
            <br />
            HinhAnh:
            <asp:TextBox ID="HinhAnhTextBox" runat="server" Text='<%# Bind("HinhAnh") %>' />
            <br />
            MieuTa:
            <asp:TextBox ID="MieuTaTextBox" runat="server" Text='<%# Bind("MieuTa") %>' />
            <br />
            Gia:
            <asp:TextBox ID="GiaTextBox" runat="server" Text='<%# Bind("Gia") %>' />
            <br />
            NgaySX:
            <asp:TextBox ID="NgaySXTextBox" runat="server" Text='<%# Bind("NgaySX") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            MaLoai:
            <asp:TextBox ID="MaLoaiTextBox" runat="server" Text='<%# Bind("MaLoai") %>' />
            <br />
            Ten:
            <asp:TextBox ID="TenTextBox" runat="server" Text='<%# Bind("Ten") %>' />
            <br />
            HinhAnh:
            <asp:TextBox ID="HinhAnhTextBox" runat="server" Text='<%# Bind("HinhAnh") %>' />
            <br />
            MieuTa:
            <asp:TextBox ID="MieuTaTextBox" runat="server" Text='<%# Bind("MieuTa") %>' />
            <br />
            Gia:
            <asp:TextBox ID="GiaTextBox" runat="server" Text='<%# Bind("Gia") %>' />
            <br />
            NgaySX:
            <asp:TextBox ID="NgaySXTextBox" runat="server" Text='<%# Bind("NgaySX") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5" rowspan="5">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("HinhAnh", "~/Images/{0}") %>' />
                    </td>
                    <td>Mã:
                        <asp:Label ID="MaLabel" runat="server" Text='<%# Eval("Ma") %>' />
                        <br />
                        Loại sản phẩm:
                        <asp:Label ID="MaLoaiLabel" runat="server" Text='<%# Bind("MaLoai") %>' />
                    </td>
                </tr>
                <tr>
                    <td>Tên:
                        <asp:Label ID="TenLabel" runat="server" Text='<%# Bind("Ten") %>' />
                    </td>
                </tr>
                <tr>
                    <td>Giá:
                        <asp:Label ID="GiaLabel" runat="server" Text='<%# Bind("Gia", "{0:C0}") %>' />
                    </td>
                </tr>
                <tr>
                    <td>Miêu tả:
                        <asp:Label ID="MieuTaLabel" runat="server" Text='<%# Bind("MieuTa") %>' />
                    </td>
                </tr>
                <tr>
                    <td>Ngày sản xuất:
                        <asp:Label ID="NgaySXLabel" runat="server" Text='<%# Bind("NgaySX", "{0:D}") %>' />
                    </td>
                </tr>
            </table>
            <br />

        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT * FROM [SanPham] WHERE ([Ma] = @Ma)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Ma" QueryStringField="MaSP" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
