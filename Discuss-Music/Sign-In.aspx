﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sign-In.aspx.cs" Inherits="Discuss_Music.Sign_In" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <script>

        function validateForm() {

            var form = document.forms["signIn"];
            var username = form["username"].value;
            var password = form["password"].value;

            if (username == null || password == null || secondPassword == null || name == null || email == null || birthday == null || phoneNumber == null)
            {
                alert("Please, fill all of the fields");
            }

            return true;
        }
        </script>

    <ul>

        <li><a href="Welcome.aspx">Introduction</a></li>
        <li><a href="Sign-Up.aspx">Sign Up</a></li>
        <li><a class="current" href="Sign-In.aspx">Sign In</a></li>

    </ul>

    <h2>Sign In</h2><br />

    <p><%=message %></p>

    <form id="signIn" runat="server" onsubmit="return validateForm();" >

        <div class="container">

			<div class="form-group">
				<input type="text" name="username" id="username" placeholder="enter username" class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="password" name="password" id="password" placeholder="enter password" class="form-control" size="165"> <br>
			</div>

			<input type="submit" id="submit" value="Sign In" class="btn btn-primary">
			<input type="reset">
		</div>
    </form>





</asp:Content>
