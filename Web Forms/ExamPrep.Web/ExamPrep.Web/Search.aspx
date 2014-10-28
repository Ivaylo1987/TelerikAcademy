<%@ Page Title="Search Results for Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ExamPrep.Web.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Title + " \"" + this.Request.Params["q"] + "\"" %></h1>
    <asp:ListView runat="server" ID="ListViewResults" ItemType="ExamPrep.Models.Book" SelectMethod="ListViewResults_GetData">
        <LayoutTemplate>
            <ul>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li>
                <a href="/BookDetails?id=<%#: Item.Id %>"><%#: Item.Title %> by <%# Item.Author %></a> (Category: <%#: Item.Category.Name %>)
            </li>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
