<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sign-In.aspx.cs" Inherits="Discuss_Music.Sign_In" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <ul>

        <li><a href="Sign-Up.aspx">Sign Up</a></li>
        <li><a class="current" href="Sign-In.aspx">Sign In</a></li>

    </ul>

    <h2>Sign In</h2>

    <p><%= message %></p><br />


    <form id="signIn" runat="server" onsubmit="return true" >

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
