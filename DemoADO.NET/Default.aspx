<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoADO.NET._Default" %>

<%@ Register TagPrefix="vst" TagName="DanhSach" Src="~/DanhSachLienHe.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <vst:DanhSach ID="danhSach" runat="server" />
</asp:Content>
