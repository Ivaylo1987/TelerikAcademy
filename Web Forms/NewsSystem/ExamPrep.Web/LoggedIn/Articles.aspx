<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="ExamPrep.Web.LoggedIn.Articles" %>

<asp:Content ID="ContentArticles" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="ListViewArticles" ItemType="ExamPrep.Models.Article"
        DataKeyNames="id"
        SelectMethod="ListViewArticles_GetData"
        UpdateMethod="ListViewArticles_UpdateItem"
        DeleteMethod="ListViewArticles_DeleteItem"
        InsertMethod="ListViewArticles_InsertItem">

        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton ID="lnkBtnSortByTitle" CssClass="btn btn-info" CommandName="Sort"
                    CommandArgument="Title" runat="server">Sort By Title</asp:LinkButton>

                <asp:LinkButton ID="LinkButtonSortByDate" CssClass="btn btn-info" CommandName="Sort"
                    CommandArgument="DateCreated" runat="server">Sort By Date</asp:LinkButton>
            </div>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </div>

            <div class="row">
                <asp:DataPager ID="ArticlePager" runat="server" PageSize="5">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonCssClass="btn btn-default" ShowFirstPageButton="False"
                            ShowNextPageButton="False" ShowPreviousPageButton="True" PreviousPageText="Previous Page" />
                        <asp:NumericPagerField NumericButtonCssClass="page-label" NextPreviousButtonCssClass="page-label" CurrentPageLabelCssClass="page-label" />
                        <asp:NextPreviousPagerField ButtonCssClass="btn btn-default" ShowLastPageButton="False"
                            ShowNextPageButton="True" ShowPreviousPageButton="False" NextPageText="Next Page" />
                    </Fields>
                </asp:DataPager>
            </div>

            <asp:LinkButton ID="LinkButtonInsertNewArticle" CssClass="btn btn-info pull-right"
                OnClick="LinkButtonInsertNewArticle_Click" runat="server">Insert New Article</asp:LinkButton>
        </LayoutTemplate>

        <ItemTemplate>
            <div class="row">
                <h3>
                    <%# Item.Title %>
                    <asp:LinkButton Text="Edit" CssClass="btn btn-info" runat="server" ID="LinkButtonEdit" CommandName="Edit" />
                    <asp:LinkButton Text="Delete" CssClass="btn btn-danger" runat="server" ID="LinkButtonDelete" CommandName="Delete" />
                </h3>
                <p>
                    <small>Category: <%# Item.Category.Name %></small>
                </p>
                <p>
                    <%#: Item.Content.Length > 300 ? (Item.Content.Substring(0, 299) + "...") : Item.Content %>
                </p>
                <p>Likes: <%#: Item.Likes.Count() %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>

        <EditItemTemplate>
            <div class="row">
                <h3>
                    <asp:TextBox runat="server" ID="TextBoxNameTitle" Text="<%#: BindItem.Title %>" />

                    <asp:LinkButton runat="server" CssClass="btn btn-success" ID="LinkButtonUpdate" Text="Save" CommandName="Update" />
                    <asp:LinkButton runat="server" CssClass="btn btn-danger" ID="LinkButtonCancel" Text="Cancel" CommandName="Cancel" />
                </h3>
                <p>
                    <asp:DropDownList runat="server" ID="DropDownListCategories" DataTextField="Name" DataValueField="Id"
                        ItemType="ExamPrep.Models.Category" SelectMethod="DropDownListCategoriesCreate_GetData"
                        SelectedValue="<%# BindItem.CategoryId %>">
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="5" Columns="150" ID="TextBoxContent" Text="<%#: BindItem.Content %>" />
                </p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </EditItemTemplate>

    </asp:ListView>
</asp:Content>
