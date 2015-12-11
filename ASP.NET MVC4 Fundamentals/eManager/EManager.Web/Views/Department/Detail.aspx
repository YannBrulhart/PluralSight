<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<eManager.Domain.Department>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Department Detail
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: @Model.Name %></h2>

<%--    <fieldset>
        <legend>Department</legend>

        <div class="display-label">
            <%: this.Html.DisplayNameFor(model => model.Name) %>
        </div>
        <div class="display-field">
            <%: this.Html.DisplayFor(model => model.Name) %>
        </div>
    </fieldset>--%>
    <%
        if (Roles.IsUserInRole("sales"))
        {
            %><%: this.Html.ActionLink("Create an employee", "Create", "Employee", new { departmentId = @Model.Id }, null) %><%
        }
    %>
    <table>
        <tr>
            <th>Name</th>
            <th></th>
        </tr>
        <% foreach (var employee in this.Model.Employees)
           {
        %>
            <tr>
                <td><%: employee.Name %></td>
                <td></td>
            </tr>
        <%
           }
        %>
    </table>
    <p>

        <%: this.Html.ActionLink("Edit", "Edit", new { id = this.Model.Id }) %> |
        <%: this.Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>