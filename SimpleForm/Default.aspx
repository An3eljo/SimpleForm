<%@ Page Title="Formular" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleForm._Default" %>

 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form action="">

        Name: <input type="text" name="Name" runat="server"/><br />

        Email: <input type="text" name="Email" runat="server"/><br />

 

        <br />

 

        <p>Geben Sie Ihre Geschlecht an</p>

        <fieldset>

            <input type="radio" id="m" name="Geschlecht" value="Männlich" runat="server"/>

            <label for="m"> Männlich</label>

            <input type="radio" id="w" name="Geschlecht" value="Weiblich" runat="server"/>

            <label for="w"> Weiblich</label>

        </fieldset>

     

        <br />

     

        <label for="Alter">Alter</label>

        <input name="Alter" list="Alter" />

        <datalist id="Alter">

            <option value="Unter 10"></option>

            <option value="Unter 20"></option>

            <option value="Unter 30"></option>/option>

            <option value="Unter 50"></option>

            <option value="Unter 70"></option>

        </datalist>

 

        <br />

       

        <label for="text">Kommentar</label>

        <textarea id="text" name="Kommentar" cols="35" rows="4" runat="server"></textarea>               

      

        <br />

 

        <button type="submit" name="submit">submit</button>

    </form>

</asp:Content>