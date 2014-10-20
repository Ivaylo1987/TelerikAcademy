<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExecutionAssembly.aspx.cs" Inherits="WebFormsBasics.ExecutionAssembly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <asp:TextBox runat="server" ID="TextAssemblyInfo"  Width="50%"/>
        <asp:Button Text="Assembly Info" runat="server" ID="ButtonAssembly" OnClick="ButtonAssembly_Click"/>
    </form>
</body>
</html>
