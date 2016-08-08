<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-Master.master" AutoEventWireup="true" CodeFile="ListDataJenis.aspx.cs" Inherits="Admin_ListDataJenis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- content -->
    <div id="page-wrapper">
        <div class="row">
            <div class="col-md-10 budaya">
                <h4 class="page-header"><i class="fa fa-table"></i> Data Budaya</h4>
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <i class="fa fa-edit"></i> Tabel Data
                    </div>
                    <div class="panel-body tabel-budaya">
                        <asp:ListView runat="server" ID="ViewBudaya" GroupPlaceholderID="GrupViewBudaya" ItemPlaceholderID="ItemViewBudaya" OnPagePropertiesChanging="ViewBudaya_PagePropertiesChanging">
                            <LayoutTemplate>
                                <table>
                                    <tr>
                                        <th class="list-table">
                                            Jenis Budaya
                                        </th>
                                        
                                    </tr>
                                    <asp:PlaceHolder runat="server" ID="GrupViewBudaya"></asp:PlaceHolder>
                                    <tr>
                                        <td colspan="12" class="pager-article">
                                            <asp:DataPager ID="DataPagerView" runat="server" PagedControlID="ViewBudaya" PageSize="10">
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
                                    <asp:PlaceHolder runat="server" ID="ItemViewBudaya"></asp:PlaceHolder>
                                </tr>
                            </GroupTemplate>
                            <ItemTemplate>
                                <td class="list-table" style="width:400px;">
                                        <%#: Eval("nama_jenis_budaya") %>
                                    </a>
                                </td>
                                
                            </ItemTemplate>

                        </asp:ListView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

