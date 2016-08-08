<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Artikel-Jenis-Budaya.aspx.cs" Inherits="Artikel_Jenis_Budaya" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="article-background" class="theme-content">
        <div class="container text-center">
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10 animated zoomIn">
                    <h1 class="title animated flipInX">Artikel</h1>
                        
                    <asp:ListView ID="ListData" runat="server" GroupPlaceholderID="PlaceHolder1" GroupItemCount="3" ItemPlaceholderID="ItemHolder1" OnPagePropertiesChanging="ListData_PagePropertiesChanging">
                        <LayoutTemplate>
                            <table style="width:100%">
                                <tr>
                                </tr>
                                <asp:PlaceHolder runat="server" ID="PlaceHolder1"></asp:PlaceHolder>
                                <tr>
                                    <td colspan="3" class="pager-article">
                                        <asp:DataPager ID="dataPager" runat="server" PagedControlID="ListData" PageSize="9">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="false" ShowPreviousPageButton="true" ShowNextPageButton="false" />
                                                <asp:NumericPagerField ButtonType="Button"/>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton="false" />
                                            </Fields>
                                        </asp:DataPager>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <GroupTemplate>
                            <tr>
                                <asp:PlaceHolder runat="server" ID="ItemHolder1"></asp:PlaceHolder>
                            </tr>
                        </GroupTemplate>
                        <ItemTemplate>
                            <td runat="server">
                                <table style="margin:0px 20px;">
                                    <tr>
                                        <td>
                                            <a href="Detail.aspx?id_budaya=<%#: Eval("id_budaya") %>">
                                                <img class="fit" src="/Budaya/<%#: Eval("file_path") %>" style="margin-bottom:10px;"/>
                                            </a>
                                        </td>
                                    </tr>
                                    <br />
                                    <tr>
                                        <td>
                                            <a href="detail-artikel.aspx?id_budaya=<%#: Eval("id_budaya") %>">
                                                <span>
                                                    <h4><%#: Eval("nama_budaya") %></h4>
                                                </span>
                                            </a>
                                            <br />
                                            <span>
                                                <%#: Eval("ket").ToString().PadRight(140).Substring(0,140).TrimEnd() %> ...
                                            </span>
                                            <br />
                                            <a href="Detail.aspx?id_budaya=<%#: Eval("id_budaya") %>"><button type="button" class="read-more btn btn-primary">Baca Lebih Lengkap</button></a>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </ItemTemplate>
                    </asp:ListView>
                <div class="col-md-1"></div>
            </div>
            </div>
        </div>
    </div>
</asp:Content>

