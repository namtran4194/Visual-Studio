<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoADO.NET.Default" %>

<%@ Register TagPrefix="vst" TagName="DanhSach" Src="~/DanhSachLienHe.ascx" %>

<asp:Content ID="BodyContent" runat="server"
    ContentPlaceHolderID="MainContent">
    <vst:DanhSach ID="danhSach" runat="server" />
</asp:Content>
