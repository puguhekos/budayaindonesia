<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-Master.master" AutoEventWireup="true" CodeFile="TabelJenisBudaya.aspx.cs" Inherits="Admin_TabelJenisBudaya" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
    <div class="row">
        <div class="col-md-10 budaya">
            <h4 class="page-header"><i class="fa fa-table"></i> Data Budaya</h4>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <i class="fa fa-table"></i> Tambah Data Budaya
                </div>
                <div class="panel-body tabel-budaya">
                         <div class="form-inline" role="form" runat="server">
					        <div class="form-group col-md-12">
                                <div class="col-md-2"></div>
                                <div class="col-md-8">
                                    <div class="col-md-4" style="text-align:right;padding-top:5px;">
						                <label for="NamaBudaya">Jenis Budaya</label>
                                    </div>
                                    <div class="col-md-4">      
                                        <asp:TextBox ID="NamaJenis" CssClass="form-control" required="required" placeholder="Nama Jenis Budaya" runat="server"></asp:TextBox>
					                </div>
                                </div>
                                <div class="col-md-2"></div>
                            </div>
					        
                            <div class="col-md-12 text-center" style="margin-top:10px;">
                                <asp:Button ID="simpan" CssClass="btn btn-primary" runat="server" Text="Simpan" OnClick="btnSimpanBudaya" />
                                <asp:Button ID="batal" CssClass="btn btn-primary" runat="server" Text="Batal" />
                            </div>

				        </div>
                    
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end content -->
</asp:Content>

