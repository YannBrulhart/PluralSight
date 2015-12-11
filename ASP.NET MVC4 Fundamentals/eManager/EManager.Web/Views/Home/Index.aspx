<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<eManager.Domain.Department>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    All Departments
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>All Departments</h2>  
    <ul>

        <% foreach (var department in this.Model)
           { %>
            <li>
                <%: this.Html.ActionLink(department.Name, "detail", "department", new { department.Id}, null) %>
            </li>
        <% } %>
    </ul>    

    <%--<p>
        <%: this.Html.ActionLink("Create New", "Create") %>
    </p>
    <table>
        <tr>
            <th>
                <%: this.Html.DisplayNameFor(model => model.Name) %>
            </th>
            <th></th>
        </tr>

        <% foreach (var item in this.Model)
           { %>
            <tr>
                <td>
                    <%: this.Html.DisplayFor(modelItem => item.Name) %>
                </td>
                <td>
                    <%: this.Html.ActionLink("Edit", "Edit", new { id = item.Id }) %> |
                    <%: this.Html.ActionLink("Details", "Details", new { id = item.Id }) %> |
                    <%: this.Html.ActionLink("Delete", "Delete", new { id = item.Id }) %>
                </td>
            </tr>
        <% } %>

    </table>--%>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>