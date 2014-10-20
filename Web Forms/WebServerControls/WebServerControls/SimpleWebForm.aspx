<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleWebForm.aspx.cs" Inherits="WebServerControls.SimpleWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Panel runat="server" ID="MainPanel" Width="50%">
            <label for="TextFirstName">First Name</label>
            <asp:TextBox runat="server" ID="TextFirstName" />
            <label for="TextLastName">Last Name</label>
            <asp:TextBox runat="server" ID="TextLastName" />

            <br />
            <label for="TextFacultyNumber">Faculty No#</label>
            <asp:TextBox runat="server" ID="TextFacultyNumber" />
            
            <br/>
            <asp:DropDownList runat="server" ID="DropUniversity">
                <asp:ListItem Value="0" Text="Sofia University" />
                <asp:ListItem Value="1" Text="TU Sofia" />
                <asp:ListItem Value="2" Text="UNWE" />
                <asp:ListItem Value="3" Text="UASG" />
            </asp:DropDownList>
        </asp:Panel>
    </form>
</body>
</html>
