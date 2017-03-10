<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserManager.aspx.cs" Inherits="UserManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT * FROM [Quyen] ORDER BY [Ma], [Ten]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" DeleteCommand="DELETE FROM [NguoiDung] WHERE [Ma] = @Ma" InsertCommand="INSERT INTO [NguoiDung] ([MaQuyen], [TenDangNhap], [MatKhau], [HoTen], [Email]) VALUES (@MaQuyen, @TenDangNhap, @MatKhau, @HoTen, @Email)" SelectCommand="SELECT * FROM [NguoiDung] WHERE ([MaQuyen] = @MaQuyen)" UpdateCommand="UPDATE [NguoiDung] SET [MaQuyen] = @MaQuyen, [TenDangNhap] = @TenDangNhap, [MatKhau] = @MatKhau, [HoTen] = @HoTen, [Email] = @Email WHERE [Ma] = @Ma">
        <DeleteParameters>
            <asp:Parameter Name="Ma" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="MaQuyen" Type="Int32" />
            <asp:Parameter Name="TenDangNhap" Type="String" />
            <asp:Parameter Name="MatKhau" Type="String" />
            <asp:Parameter Name="HoTen" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="MaQuyen" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="MaQuyen" Type="Int32" />
            <asp:Parameter Name="TenDangNhap" Type="String" />
            <asp:Parameter Name="MatKhau" Type="String" />
            <asp:Parameter Name="HoTen" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Ma" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
&nbsp;</p>
<p>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Ten" DataValueField="Ma" AutoPostBack="True">
    </asp:DropDownList>
&nbsp;
    <div class="auto-style2">
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Ma" DataSourceID="SqlDataSource2" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Ma" HeaderText="Mã" InsertVisible="False" ReadOnly="True" SortExpression="Ma" />
                <asp:BoundField DataField="MaQuyen" HeaderText="Quyền" SortExpression="MaQuyen" />
                <asp:BoundField DataField="TenDangNhap" HeaderText="Tài khoản" SortExpression="TenDangNhap" />
                <asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" SortExpression="MatKhau" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ tên" SortExpression="HoTen" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            </Columns>
        </asp:GridView>
    </div>
</p>
<p>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="Ma" DataSourceID="SqlDataSource2" DefaultMode="Insert" Height="50px" Width="269px">
        <Fields>
            <asp:BoundField DataField="Ma" HeaderText="Ma" InsertVisible="False" ReadOnly="True" SortExpression="Ma" />
            <asp:BoundField DataField="MaQuyen" HeaderText="Mã quyền" SortExpression="MaQuyen" />
            <asp:BoundField DataField="TenDangNhap" HeaderText="Tài khoản" SortExpression="TenDangNhap" />
            <asp:BoundField DataField="MatKhau" HeaderText="Mật khẩu" SortExpression="MatKhau" />
            <asp:BoundField DataField="HoTen" HeaderText="Họ tên" SortExpression="HoTen" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
</p>
</asp:Content>

