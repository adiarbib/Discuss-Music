<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="Feed.aspx.cs" Inherits="Discuss_Music.Feed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <ul>

        <li><a class="current" href="Feed.aspx">Feed</a></li>
        <li><a href="NewArticle.aspx">New</a></li>
        <li><a href="MyProfile.aspx">My Profile</a></li>
        <li><a href="Search.aspx">Search</a></li>
        <li><a href="Sign-In.aspx">Sign Out</a></li>

    </ul>

    <h2>Feed</h2>

    <p>Hello <%= userName %></p>

    <%=insideBody %>

    


</asp:Content>
