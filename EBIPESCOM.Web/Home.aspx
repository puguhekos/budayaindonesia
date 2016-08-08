<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeBehind="~/Home.aspx.cs" CodeFile="Home.aspx.cs" Inherits="Home" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                        <div class="col-md-6">
                            <h1 class="title animated zoomIn">selamat datang</h1>
                            <div class="line-divider"></div>
                            <p class="">Selamat Datang di Ensiklopedia Budaya Indonesia.
                                Sistem aplikasi berbasis website yang memberikan informasi keberagaman kebudayaan Indonesia.
                            </p>
                        </div>
                        <div class="col-md-6">
                            <div class="priview">
                                <div class="priview_demo">
                                    <asp:ListView ID="imgList" runat="server">
                                        <EmptyDataTemplate>
                                            <table>
                                                <tr>
                                                    <td><img src="assets/banner/siak.jpg" /></td>
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
                                            <img src="/Budaya/<%#: Eval("file_path") %>"/>
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
                            </div>
                        </div>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>

    <div id="background1" class="container-fluid">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="col-md-4 icon">
                        <a href="#"><i class="fa fa-facebook-square" style="color: #ffffff;font-size:10em;"></i></a>
                    </div>
                    <div class="col-md-4 icon">
                         <a href="#"><i class="fa fa-twitter-square" style="color: #ffffff;font-size:10em;"></i></a>
                    </div>
                    <div class="col-md-4 icon">
                         <a href="#"><i class="fa fa-instagram" style="color: #ffffff;font-size:10em;"></i></a>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </div>

    <div id="article-background" class="container-fluid">
        <div class="container text-center">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <h1 class="title animated zoomIn">Artikel</h1>
                    <div class="line-divider"></div>
                    <div class="col-md-12" style="margin-top:20px;">
                        <div class="article">
                            <div class="">
                                <asp:ListView ID="ArtikelID" GroupItemCount="3" runat="server">
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
                                                        <a href="Detail.aspx?id_budaya=<%#: Eval("id_budaya") %>">
                                                            <img class="fit-home" src="/Budaya/<%#: Eval("file_path") %>" style="margin-bottom:10px;"/>
                                                        </a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <a href="Detail.aspx?id_budaya=<%#: Eval("id_budaya") %>">
                                                            <span>
                                                                <h4><%#: Eval("nama_budaya") %></h4>
                                                            </span>
                                                        </a>
                                                        <br />
                                                        <span>
                                                            <%#: Eval("ket").ToString().PadRight(130).Substring(0,130).TrimEnd() %> ...
                                                        </span>
                                                        <br />
                                                        <a href="Detail.aspx?id_budaya=<%#: Eval("id_budaya") %>"><button type="button" class="read-more btn btn-primary">Baca Lebih Lengkap</button></a>
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
                    </div>
                    <a href="artikel_data.aspx" class="a-box-orange animated zoomIn">
                        <i class="glyphicon glyphicon-send"></i>
                            <strong>Artikel Lainnya</strong>
                    </a>
                </div>
                <div class="col-md-1"></div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>

