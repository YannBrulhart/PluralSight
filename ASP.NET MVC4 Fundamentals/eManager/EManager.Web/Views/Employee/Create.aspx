<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EManager.Web.Models.CreateEmployeeViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (this.Html.BeginForm())
       { %>

        <%: this.Html.ValidationSummary(true) %>
        <%: this.Html.AntiForgeryToken() %>

        <fieldset>
            <legend>CreateEmployeeViewModel</legend>

            <div class="editor-field">
                <%: this.Html.EditorFor(model => model.DepartmentId) %>
            </div>
            <div class="editor-label">
                <%: this.Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%: this.Html.EditorFor(model => model.Name) %>
                <%: this.Html.ValidationMessageFor(model => model.Name) %>
            </div>
            <div class="editor-label">
                <%: this.Html.LabelFor(model => model.HireDate) %>
            </div>
            <div class="editor-field">
                <%: this.Html.EditorFor(model => model.HireDate) %>
                <%: this.Html.ValidationMessageFor(model => model.HireDate) %>
            </div>

            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>
    <% } %>

    <div>
        <%: this.Html.ActionLink("Back to List", "Detail", "Department") %>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>