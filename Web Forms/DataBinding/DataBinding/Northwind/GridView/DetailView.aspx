<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailView.aspx.cs" Inherits="DataBinding.Northwind.GridView.DetailView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="DetailsForm" runat="server">
        <asp:DetailsView ID="DetailsViewEmployee" runat="server" AutoGenerateRows="true">
        </asp:DetailsView>
        <asp:HyperLink ID="HyperLinkBack" runat="server" NavigateUrl="~/Northwind/GridView/Employees.aspx">Back</asp:HyperLink>
    </form>
</body>
</html>
