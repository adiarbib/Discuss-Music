<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="NewArticle.aspx.cs" Inherits="Discuss_Music.NewArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <ul>

        <li><a href="Feed.aspx">Feed</a></li>
        <li><a class="current" href="NewArticle.aspx">New</a></li>
        <li><a href="MyProfile.aspx">My Profile</a></li>
        <li><a href="Search.aspx">Search</a></li>
        <li><a href="Sign-In.aspx">Sign Out</a></li>

    </ul>

    <h2>Add a new post</h2>
    <p><%= message %></p><br />
    <form id="newPost" runat="server" onsubmit="return true" >

        <div class="container">

			<div class="form-group">
                <p>Title: </p>
				<input type="text" name="title" id="title" placeholder="title" class="form-control" > <br>
			</div>

			<div class="form-group">
                <p>Content: </p>
				<input type="text" name="content" id="content" placeholder="content" class="form-control" > <br>
			</div>

			<input type="submit" id="submit" value="Post It" class="btn btn-primary">
			<input type="reset">
		</div>
    </form>

</asp:Content>
