﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login1.aspx.cs" Inherits="Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ensiklopedia Budaya Indonesia</title>
    <link rel="Stylesheet" type="text/css" href="style/bootstrap.min.css" />
    <!-- <link href='https://fonts.googleapis.com/css?family=PT+Sans:400,400italic,700,700italic' rel='stylesheet' type='text/css'/> -->
    <link rel="stylesheet" type="text/css" href="style/style.css" />
    <link rel="stylesheet" type="text/css" href="style/font-awesome.css" />
    <link rel="Stylesheet" type="text/css" href="style/animasi.css" />
    <link rel="shortcut icon" href="assets/images/ico.png" type="image/x-icon" />

    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="Silverlight.js"></script>
    <script type="text/javascript" src="js/wow.js"></script>

</head>
<body>

    <div id="top-info" class="container-fluid navbar-fixed-top">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="col-md-6 pull-left">
                        <a href="Home.aspx"><img src="assets/images/logo.png" alt=""/></a>
                    </div>
                    <div class="col-md-6 pull-right">
                        <div class="float-right">
                            <a href="Home.aspx"><i class="fa fa-home"></i> Depan</a> <span class="separator">|</span>
                            <a href="Artikel.aspx"><i class="fa fa-newspaper-o"></i> Artikel</a> <span class="separator">|</span>
                            <a href="Galeri.aspx"><i class="fa fa-file-image-o"></i> Galeri</a> <span class="separator">|</span>
                            <a href="Login1.aspx"><i class="fa fa-lock"></i> Login</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </div>

    <div class="container" style="margin:100px auto 50px;">
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4 text-center">
                <i class="fa fa-user-secret fa-3x" style="padding-bottom:10px;"></i>
                <form role="form" id="form1" runat="server">
					<div class="form-group">
						<label for="name">Username</label>
					    <asp:TextBox ID="nama" class="form-control" required="required" placeholder="Enter Your Name" runat="server"></asp:TextBox>
                    </div>
					<div class="form-group">
						<label for="password">Password</label>
                        <asp:TextBox ID="password" class="form-control" required="required" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
					<div class="form-group">        
                        <asp:Button ID="submit" class="btn btn-primary" runat="server" Text="Masuk" OnClick="submit_Click" />
                     
                        <a href="Home.aspx" type="button" class="btn btn-primary">Batal</a>
					</div>
				</form>
            </div>
            <div class="col-md-4"></div>
        </div>
    </div>
</body>
</html>
