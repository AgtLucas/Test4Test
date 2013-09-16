<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Test4Test.Models.Paises>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p><%: ViewBag.Message %></p>
<p><%: ViewData["Mensagem"] %></p>
<p><%: TempData["Mensagem"] %></p>
<p><%: Html.ActionLink("List", "List") %></p>

</asp:Content>
