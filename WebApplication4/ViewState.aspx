<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="WebApplication4.ViewState" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
    <asp:Button ID="btnClick" runat="server" Text="Button" OnClick="btnClick_Click"/>


</asp:Content>

