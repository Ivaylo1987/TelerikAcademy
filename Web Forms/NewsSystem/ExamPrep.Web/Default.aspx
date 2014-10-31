<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExamPrep.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Title %></h1>
    <h2>Most popular articles</h2>

    <asp:ListView runat="server" ID="ListViewArticles" ItemType="ExamPrep.Models.Article"
        SelectMethod="ListViewArticles_GetData">

        <ItemTemplate>
            <div class="row">
                <h3><a href="/ViewArticle?id=<%#: Item.Id %>"><%# Item.Title %></a> <small><%# Item.Category.Name %></small></h3>
                <p>
                    <%#: Item.Content %>
                </p>
                <p>Likes: <%#: Item.Likes.Count() %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>

    </asp:ListView>

    <h2>All categories</h2>

    <asp:ListView runat="server" ID="ListViewCategory" ItemType="ExamPrep.Models.Category"
        SelectMethod="ListViewCategory_GetData" GroupItemCount="2">

        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="ItemPlaceHolder" />
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-6">
                <h3><%#: Item.Name %></h3>
                <asp:ListView runat="server" ID="ListViewArticlesInCategory" ItemType="ExamPrep.Models.Article"
                    DataSource="<%# Item.Articles.OrderBy(a => a.Likes.Count()).Take(3) %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <a href="/ViewArticle?id=<%#: Item.Id %>"><strong><%# Item.Title %></strong> <i>by <%# Item.Author.UserName %></i></a>
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No articles
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
