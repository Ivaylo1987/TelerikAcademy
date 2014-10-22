<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="CarDealer.aspx.cs"
    Inherits="DataBinding.CarDealer.CarDealer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Dealer</title>
</head>
<body>
    <form id="MainForm" runat="server">

        <label for="DropDownBrand">Brand</label>
        <asp:DropDownList ID="DropDownBrand" runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="DropDownBrand_SelectedIndexChanged">
        </asp:DropDownList>

        <label for="DropDownModel">Model</label>
        <asp:DropDownList ID="DropDownModel" runat="server">
        </asp:DropDownList>

        <br />
        <br />
        <label for="CheckBoxListExtras">Extras</label>
        <asp:CheckBoxList ID="CheckBoxListExtras" runat="server">
        </asp:CheckBoxList>
        
        <br />
        <label for="RadioButtonListEngines">Engines</label>
        <asp:RadioButtonList ID="RadioButtonListEngines" runat="server" RepeatDirection="Horizontal">
        </asp:RadioButtonList>

        <asp:Button Text="Submit" runat="server"
            ID="ButtonSubmit" OnClick="ButtonSubmit_Click"/>
        <asp:Literal ID="LiteralCarDetails" runat="server"></asp:Literal>
    </form>
</body>
</html>
