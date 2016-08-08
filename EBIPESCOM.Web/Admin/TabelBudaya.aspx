<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TabelBudaya.aspx.cs" Inherits="Admin_TabelBudaya" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ensiklopedia Budaya Indonesia</title>
    <link rel="stylesheet" type="text/css" href="../style/style.css"/>
    <link href="../style/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <!-- Custom CSS -->
    <link href="../style/sb-admin-2.css" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="../style/font-awesome.css" />
    <link rel="shortcut icon" href="../assets/images/ico.png" type="image/x-icon"/>
    <link href='https://fonts.googleapis.com/css?family=PT+Sans:400,400italic,700,700italic' rel='stylesheet' type='text/css'/>
    
    <script type="text/javascript" src ="../js/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script type="text/javascript" src="../js/bootstrap.min.js"></script>
    <script type="text/javascript" src="//cdn.tinymce.com/4/tinymce.min.js"></script>

    <script>tinymce.init({ selector: 'textarea' });</script>

</head>
<body>
<div id="top-info" class="container-fluid navbar-fixed-top">
    <div class="container">
        <div class="row">
            <div class="pull-right">
                <a href="../Home.aspx"><img src="../assets/images/logo.png" alt=""/></a>
            </div>
        </div>
    </div>
</div>

<!-- side menu -->
<div class="navbar-default sidebar">
    <div class="sidebar-nav navbar-collapse">
        <ul class="nav" id="side-menu">
            <li>
                <a href="Admin.aspx"><i class="fa fa-dashboard fa-fw"></i> Dashboard</a>
            </li>
            <li>
                <a class="active" data-toggle="collapse" href="#dropdown-lvl1"><i class="fa fa-table fa-fw"></i> Data Budaya<span class="caret arrow"></span></a>

                <div id="dropdown-lvl1" class="panel-collapse collapse nav-second-level">
                    <div class="panel-body">
                        <ul class="nav navbar-nav">
                            <li class="active"><a href="TabelBudaya.aspx"><i class="fa fa-table fa-fw"></i> Tambah Data</a></li>
                            <li><a href="ListDataBudaya.aspx"><i class="fa fa-edit fa-fw"></i> Tabel Data</a></li>
                        </ul>
                    </div>
                </div>
            </li>
            <li>
                <a data-toggle="collapse" href="#dropdown-lvl1a"><i class="fa fa-bar-chart-o fa-fw"></i> Data Provinsi<span class="caret arrow"></span></a>
                <div id="dropdown-lvl1a" class="panel-collapse collapse nav-second-level">
                    <div class="panel-body">
                        <ul class="nav navbar-nav">
                            <li><a href="TabelProvinsi.aspx"><i class="fa fa-table fa-fw"></i> Tambah Provinsi</a></li>
                            <li><a href="DataProvinsi.aspx"><i class="fa fa-edit fa-fw"></i> Edit Data</a></li>
                        </ul>
                    </div>
                </div>
            </li>
            <li>
                    <a href="TabelJenisBudaya.aspx"><i class="fa fa-edit"></i> Jenis Budaya</a>
                </li>
            <li>
                <a href="../Home.aspx"><i class="fa fa-unlock fa-fw"></i> Log Out</a>
            </li>
        </ul>
    </div>
</div>
<!-- end side menu -->

<!-- content -->
<div id="page-wrapper">
    <div class="row">
        <div class="col-md-10 budaya">
            <h4 class="page-header"><i class="fa fa-table"></i> Data Budaya</h4>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <i class="fa fa-table"></i> Tambah Data Budaya
                </div>
                <div class="panel-body tabel-budaya">
                         <form class="form-inline" role="form" runat="server">
					        <div class="form-group col-md-12">
                                <div class="col-md-2">
						            <label for="NamaBudaya">Nama Budaya</label>
                                </div>
                                <div class="col-md-6">      
                                    <asp:TextBox ID="NamaBudaya" CssClass="form-control" required="required" placeholder="Nama Budaya" runat="server"></asp:TextBox>
					            </div>
                            </div>
					        <div class="form-group col-md-12">
                                <div class="col-md-2" style="padding-bottom:10px;">
						            <label for="gambarbudaya">Gambar Budaya</label> 
                                </div>
                                <div class="col-md-6">
                                    <asp:FileUpload ID="FileUpload2" runat="server" />
                                </div>  
                            </div>
					        <div class="form-group col-md-12">
                                <div class="col-md-2">
						            <label for="jenisbudaya">Jenis Budaya</label>
                                </div>
                                <div class="col-md-6">
                                    <asp:DropDownList ID="jenisbudaya" CssClass="form-control" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                              <div class="form-group col-md-12">
                                <div class="col-md-2">
						            <label for="provinsi">Provinsi</label>
                                </div>
                                <div class="col-md-6">
                                    <asp:DropDownList ID="provinsi" CssClass="form-control" runat="server"></asp:DropDownList>
					            </div>
                            </div>
					        <div class="form-group col-md-12">
                                <div class="col-md-2">
						            <label for="KetGambar">Keterangan Gambar</label>
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox ID="ketgambar" TextMode="MultiLine" Columns="25" Rows="3" CssClass="form-control" runat="server"></asp:TextBox>
					            </div>
                            </div>
                             <div class="form-group col-md-12">
                                 <div class="col-md-2">
                                     <label for="sumber">Sumber</label>
                                 </div>
                                 <div class="col-md-6">
                                     <asp:TextBox ID="sumber" TextMode="MultiLine" Columns="25" Rows="2" CssClass="form-control" runat="server"></asp:TextBox>
                                 </div>
                             </div>
					        <div class="form-group col-md-12">
                                <div class="col-md-2">
						            <label for="KetBudaya">Keterangan Budaya</label>
                                </div>
                                <div class="col-md-6">
                                   
                                    <asp:TextBox ID="RichTextBox" TextMode="MultiLine" runat="server" Columns="80" Rows="6" CssClass="form-control"></asp:TextBox>
					            </div>
                            </div>
                            <div class="col-md-12 text-center" style="margin-top:10px;">
                                <asp:Button ID="simpan" CssClass="btn btn-primary" runat="server" Text="Simpan" OnClick="btnSimpanBudaya" />
                                <asp:Button ID="batal" CssClass="btn btn-primary" runat="server" Text="Batal" />
                            </div>

				        </form>
                    
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end content -->

<div id="footer-copyright">
    <div class="div960">
        Copyright &copy; 2016 | Ensiklopedia Budaya Indonesia. All rights reserved.
    </div>
</div>


</body>
</html>
