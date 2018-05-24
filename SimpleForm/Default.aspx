<%@ Page Title="Formular" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <form action="">
        
        <label>Personal informations</label>
        <br/>
        Name: <asp:TextBox runat="server" ID="TextBoxName"/><br />
        Email: <asp:TextBox runat="server" ID="TextBoxEmail" /><br />
        
        <br/>
        
        <label>Your sex</label>
        <br/>
        <asp:RadioButton runat="server" ID="RadioButtonSexMale" GroupName="RadioButtonGroupSex" Text="Male"/>
        <asp:RadioButton runat="server" ID="RadioButtonSexFemale" GroupName="RadioButtonGroupSex" Text="Female"/>
        
        <br/>
        
        <label>Age</label>
        <br/>
        <asp:DropDownList runat="server" ID="DropDownAge">
            <asp:ListItem Text="<10" Selected="True"/>
            <asp:ListItem Text="<20"/>
            <asp:ListItem Text="<30"/>
            <asp:ListItem Text="<50"/>
            <asp:ListItem Text="<70"/>
        </asp:DropDownList>
        
        <br/>
        <br/>

        <label>Comment</label>
        <br/>
        <asp:TextBox runat="server" ID="TextBoxComment" TextMode="MultiLine" Rows="4" Columns="35" Style="overflow-scrolling: auto"/>            
        
        <br/>
        <br/>
        
        <asp:Button runat="server" OnClick="Submit_OnClick" Text="Submit"/>

    </form>

</asp:Content>