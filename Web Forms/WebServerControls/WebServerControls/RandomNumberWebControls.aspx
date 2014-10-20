<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberWebControls.aspx.cs" Inherits="WebServerControls.RandomNumberWebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
         <label for="ImputFirstDigit">First digit</label>
        <asp:TextBox runat="server" ID="ImputFirstDigit"/>
        <br />
        <label for="ImputSecondDigit">Second digit</label>
        <asp:TextBox runat="server" id="ImputSecondDigit"/>  
        <br />
        <asp:Button Text="Get Random Number" runat="server" id="ButtonGetNumber" OnClick="ButtonGetNumber_ServerClick"/>

        <asp:TextBox runat="server" ID="ImputResult"/>  
    </form>
</body>
</html>
