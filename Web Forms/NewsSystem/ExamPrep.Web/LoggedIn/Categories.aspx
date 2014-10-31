<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="ExamPrep.Web.LoggedIn.Categories" %>

<asp:Content ID="ContentCategories" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="ListViewCategories" ItemType="ExamPrep.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        InsertMethod="ListViewCategories_InsertItem"
        UpdateMethod="ListViewCategories_UpdateItem"
        DeleteMethod="ListViewCategories_DeleteItem"
        DataKeyNames="id"
        InsertItemPosition="LastItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton ID="lnkBtnSortByCustomer" CssClass="btn btn-info" CommandName="Sort"
                    CommandArgument="Name" runat="server">Sort By Name</asp:LinkButton>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                <asp:DataPager ID="CategoriesPager" runat="server" PageSize="5">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonCssClass="btn btn-default" ShowFirstPageButton="False"
                            ShowNextPageButton="False" ShowPreviousPageButton="True" PreviousPageText="Previous Page" />
                        <asp:NumericPagerField NumericButtonCssClass="page-label" NextPreviousButtonCssClass="page-label" CurrentPageLabelCssClass="page-label" />
                        <asp:NextPreviousPagerField ButtonCssClass="btn btn-default" ShowLastPageButton="False"
                            ShowNextPageButton="True" ShowPreviousPageButton="False" NextPageText="Next Page" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>

        <ItemTemplate>
            <div class="row">
                <div class="col-md-3"><%#: Item.Name %></div>
                <asp:LinkButton Text="Edit" CssClass="btn btn-info" runat="server" ID="LinkButtonEdit" CommandName="Edit" />
                <asp:LinkButton Text="Delete" CssClass="btn btn-danger" runat="server" ID="LinkButtonDelete" CommandName="Delete" />
            </div>
        </ItemTemplate>

        <EditItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </div>
                <asp:LinkButton runat="server" CssClass="btn btn-success" ID="LinkButtonEdit" Text="Save" CommandName="Update" />
                <asp:LinkButton runat="server" CssClass="btn btn-danger" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
            </div>
        </EditItemTemplate>

        <InsertItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </div>
                <asp:LinkButton runat="server" CssClass="btn btn-info" ID="LinkButtonEdit" Text="Insert" CommandName="Insert" />
                <asp:LinkButton runat="server" CssClass="btn btn-danger" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
            </div>
        </InsertItemTemplate>

    </asp:ListView>
</asp:Content>
