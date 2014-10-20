<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayName.aspx.cs" Inherits="WebFormsBasics.HelloName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <asp:Label Text="Name" runat="server" for="TextName"/>
        <asp:TextBox runat="server" ID="TextName" />
        <asp:Button Text="Display" runat="server" ID="ButtonDisplay" OnClick="ButtonDisplay_Click"/>
        <br />
        <asp:TextBox runat="server" ID="TextResult" />
    </form>
</body>
</html>
