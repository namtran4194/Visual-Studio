<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachLienHe.ascx.cs" Inherits="DemoADO.NET.DanhSachLienHe" %>

<%@ Register TagPrefix="vst" TagName="FormEdit" Src="~/FormEdit.ascx" %>

<table width="750">
    <tr>
        <td>
            <asp:LinkButton ID="buttonAdd" runat="server" Text="Thêm mới" />
        </td>
        <td style="text-align: right">
            <asp:TextBox ID="textFilter" runat="server" />
            <asp:Button ID="buttonFilter" runat="server" Text="Lọc theo tên" />
        </td>
    </tr>
</table>
<hr />
<asp:DataList runat="server" ID="dataList1" Width="100%">
    <ItemTemplate>
        <table cellspacing="20" width="750">
            <tr valign="top">
                <td style="width: 80px">
                    <asp:LinkButton ID="buttonEdit" runat="server"
                        CommandName="Edit">Cập nhật</asp:LinkButton>
                </td>
                <td style="width: 150px">
                    <b><%# DataBinder.Eval(Container.DataItem, "HoTen") %></b>
                    <br />
                    <i><%# DataBinder.Eval(Container.DataItem, "NamSinh") %></i>
                </td>
                <td style="width: 250px">
                    <%# DataBinder.Eval(Container.DataItem, "EMail") %><br />
                    <%# DataBinder.Eval(Container.DataItem, "DienThoai") %>
                </td>
                <td>
                    <i><%# DataBinder.Eval(Container.DataItem, "GhiChu") %></i>
                </td>
            </tr>
        </table>
        <hr />
    </ItemTemplate>
    <EditItemStyle BackColor="WhiteSmoke" />
    <EditItemTemplate>
        <vst:FormEdit ID="formEdit" runat="server"
            Data='<%# Container.DataItem %>' />
        <hr />
    </EditItemTemplate>
</asp:DataList>
