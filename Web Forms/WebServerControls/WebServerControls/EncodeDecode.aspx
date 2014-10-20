<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncodeDecode.aspx.cs" Inherits="WebServerControls.EncodeDecode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        
        <label for="TextImput">Your Text</label>
        <asp:TextBox runat="server" id="TextImput"/>  
        <br />
        <asp:Button Text="Get Text" runat="server" id="ButtonGetText" OnClick="ButtonGetText_Click"/>

        <h4>TextBoxes are by default HTML encoded :)</h4>
        <asp:TextBox runat="server" id="TextOutput"/>
        <br />
        <h4>Labels are not HTML encoded</h4>
        <h5>Encoded</h5>
        <asp:Label Text="" runat="server" ID="LabelOutputEncoded"/>
        <h5>Not encoded</h5>
        <asp:Label Text="" runat="server" ID="LabelOutputNotEncoded"/>
        <h5>Double encoded</h5>
        <asp:Label Text="" runat="server" ID="LabelOutputDoubleEncoded"/>
    </form>
</body>
</html>
