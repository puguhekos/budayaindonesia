<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-Master.master" AutoEventWireup="true" CodeFile="DataForm.aspx.cs" Inherits="Admin_DataForm" ValidateRequest="false" %>

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
                        <i class="fa fa-pencil"></i> Edit Data Budaya
                    </div>
                    <div class="panel-body tabel-budaya">
                        <asp:ListView runat="server" ID="DataForm" DataKeyNames="id_budaya">
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
                                                        <div class="form-inline" role="form" runat="server">
					                                        <div class="form-group col-md-12">
                                                                <div class="col-md-3">
						                                            <label for="NamaBudaya">Nama Budaya</label>
                                                                </div>
                                                                <div class="col-md-6">      
                                                                    <%# Eval("nama_budaya") %>
					                                            </div>
                                                            </div>
					                                        <div class="form-group col-md-12">
                                                                <div class="col-md-3" style="padding-bottom:10px;">
						                                            <label for="gambarbudaya">Gambar Budaya</label> 
                                                                </div>
                                                                <div class="col-md-6">
                                                                     <img class="fit-form" src="/Budaya/<%#: Eval("file_path") %>"/>
                                                                </div>  
                                                            </div>
					                                        <div class="form-group col-md-12">
                                                                <div class="col-md-3">
						                                            <label for="jenisbudaya">Jenis Budaya</label>
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <%#: Eval("jenis_budaya") %>
                                                                </div>
                                                            </div>
                                                         
                                                              <div class="form-group col-md-12">
                                                                <div class="col-md-3">
						                                            <label for="provinsi">Provinsi</label>
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <%#: Eval("provinsi") %>
					                                            </div>
                                                            </div>
                                                            <div class="form-group col-md-12">
                                                                 <div class="col-md-3">
                                                                     <label for="sumber">Sumber</label>
                                                                 </div>
                                                                 <div class="col-md-6">
                                                                     <%#: Eval("sumber") %>
                                                                 </div>
                                                             </div>
                                                            <div class="form-group col-md-12">
                                                                <div class="col-md-3">
						                                            <label for="KetGambar">Keterangan Gambar</label>
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <asp:TextBox ID="ketgambar" TextMode="MultiLine" Columns="30" Rows="3" runat="server" Text='<%#:Eval("ket_img") %>'></asp:TextBox>
					                                            </div>
                                                            </div>
                                                            <div class="form-group col-md-12">
                                                                <div class="col-md-3">
						                                            <label for="KetBudaya">Keterangan Budaya</label>
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <asp:TextBox ID="ketbudaya" TextMode="MultiLine" Columns="50" Rows="7" CssClass="form-control" runat="server" Text='<%#: Eval("ket") %>'></asp:TextBox>
					                                            </div>
                                                            </div>
                                                            <div class="col-md-12">
                                                                
                                                                <asp:TextBox runat="server" ID="txtID" Text='<%#:Eval("id_budaya") %>' Visible="false"></asp:TextBox>
                                                            </div>
                                                            <div class="col-md-12 text-center" style="margin-top:10px;">
                                                                <asp:Button ID="update" CssClass="btn btn-primary" runat="server" OnClick="update_Click" Text="Update"/>
                                                                <asp:Button ID="hapus" CssClass="btn btn-primary" runat="server" OnClick="hapus_Click" Text="Hapus" />
                                                            </div>
				                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                         </td>
                               </ItemTemplate>
                              
                        </asp:ListView>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

