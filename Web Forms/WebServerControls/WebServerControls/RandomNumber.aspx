<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumber.aspx.cs" Inherits="WebServerControls.RandomNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <label for="ImputFirstDigit">First digit</label>
        <input type="number" placeholder="Frist Digit" id="ImputFirstDigit" runat="server" />
        <br />
        <label for="ImputSecondDigit">Second digit</label>
        <input type="number" placeholder="Second Digit" id="ImputSecondDigit" runat="server" />
        <br />
        <input type="button" value="Get Random Number" id="ButtonGetNumber" runat="server"  onserverclick="ButtonGetNumber_ServerClick"/>

        <input type="Text" name="Result" runat="server" id="ImputResult" />
    </form>
</body>
</html>
