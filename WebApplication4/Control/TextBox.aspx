<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TextBox.aspx.cs" Inherits="WebApplication4.Control.TextBox" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <asp:TextBox ID="TextBox1" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox>

    <asp:RadioButton runat="server" ID="rbGender" Text="Male"  GroupName="Gender" OnCheckedChanged="rbGender_CheckedChanged" AutoPostBack="true"/>
       <asp:RadioButton runat="server" ID="rbGender2" Text="Female" GroupName="Gender" OnCheckedChanged="rbGender_CheckedChanged" AutoPostBack="true" />
</asp:Content>