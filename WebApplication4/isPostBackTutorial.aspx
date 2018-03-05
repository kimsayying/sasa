<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="isPostBackTutorial.aspx.cs" Inherits="WebApplication4.isPostBackTutorial" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h3>Employee Detail Form</h3>

<div>
    <label>First Name:</label>
    <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
</div>       

    <div>
        <label>Last Name:</label>
        <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
    </div>

    <div>
        <label>City:</label>
        <asp:DropDownList runat="server" ID="ddlCity" >          
        </asp:DropDownList>
    </div>

    <div>
        <asp:Button runat="server" ID="btnRegister" Text="Register Employee"/>
    </div>


</asp:Content>