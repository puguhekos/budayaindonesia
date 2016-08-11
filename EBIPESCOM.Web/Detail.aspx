<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        #silverlightControlHost {
            display: none !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="article-background" class="theme-content">
        <div class="container">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="col-md-1"></div>
                    <div class="col-md-10 animated zoomIn">
                        <asp:ListView ID="ListDataDetail" runat="server" OnItemDataBound="ListDataDetail_ItemDataBound">
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
                                    <table style="margin: 0px 20px;">
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
                                                            <span class="glyphicon glyphicon-tag" style="opacity: 0.5;"></span><%#: Eval("jenis_budaya") %>
                                                        </div>
                                                        <img src="/Budaya/<%#: Eval("file_path") %>" alt="Random Name" />
                                                        <div class="blog-category">
                                                            <asp:Literal ID="LitKetImg" runat="server"></asp:Literal>
                                                        </div>
                                                    </div>
                                                    <div class="desc">
                                                        <asp:Literal ID="LitDesc" runat="server"></asp:Literal>                                                             
                                                    </div>
                                                    <p>
                                                        <strong>Sumber :</strong> 
                                                        <a href="<%#: Eval("sumber") %>" target="_blank">
                                                            <asp:Literal ID="LitSumber" runat="server"></asp:Literal> 
                                                        </a>
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
                                <table style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td>
                                                <table id="groupPlaceHolderContainer" runat="server" style="width: 100%">
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
                    <div class="col-md-1"></div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

