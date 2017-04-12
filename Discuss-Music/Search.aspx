<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Discuss_Music.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>

        h3,h2,h4{
            text-align:center;
        }

    </style>

    <ul>

        <li><a href="Feed.aspx">Feed</a></li>
        <li><a href="NewArticle.aspx">New</a></li>
        <li><a href="MyProfile.aspx">My Profile</a></li>
        <li><a class="current" href="Search.aspx">Search</a></li>
        <li><a href="Sign-In.aspx">Sign Out</a></li>

    </ul><br />

    <form id="searchForm" runat="server" onsubmit="return true">
        
        <div class="container">

			<div class="form-group">
				<input type="text" name="search" id="search" placeholder="Search post or user" class="form-control" size="165"> <br>
                <input type="submit" id="submit" value="Search me" class="btn btn-primary">
			</div>

        </div>
    </form>

    

    <%=insideBody %>


</asp:Content>
