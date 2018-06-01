<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SimpleForm.About" %>
<%@ Import namespace="SimpleForm" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server"><%= "Email: " +  ((User) Session["CurrentUser"]).Email %></asp:Label> 
    <br/>
    <asp:Label runat="server"><%= "Name: " + ((User) Session["CurrentUser"]).Username %></asp:Label>
    <br/>
    <asp:Label runat="server"><%= "Id: " + ((User) Session["CurrentUser"]).Id %></asp:Label>
    <br/>
    <asp:Button runat="server" Text="Logout" OnClick="OnClick"/>
</asp:Content>
