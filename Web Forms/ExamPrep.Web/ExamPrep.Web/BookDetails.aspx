<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="ExamPrep.Web.BookDetails" %>

<asp:Content ID="ContentBookDetails" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %></h1>

    <asp:FormView runat="server" ID="BooksDetails" ItemType="ExamPrep.Models.Book" SelectMethod="BooksDetails_GetItem">
        <ItemTemplate>

            <div class="panel panel-default">
                <div class="panel-heading">
                    <h2>
                        <%#: Item.Title %>
                    </h2>
                </div>
                <div class="panel-body">
                    <p><em>by <%#: Item.Author %></em></p>
                    <p><em>ISBN: <%#: Item.ISBN %></em></p>
                    <p>Web site:<a href="<%#: Item.WebSite %>"><%#: Item.WebSite %></a></p>
                    <p><%#: Item.Description %></p>
                </div>
            </div>

        </ItemTemplate>
    </asp:FormView>

    <a href="/">Back to books</a>
</asp:Content>
