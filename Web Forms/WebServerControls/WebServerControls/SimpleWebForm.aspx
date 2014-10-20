<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleWebForm.aspx.cs" Inherits="WebServerControls.SimpleWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:Panel runat="server" ID="PanelMain" Width="50%">

            <label for="TextFirstName">First Name</label>
            <asp:TextBox runat="server" ID="TextFirstName" />
            <label for="TextLastName">Last Name</label>
            <asp:TextBox runat="server" ID="TextLastName" />

            <br />
            <br />
            <label for="TextFacultyNumber">Faculty No#</label>
            <asp:TextBox runat="server" ID="TextFacultyNumber" />

            <br />
            <br />
            <label for="DropUniversity">University</label>
            <asp:DropDownList runat="server" ID="DropUniversity">
                <asp:ListItem Value="Sofia University" Text="Sofia University" />
                <asp:ListItem Value="TU Sofia" Text="TU Sofia" />
                <asp:ListItem Value="UNWE" Text="UNWE" />
                <asp:ListItem Value="UASG" Text="UASG" />
            </asp:DropDownList>

            <br />
            <br />
            <label for="ListCourses">Courses</label>
            <asp:ListBox runat="server" ID="ListCourses" SelectionMode="Multiple">
                <asp:ListItem Value="DSA" Text="DSA" />
                <asp:ListItem Value="C#" Text="C#" />
                <asp:ListItem Value="Java" Text="Java" />
                <asp:ListItem Value="HQC" Text="Clean Code" />
            </asp:ListBox>

            <br />
            <br />
            <asp:Button Text="Submit" runat="server" ID="ButtonSubmit" OnClick="ButtonSubmit_Click"/>
        </asp:Panel>

        <br />
        <br />
        <asp:Panel runat="server" ID="PanelSubmit" Width="50%">
            <h3>Submited Data</h3>
        </asp:Panel>
    </form>
</body>
</html>
