<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sign-Up.aspx.cs" Inherits="Discuss_Music.Sign_Up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <script>

        function validateForm() {

            var form = document.forms["signUp"];
            var username = form["username"].value;
            var password = form["password"].value;
            var secondPassword = form["secondPassword"].value;
            var phoneNumber = form["phoneNumber"].value;
            var checkedValue = form["checkBox"].checked;

            if (username.length < 8) {
                alert("Username is too short");
                return false;
            }

            else if (password != secondPassword) {
                alert("you re-entered your password wrong");
                return false;
            }

            else if (password.length < 6) {
                alert("Password is too short");
                return false;
            }

            else if ((/^\d+$/.test(document.getElementById("phoneNumber").value)) == false) {
                alert("Phone number should be only digits!!!!!!!!");
                return false;
            }

            else if (!checkedValue)
                return false;

            return true;
        }
        </script>

    <ul>

        <li><a href="Welcome.aspx">Introduction</a></li>
        <li><a class="current" href="Sign-Up.aspx">Sign Up</a></li>
        <li><a href="Sign-In.aspx">Sign In</a></li>

    </ul>

    <h2>Sign Up</h2>

    <p><%= message %></p><br />


    <form id="signUp" runat="server" onsubmit="return validateForm();" >

        <div class="container">

			<div class="form-group">
				<input type="text" name="username" id="username" placeholder="enter username" class="form-control" size="165"> <br>
			</div>

            <div class="form-group">
				<input type="text" name="name" id="name" placeholder="enter name" class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="password" name="password" id="password" placeholder="enter password" class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="password" name="secondPassword" id="secondPassword" placeholder="re-enter your password" class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="tel" name="phoneNumber" id="phoneNumber" placeholder="enter phone number" class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="date" name="birthday" id="birthday" min="1970-01-01" max="2007-01-01" class="form-control" ><br>
			</div>

			<div class="form-group">
				<input type="email" name="email" id="email" placeholder="enter mail" class="form-control" size="165"> <br>
			</div>

			<div class="form-check">
				<input type="checkbox" name="checkBox" id="checkBox" value="CheckBox" checked class="form-check-input"> I confirm the terms <br>
			</div>

			<input type="submit" id="submit" value="Submit" class="btn btn-primary">
			<input type="reset">
		</div>
    </form>

</asp:Content>
