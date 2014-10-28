<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="Employees.aspx.cs"
    Inherits="DataBinding.Northwind.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employees</title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:GridView ID="GridViewEmployees" runat="server"
            AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="FullName" HeaderText="Full Name"/>
                <asp:HyperLinkField Text="details" HeaderText="details" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="DetailView.aspx?id={0}"/>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
