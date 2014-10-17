<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summator.aspx.cs" Inherits="WebFormsIntro.Summator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Sumator" runat="server">
        <div>
            <h2>Very Simple Summator</h2>
            <label for="inputFirstDigit">First Digit</label>
            <asp:TextBox runat="server" ID="TextFirstDigit" />
            <br />

            <label for="inputSecondDigit">Second Digit</label>
            <asp:TextBox runat="server" ID="TextSecondDigit" />
            <br />

            <label for="inputSecondDigit">Sum</label>
            <asp:TextBox runat="server" ID="TextResult"/>
            <asp:Button Text="Sum" runat="server" ID="btnSum" OnClick="btnSum_Click"/>
        </div>
    </form>
</body>
</html>
