<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Discuss_Music.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>

        input[type=text] {
            width: 250px;
            box-sizing: border-box;
            border: 2px solid #ccc;
            border-radius: 4px;
            font-size: 16px;
            background-color: white;
            background-image: url('searchicon.png');
            background-position: 10px 10px; 
            background-repeat: no-repeat;
            padding: 12px 20px 12px 40px;
            -webkit-transition: width 0.4s ease-in-out;
            transition: width 0.4s ease-in-out;
        }

        input[type=text]:focus {
            width: 100%;
        }

    </style>

    <ul>

        <li><a href="Feed.aspx">Feed</a></li>
        <li><a href="NewArticle.aspx">New</a></li>
        <li><a class="current" href="MyProfile.aspx">My Profile</a></li>
        <li><a href="Sign-In.aspx">Sign Out</a></li>

    </ul><br />

    <form>
        
        <div class="container">

			<div class="form-group">
				<input type="text" name="search" id="search" placeholder="Search user or post" class="form-control" size="165"> <br>
			</div>

        </div>
    </form>


</asp:Content>
