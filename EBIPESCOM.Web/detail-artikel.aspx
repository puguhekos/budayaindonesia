<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ensiklopedia Budaya Indonesia</title>
    <link rel="Stylesheet" type="text/css" href="style/bootstrap.min.css" />
    <link rel="Stylesheet" type="text/css" href="style/pt_sans_font.css" />
    <link href='https://fonts.googleapis.com/css?family=PT+Sans:400,400italic,700,700italic' rel='stylesheet' type='text/css'/>
    <link rel="stylesheet" type="text/css" href="style/style.css" />
    <link rel="stylesheet" type="text/css" href="style/font-awesome.css" />
    <link rel="Stylesheet" type="text/css" href="style/animasi.css" />
    <link rel="shortcut icon" href="assets/images/ico.png" type="image/x-icon" />

    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="Silverlight.js"></script>
    <script type="text/javascript" src="js/wow.js"></script>
    
    <script type="text/javascript">
        function onSilverlightError(sender, args) {
            var appSource = "";
            if (sender != null && sender != 0) {
              appSource = sender.getHost().Source;
            }
            
            var errorType = args.ErrorType;
            var iErrorCode = args.ErrorCode;

            if (errorType == "ImageError" || errorType == "MediaError") {
              return;
            }

            var errMsg = "Unhandled Error in Silverlight Application " +  appSource + "\n" ;

            errMsg += "Code: "+ iErrorCode + "    \n";
            errMsg += "Category: " + errorType + "       \n";
            errMsg += "Message: " + args.ErrorMessage + "     \n";

            if (errorType == "ParserError") {
                errMsg += "File: " + args.xamlFile + "     \n";
                errMsg += "Line: " + args.lineNumber + "     \n";
                errMsg += "Position: " + args.charPosition + "     \n";
            }
            else if (errorType == "RuntimeError") {           
                if (args.lineNumber != 0) {
                    errMsg += "Line: " + args.lineNumber + "     \n";
                    errMsg += "Position: " +  args.charPosition + "     \n";
                }
                errMsg += "MethodName: " + args.methodName + "     \n";
            }

            throw new Error(errMsg);
        }
    </script>
    
</head>
<body>
    
    <div id="top-info" class="container-fluid navbar-fixed-top">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="col-md-6 pull-left">
                        <a href="Depan.aspx"><img src="assets/images/logo.png" alt=""/></a>
                    </div>
                    <div class="col-md-6 pull-right">
                        <div class="float-right">
                            <a href="Depan.aspx"><i class="fa fa-home"></i> Depan</a> <span class="separator">|</span>
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

    <div id="article-background" class="theme-content">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="col-md-1"></div>
                    <div class="col-md-10 animated zoomIn">
                        <asp:ListView ID="ListDataDetail" runat="server">
                            <EmptyDataTemplate>
                                <table>
                                    <tr>
                                        <td>Data Kosong</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <EmptyItemTemplate>
                                <td />
                            </EmptyItemTemplate>
                            <GroupTemplate>
                                <tr id="itemPlaceholderContainer" runat="server">
                                    <td id="itemPlaceholder"></td>
                                </tr>
                            </GroupTemplate>
                            <ItemTemplate>
                                        <td runat="server">
                                            <table style="margin:0px 20px;">
                                                <tr>
                                                    <td>
                                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                                        <h1 class="title animated zoomIn"><%#: Eval("nama_budaya") %></h1>
                                                        <!-- breadcrumb -->
			                                                <ul class="breadcrumb">
				                                                <li><a href="Home.aspx">Depan</a></li>
				                                                <li><a href="artikel_data.aspx">Artikel</a></li>
                                                                <li><%#: Eval("nama_budaya") %></li>
			                                                </ul>
                                                        <div class="line-divider"></div>
                                                        <div class="clearfix">
								                            <div class="thumb-50">
									                            <div class="blog-category">
										                            <span class="glyphicon glyphicon-tag" style="opacity:0.5;"></span> <%#: Eval("jenis_budaya") %>
									                            </div>
									                            <img src="/Budaya/<%#: Eval("file_path") %>" alt="Random Name"/>
                                                                <div class="blog-category">
										                            <i><%#: Eval("ket_img") %></i>
									                            </div>
								                            </div>
								                            <div class="desc">
									                            <%#: Eval("ket") %>
								                            </div>
								
								
								                            <p><strong>Penulis :</strong> Author</p>
								                            <p><strong>Sumber :</strong> <a href="<%#: Eval("sumber") %>" target="_blank"><%#: Eval("sumber") %></a>
                                                            <br />
								                            <!-- Go to www.addthis.com/dashboard to customize your tools -->
                                                            <div class="addthis_sharing_toolbox"></div>
							                            </div>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </ItemTemplate>
                                    <LayoutTemplate>
                                        <table style="width:100%">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <table id="groupPlaceHolderContainer" runat="server" style="width:100%">
                                                            <tr id="groupPlaceHolder"></tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </LayoutTemplate>

                        </asp:ListView>
                       </div>
                    <div class="col-md-1"></div>
               </div>
                <div class="col-md-1"></div>
            
        
            </div>
        </div>
    </div>

    <div id="footer-copyright" class="container-fluid">
        <div class="container">
            <div class="row">
                <div class="col-md-12 text-center div960">
                    Copyright &copy; 2016 | Ensiklopedia Budaya Indonesia. All rights reserved.
                </div>
            </div>
        </div>
    </div>
</body>
</html>
