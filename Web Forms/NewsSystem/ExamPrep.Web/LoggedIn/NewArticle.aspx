<%@ Page Title="Create New Article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewArticle.aspx.cs" Inherits="ExamPrep.Web.LoggedIn.NewArticle" %>

<asp:Content ID="ContentNewArticle" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: this.Title %></h2>

    <div class="row">
        <div class="col-md-6">
            <h3>Title: 
                <asp:TextBox CssClass="form-control" runat="server" ID="ArticleTitle" />
            </h3>
            <p>
                Category:
                <asp:DropDownList runat="server" CssClass="form-control" ID="DropDownCategories" DataTextField="Name" DataValueField="Id">
                </asp:DropDownList>
            </p>
            <p>
                Content: 
                <asp:TextBox runat="server" CssClass="form-control" Rows="5" Columns="100" TextMode="MultiLine" ID="ArticleContent" />
            </p>
            <div>
                <asp:LinkButton runat="server" CssClass="btn btn-success" ID="LinkButtonUpdate" Text="Save" OnClick="LinkButtonUpdate_Click"/>
                <asp:LinkButton runat="server" CssClass="btn btn-danger" ID="LinkButtonCancel" Text="Cancel" OnClick="LinkButtonCancel_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
