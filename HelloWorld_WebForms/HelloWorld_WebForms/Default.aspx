<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWorld_WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1>Hello World!</h1>
    </main>

    <asp:TextBox ID="txtNombre" runat="server" Height="31px" OnTextChanged="TextBox1_TextChanged" Width="175px"></asp:TextBox>
    <asp:Label ID="lblSaludo" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

</asp:Content>
