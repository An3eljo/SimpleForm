<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SimpleForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server"><%= "Email: " + (string) Session["UserEmail"] %></asp:Label> 
    <br/>
    <asp:Label runat="server"><%= "Name: " + (string) Session["UserName"] %></asp:Label>
    <br/>
    <asp:Label runat="server"><%= "Your comment: " + (string) Session["UserComment"] %></asp:Label>
    <br/>
    <asp:Label runat="server"><%= "Selected sex: " + ((RadioButton) Session["UserSelectedSex"]).Text %></asp:Label>
</asp:Content>
