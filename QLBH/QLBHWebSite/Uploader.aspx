<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Uploader.aspx.cs" Inherits="Uploader" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: 231px;
        }
        .auto-style6 {
            width: 231px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TenFileThat" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="TenFileThat" HeaderText="TenFileThat" ReadOnly="True" SortExpression="TenFileThat" />
                <asp:BoundField DataField="TenFile" HeaderText="TenFile" SortExpression="TenFile" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("TenFileThat") %>' OnClick="LinkButton1_Click">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBH %>" SelectCommand="SELECT * FROM [Upload]"></asp:SqlDataSource>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Chọn ảnh: </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

