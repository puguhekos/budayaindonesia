<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="foto.aspx.cs" Inherits="foto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #silverlightControlHost {
            display:none !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="article-background" class="theme-content">
        <div class="container text-center">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10 animated zoomIn">
                    <h1 class="title animated flipInX">Galeri Foto</h1>
                        <!-- breadcrumb -->
			            <ul class="breadcrumb">
				            <li><a href="Home.aspx">Depan</a></li>
				            <li>Galeri Foto</li>
			            </ul>
                    <div class="line-divider"></div>
                    <div class="col-md-12">
                        <asp:ListView ID="ListData" GroupItemCount="5" runat="server">
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
                                    <table>
                                        <tr>
                                            <td>
                                                <a class="fancybox" href="/Budaya/<%#: Eval("file_path") %>" data-fancybox-group="gallery">
                                                    <img class="fit img-circle person" src="/Budaya/<%#: Eval("file_path") %>"/>
                                                </a>
                                                <div class="foto-title">
                                                    <%#:Eval("jenis_budaya") %>
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
        </div>
    </div>
</asp:Content>

