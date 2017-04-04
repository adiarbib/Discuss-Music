<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIn.Master" AutoEventWireup="true" CodeBehind="NewArticle.aspx.cs" Inherits="Discuss_Music.NewArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Add a new post</h3>
    <form id="newPost" runat="server" onsubmit="return true" >

        <div class="container">

			<div class="form-group">
                <p>Title: </p>
				<input type="text" name="title" id="title" placeholder="title" class="form-control" size="80"> <br>
			</div>

			<div class="form-group">
                <p>Content: </p>
				<input type="text" name="content" id="content" placeholder="content" class="form-control" size="80" maxlength="100"> <br>
			</div>

			<input type="submit" id="submit" value="Post It" class="btn btn-primary">
			<input type="reset">
		</div>
    </form>

</asp:Content>
