<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-Master.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <!-- content -->
<div id="page-wrapper">
    <div class="row">
        <div class="col-md-12">
            <h2 class="page-header">Selamat Datang Admin</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-4 col-md-4">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-list fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <asp:ListView ID="dataBudaya" runat="server">
                                <EmptyDataTemplate>
                                    <table>
                                        <tr>
                                            <td>0</td>
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
                                    <div class="huge"><%#:Eval("id_budaya") %></div>
                                    <div>Data Budaya</div>
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
                <a href="ListDataBudaya.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Lihat Data</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-4 col-md-4">
            <div class="panel panel-green">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-tasks fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <asp:ListView ID="DataProv" runat="server">
                                <EmptyDataTemplate>
                                    <table>
                                        <tr>
                                            <td>0</td>
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
                                    <div class="huge"><%#:Eval("id_prov") %></div>
                                    <div>Data Provinsi</div>
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
                <a href="ListDataProvinsi.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Lihat Data</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-4 col-md-4">
            <div class="panel panel-yellow">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-bars fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <asp:ListView ID="dataJenis" runat="server">
                                <EmptyDataTemplate>
                                    <table>
                                        <tr>
                                            <td>0</td>
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
                                    <div class="huge"><%#:Eval("id_jenis_budaya") %></div>
                                    <div>Data Jenis Budaya</div>
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
                <a href="ListDataJenis.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Lihat Data</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
    </div>
</div>
<!-- end content -->
</asp:Content>

