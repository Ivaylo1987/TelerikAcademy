<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesWithDetails.aspx.cs" Inherits="DataBinding.Northwind.FormView.EmployeesWithDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:FormView runat="server"
            AllowPaging="true"
            ID="FormViewEmployee"
            ItemType="Northwind.Employee"
            OnPageIndexChanging="FormViewEmployee_PageIndexChanging">
            <ItemTemplate>
                <div>
                    <h3>Employee Profile</h3>
                </div>
                <div>
                    <h4><%#: Item.FirstName + " " + Item.LastName %></h4>
                    <div>
                        <ul>
                            <li>Address: <%#: Item.Address %>
                                </li>
                            <li>Hire Date: <%#: Item.HireDate %>
                                </li>
                            <li>Salary: <%#: Item.Title %>
                                </li>
                        </ul>
                    </div>
                </div>
            </ItemTemplate>
        </asp:FormView>

        <asp:ListView runat="server" ID="ListViewEmployees" ItemType="Northwind.Employee">
            <LayoutTemplate>
                <h2>Employees</h2>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
            </LayoutTemplate>
            <ItemSeparatorTemplate>
                <hr />
            </ItemSeparatorTemplate>
            <ItemTemplate>
                <div>
                    <h3><%#: Item.FirstName + " "+ Item.LastName %></h3>
                    Hire-Date: <%#: Item.HireDate %>
                    <br />
                    Hire Date: <%#: Item.HireDate %>;  <%#: Item.Address %>;
                   
                </div>
            </ItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
