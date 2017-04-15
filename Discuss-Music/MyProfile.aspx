<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="Discuss_Music.MyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

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

    <h2>My Profile</h2>
    <div class="edit">
        <a href="Edit.aspx" class="btn btn-default">Edit Details</a>
    </div>
    <h3>Name: <%=name %></h3>
    <h3>Username: <%=username %></h3>
    <h3>Password: <%=password %></h3>
    <h3>Phone Number: <%=phoneNumber %></h3>
    <h3>Email: <%=email %></h3>
    <h3>Birthday: <%=birthday %></h3><br />
    <h2>All Posts:</h2><br />
    <%=insideBody %>






</asp:Content>
