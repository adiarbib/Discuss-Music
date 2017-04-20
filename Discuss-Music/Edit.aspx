<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Discuss_Music.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>

        function validateForm1() {

            var form = document.forms["edit"];
            var username = form["username"].value;
            var password = form["password"].value;
            var secondPassword = form["secondPassword"].value;
            var phoneNumber = form["phoneNumber"].value;

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

            else if (username == null || password == null || secondPassword == null || name == null || email == null || birthday == null || phoneNumber == null) {
                alert("Please, fill all of the fields");
            }

            else if (!checkedValue)
                return false;

            return true;
        }
      </script>

    <ul>

        <li><a href="Feed.aspx">Feed</a></li>
        <li><a href="NewArticle.aspx">New</a></li>
        <li><a class="current" href="MyProfile.aspx">My Profile</a></li>
        <li><a href="Search.aspx">Search</a></li>
        <li><a href="Sign-In.aspx">Sign Out</a></li>

    </ul>

    <h2>Edit Your Details</h2>

    <p><%= message %></p><br />


    <form id="edit" runat="server" onsubmit="return validateForm1();" >

        <div class="container">

			<div class="form-group">
				<input type="text" name="username" id="username" placeholder="enter username" value=<%=username %> class="form-control" size="165"> <br>
			</div>

            <div class="form-group">
				<input type="text" name="name" id="name" placeholder="enter name" value=<%=name %> class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="password" name="password" id="password" placeholder="enter password" value=<%=password %> class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="password" name="secondPassword" id="secondPassword" placeholder="re-enter your password" value=<%=password %> class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="tel" name="phoneNumber" id="phoneNumber" placeholder="enter phone number" value=<%=phoneNumber %> class="form-control" size="165"> <br>
			</div>

			<div class="form-group">
				<input type="date" name="birthday" id="birthday" value=<%=birthday_string %> class="form-control" ><br>
			</div>

			<div class="form-group">
				<input type="email" name="email" id="email" placeholder="enter mail" value=<%=email %> class="form-control" size="165"> <br>
			</div>

			<input type="submit" id="submit" value="Save" class="btn btn-primary">
			<input type="reset">
		</div>
    </form>


</asp:Content>
