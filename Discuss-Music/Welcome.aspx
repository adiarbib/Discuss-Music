<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Discuss_Music.Welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>

        div {
            background-color: initial;
            border-style: initial;
        }

    </style>

    <ul>

        <li><a class="current" href="Welcome.aspx">Introduction</a></li>
        <li><a href="Sign-Up.aspx">Sign Up</a></li>
        <li><a href="Sign-In.aspx">Sign In</a></li>

    </ul>

    <h2>Welcome to Discuss Music</h2>
    <h3>Where Your Wishes Can Come <i>True</i></h3><br />

    <p>
       Welcome to the best music forum online. Here in Discuss Music you can talk about literally anything that you may find interesting about your favorite music: your favorite songs, albums, singers, bands and so on.
       Make sure to <a href="Sign-Up.aspx">register</a> - it's free and very quick! You have to register before you can post and participate in our discussions with over 70,000 other registered members.
       If you're already registered you can <a href="Sign-In.aspx">sign in</a> and enter the feed in no time!
    </p>

    <p>
        Discuss Music is a very popular site that has a large influence on the music world. In fact it was places 8th in <a href="https://www.forbes.com/sites/michelecatalano/2013/01/24/7-websites-for-music-lovers/#4d559642e3ce"><i>Forbes article - 8 Websites for Music Lovers</i></a>
    </p><br />

    <h3>Celebrities have shown their respect to the site:</h3>

    <div class = "nav">
    <div class = "container2">

        <div class = "image">
            <img src="http://cdn.playbuzz.com/cdn/e8d63741-1ccc-4dfe-8a38-3353103bdebd/fdd94a51-3457-4441-83ff-27df706ee097.jpeg"> 
        </div>
        <div class = "title">
            <p> Michael Jackson when was asked about the site </p>
        </div>

    </div>

     <div class = "container2">

        <div class = "image">
            <img src="https://s-media-cache-ak0.pinimg.com/236x/2b/f9/c0/2bf9c0d803c2ec3b16970b3c80267222.jpg"> 
        </div>
        <div class = "title">
            <p> Chris Martin, Just signed up </p>
        </div>

    </div>

     <div class = "container2">

        <div class = "image">
            <img src="https://s-media-cache-ak0.pinimg.com/564x/1f/f7/77/1ff7777fdba197aa94025fb6f7069eae.jpg"> 
        </div>
        <div class = "title">
            <p> "WOW" -Alex Turner </p>
        </div>

    </div>
</div> 

</asp:Content>
