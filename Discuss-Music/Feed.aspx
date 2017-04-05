<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="Feed.aspx.cs" Inherits="Discuss_Music.Feed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Feed</h2>

    <p>Hello <%= userName %></p>

    <%=insideBody %>

    


</asp:Content>
