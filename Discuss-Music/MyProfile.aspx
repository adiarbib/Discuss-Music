<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="Discuss_Music.MyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        h1,h2{
            text-align:center;
        }
        

    </style>

    <ul>

        <li><a href="Feed.aspx">Feed</a></li>
        <li><a href="NewArticle.aspx">New</a></li>
        <li><a class="current" href="MyProfile.aspx">My Profile</a></li>
        <li><a href="Search.aspx">Search</a></li>
        <li><a href="Sign-In.aspx">Sign Out</a></li>

    </ul><br />

    <h1>Name: <%=name %></h1><br />
    <h2>Username: <%=username %></h2>
    <h2>Password: <%=password %></h2>
    <h2>Phone Number: <%=phoneNumber %></h2>
    <h2>Email: <%=email %></h2>
    <h2>Birthday: <%=birthday %></h2><br />
    <h2>All Posts:</h2><br />
    <%=insideBody %>






</asp:Content>
