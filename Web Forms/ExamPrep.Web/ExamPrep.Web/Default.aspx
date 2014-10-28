<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExamPrep.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Title %></h1>

    <div class="row">
        <asp:Button CssClass="btn btn-primary pull-right" Text="Search" runat="server" ID="ButtonSearch" OnClick="ButtonSearch_Click"/>
        <asp:TextBox CssClass="form-control col-md-4 pull-right" placeholder="Search by author/title" runat="server" ID="TextBoxSearch" />
    </div>
    <asp:ListView runat="server" ID="ListViewCategories" ItemType="ExamPrep.Models.Category"
        SelectMethod="ListViewCategories_GetData" GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="ItemPlaceHolder" />
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Name %></h2>

                <asp:ListView runat="server" ID="CateboryBooks" DataSource="<%# Item.Books %>" ItemType="ExamPrep.Models.Book">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <a href="/BookDetails?id=<%#: Item.Id %>"><%#: Item.Title %> by <%# Item.Author %></a>
                        </li>
                    </ItemTemplate>
                </asp:ListView>

            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
