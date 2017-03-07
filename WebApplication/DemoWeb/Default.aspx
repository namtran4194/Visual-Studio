<%@ Page Title="Trang chủ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo._Default" %>

<%@ Register TagPrefix="dmm" TagName="Login" Src="~/Login.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%-- Bảng dữ liệu --%>
    <blockquote>
        <p><strong>I. Đọc dữ liệu từ file xml hiển thị lên DataGrid</strong></p>
        <asp:DataGrid ID="dataGrid" runat="server" ItemStyle-HorizontalAlign="Center"
            AutoGenerateColumns="false" Width="200px">
            <HeaderStyle BackColor="WhiteSmoke" Height="25px" />
            <Columns>
                <asp:BoundColumn DataField="Name" HeaderText="Họ và Tên" HeaderStyle-HorizontalAlign="Center" />
                <asp:BoundColumn DataField="Note" HeaderText="Ghi Chú" HeaderStyle-HorizontalAlign="Center" />
            </Columns>
        </asp:DataGrid>
    </blockquote>
    <hr />

    <%-- Sử dụng Basic Web Controls --%>
    <blockquote>
        <p><strong>II. Sử dụng Basic Web Controls</strong></p>
        <asp:Label runat="server" Text="Trả lời các câu hỏi sau"
            Font-Bold="true" Font-Size="1em" />
        <br />
        <br />
        1. Những control nào sau đây không thuộc nhóm Databound Controls?
    <br />
        <asp:CheckBoxList runat="server" ID="checkBoxList1">
            <asp:ListItem Text="ListBox" />
            <asp:ListItem Text="DropDownList" />
            <asp:ListItem Text="TextBox" Value="1" />
            <asp:ListItem Text="CheckBox" Value="1" />
        </asp:CheckBoxList>
        <br />
        2. Chọn thuộc tính để Page được load lại khi thay đổi trạng thái của RadioButton?
    <br />
        <asp:RadioButtonList runat="server" ID="radioButtonList1" />
        <br />
        3. Thuộc tính nào dùng để đặt caption cho Button?
    <asp:TextBox runat="server" ID="textBox1" Width="50px" />
        <hr />
        <asp:Button runat="server" ID="button1" Text="Trả lời" />
        <br />
        <br />
        <asp:Label runat="server" ID="label1" Font-Bold="true" />
    </blockquote>
    <hr />

    <%-- Validation Controls --%>
    <%--   <blockquote>
        <p><strong>III. Validation Controls</strong></p>
        <asp:Label runat="server" Text="Thông tin dự tuyển"
            Font-Bold="true" Font-Size="1em" />
        <p />
        <table>
            <tr>
                <td>Mã dự tuyển:</td>
                <td>
                    <asp:TextBox ID="txtMaDuTuyen" runat="server" />
                    <asp:RegularExpressionValidator ID="validTxtMaDuTuyen" runat="server"
                        ControlToValidate="txtMaDuTuyen"
                        ErrorMessage="Mã dự tuyển phải gồm 3 đến 5 chữ số"
                        Display="Static"
                        ValidationExpression="\d{3,5}">*
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Họ và tên:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" />
                    <asp:RequiredFieldValidator ID="validTxtName" runat="server"
                        ControlToValidate="txtName"
                        ErrorMessage="Bắt buộc nhập họ tên" Display="Static">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Tuổi:</td>
                <td>
                    <asp:TextBox ID="txtTuoi" runat="server" />
                    <asp:RangeValidator ID="validTxtTuoi" runat="server"
                        ControlToValidate="txtTuoi"
                        ErrorMessage="Tuổi phải từ 18 đến 45" Display="static"
                        Type="Integer" MinimumValue="18" MaximumValue="45">*
                    </asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Trình độ :</td>
                <td>
                    <asp:TextBox ID="txtTrinhDo" runat="server" />
                    <asp:CompareValidator ID="validTxtTrinhDo" runat="server"
                        ControlToValidate="txtTrinhDo"
                        ErrorMessage="Trình độ phải lớn hơn B" Display="static"
                        Type="String" Operator="GreaterThan" ValueToCompare="B">*
                    </asp:CompareValidator>
                </td>
            </tr>
        </table>
        <hr />
        <asp:Button runat="server" Text="Gửi" /><br />
        <br />
        <asp:ValidationSummary ID="validSummary" runat="server"
            HeaderText="Cần nhập thông tin theo mẫu:"
            DisplayMode="BulletList" />
    </blockquote>--%>
    <hr />

    <%-- Sử dụng Repeater, DataList và DataGrid để thể hiện dữ liệu trong file XML --%>
    <blockquote>
        <p><strong>IV. Sử dụng Repeater, DataList và DataGrid để thể hiện dữ liệu trong file XML</strong></p>
        <asp:DataGrid ID="listControl1" runat="server"
            AutoGenerateColumns="false"
            BorderStyle="Solid"
            AlternatingItemStyle-BackColor="WhiteSmoke"
            CellPadding="5" CellSpacing="0"
            OnItemCommand="listControl1_ItemCommand">
            <HeaderStyle
                Font-Size="8" Font-Names="Arial" Font-Bold="true"
                BackColor="LightGray" Height="30px" />
            <Columns>
                <asp:BoundColumn DataField="TieuDe" HeaderText="Tiêu đề"
                    ItemStyle-BorderWidth="0" HeaderStyle-BorderWidth="0">
                    <ItemStyle Width="200px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundColumn>
                <asp:ButtonColumn Text="Edit..."
                    ItemStyle-BorderWidth="0" HeaderStyle-BorderWidth="0" />
                <asp:ButtonColumn Text="Delete"
                    ItemStyle-BorderWidth="0" HeaderStyle-BorderWidth="0"
                    CommandName="delete" />
            </Columns>
        </asp:DataGrid>
    </blockquote>

    <%-- Login control --%>
    <blockquote>
        <p><strong>V. Login control</strong></p>
        <dmm:Login ID="login1" runat="server"
            PasswordCaption="Mật khẩu:" UserNameCaption="Người dùng:" />
        <asp:Label ID="label2" runat="server" />
    </blockquote>
</asp:Content>
