<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomProduct.aspx.cs" Inherits="CustomProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style5 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="auto-style5">
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Ten" DataValueField="Ma">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT [Ma], [Ten] FROM [SanPham] ORDER BY [Ten]"></asp:SqlDataSource>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1">Edit</asp:LinkButton>
            <br __designer:mapid="7bd" />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click1">Add</asp:LinkButton>
            <br __designer:mapid="7c0" />
            <asp:Label ID="lblNotif" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            <br />
            <div class="auto-style4">
            <asp:FormView ID="FormView1" runat="server" DataKeyNames="Ma" DataSourceID="SqlDataSource1" DefaultMode="Insert" OnItemUpdated="FormView1_ItemUpdated">
                <EditItemTemplate>
                    Ma:
                    <asp:Label ID="MaLabel1" runat="server" Text='<%# Eval("Ma") %>' />
                    <br />
                    MaLoai:
                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Ten" DataValueField="Ma" SelectedValue='<%# Bind("MaLoai") %>'>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT * FROM [LoaiSanPham] ORDER BY [Ten]"></asp:SqlDataSource>
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
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" PostBackUrl="~/CustomProduct.aspx" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" PostBackUrl="~/ProductManager.aspx" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    MaLoai:
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Ten" DataValueField="Ma" SelectedValue='<%# Bind("MaLoai") %>'>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT * FROM [LoaiSanPham] ORDER BY [Ten]"></asp:SqlDataSource>
                    <br />
                    Ten:
                    <asp:TextBox ID="TenTextBox" runat="server" Text='<%# Bind("Ten") %>' />
                    <br />
                    HinhAnh:
                    <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource2" DataTextField="TenFile" DataValueField="TenFileThat" SelectedValue='<%# Bind("HinhAnh") %>'>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT * FROM [Upload] ORDER BY [TenFile]"></asp:SqlDataSource>
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
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" PostBackUrl="~/ProductManager.aspx" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    Ma:
                    <asp:Label ID="MaLabel" runat="server" Text='<%# Eval("Ma") %>' />
                    <br />
                    MaLoai:
                    <asp:Label ID="MaLoaiLabel" runat="server" Text='<%# Bind("MaLoai") %>' />
                    <br />
                    Ten:
                    <asp:Label ID="TenLabel" runat="server" Text='<%# Bind("Ten") %>' />
                    <br />
                    HinhAnh:
                    <asp:Label ID="HinhAnhLabel" runat="server" Text='<%# Bind("HinhAnh") %>' />
                    <br />
                    MieuTa:
                    <asp:Label ID="MieuTaLabel" runat="server" Text='<%# Bind("MieuTa") %>' />
                    <br />
                    Gia:
                    <asp:Label ID="GiaLabel" runat="server" Text='<%# Bind("Gia") %>' />
                    <br />
                    NgaySX:
                    <asp:Label ID="NgaySXLabel" runat="server" Text='<%# Bind("NgaySX") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" DeleteCommand="DELETE FROM [SanPham] WHERE [Ma] = @Ma" InsertCommand="INSERT INTO [SanPham] ([MaLoai], [Ten], [HinhAnh], [MieuTa], [Gia], [NgaySX]) VALUES (@MaLoai, @Ten, @HinhAnh, @MieuTa, @Gia, @NgaySX)" SelectCommand="SELECT * FROM [SanPham]" UpdateCommand="UPDATE [SanPham] SET [MaLoai] = @MaLoai, [Ten] = @Ten, [HinhAnh] = @HinhAnh, [MieuTa] = @MieuTa, [Gia] = @Gia, [NgaySX] = @NgaySX WHERE [Ma] = @Ma">
                <DeleteParameters>
                    <asp:Parameter Name="Ma" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="MaLoai" Type="Int32" />
                    <asp:Parameter Name="Ten" Type="String" />
                    <asp:Parameter Name="HinhAnh" Type="String" />
                    <asp:Parameter Name="MieuTa" Type="String" />
                    <asp:Parameter Name="Gia" Type="Int32" />
                    <asp:Parameter Name="NgaySX" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="MaLoai" Type="Int32" />
                    <asp:Parameter Name="Ten" Type="String" />
                    <asp:Parameter Name="HinhAnh" Type="String" />
                    <asp:Parameter Name="MieuTa" Type="String" />
                    <asp:Parameter Name="Gia" Type="Int32" />
                    <asp:Parameter Name="NgaySX" Type="DateTime" />
                    <asp:Parameter Name="Ma" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
        </div>
    </div>
</asp:Content>

