<%@ Page Title="View Article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticle.aspx.cs" Inherits="ExamPrep.Web.ViewArticle" %>

<asp:Content ID="ContentViewArticle" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewAViewArticle" ItemType="ExamPrep.Models.Article"
        SelectMethod="FormViewAViewArticle_GetItem">
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">

                            <div>
                                <asp:Panel runat="server" ID="LikePanle" Visible="false">
                                    <div class="like-control col-md-1">
                                        <div>Likes</div>
                                        <div>
                                            <a class="btn btn-default glyphicon glyphicon-chevron-up" href="#"></a>
                                            <span class="like-value"><%#: Item.Likes.Count() %></span>
                                            <a class="btn btn-default glyphicon glyphicon-chevron-down" href="#"></a>
                                        </div>
                                    </div>
                                </asp:Panel>
                            </div>
                            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
                            <p><%#: Item.Content %></p>
                            <p>
                                <span>Author: <%#: Item.Author.UserName %></span>
                                <span class="pull-right"><%#: Item.DateCreated %></span>
                            </p>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
