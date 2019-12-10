﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="voleyballnews.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <head>
        <title>Đăng kí</title>
         <link href="styles/StyleSheet1.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
        <link href="https://fonts.googleapis.com/css?family=Merriweather:300,400,400i|Noto+Sans:400,400i,700" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600" rel="stylesheet">
    </head>
    <body>
        <div class="to">
            <div class="form">
                <h2>Đăng Nhập</h2>
                <i class="fab fa-app-store-ios"></i>
                <label style="margin-left: -150px;">Họ và tên</label>
                <input type="text" name="hoten">
                <label>Số điện thoại</label>
                <input type="text" name="sdt">    
                <label style="margin-left: -180px;">Email</label>
                <input type="text" name="email"> 
                <input id="submit" type="submit" name="submit" value="Gửi">
            </div>                
        </div>
    </body>
</asp:Content>
