<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-Master.master" AutoEventWireup="true" CodeFile="FormProvinsi.aspx.cs" Inherits="Admin_FormProvinsi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- content -->
<div id="page-wrapper">
    <div class="row">
        <div class="col-md-10 budaya">
            <h4 class="page-header"><i class="fa fa-table"></i> Data Provinsi</h4>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <i class="fa fa-table"></i> Tambah Data Provinsi
                </div>
                <div class="panel-body tabel-budaya">
                    <div class="form-inline" id="form1" runat="server">
                        <div class="form-group col-md-12">
                            <div class="col-md-3">
                                <label for="namaprov">Nama Provinsi</label>
                            </div>
                            <div class="col-md-6">
                                <asp:TextBox ID="namaprov" CssClass="form-control" required="required" placeholder="Nama Provinsi" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group col-md-12">
                            <div class="col-md-3">
                                <label for="ibukotaprov">Ibu Kota Porvinsi</label>
                            </div>
                            <div class="col-md-6">
                                <asp:TextBox ID="ibukotaprov" CssClass="form-control" required="required" placeholder="Ibu Kota Provinsi" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group col-md-12">
                            <div class="col-md-3">
                                <label for="logoprov">Logo Provinsi</label>
                            </div>
                            <div class="col-md-6">
                                <asp:FileUpload ID="logoprov" runat="server" />
                            </div>
                        </div>
                        <div class="form-group col-md-12">
                            <div class="col-md-3">
                                <label for="ketprov">Keterangan</label>
                            </div>
                            <div class="col-md-6">
                                <asp:TextBox ID="ketprov" TextMode="MultiLine" Columns="45" Rows="5" placeholder="Keterangan" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12 text-center" style="margin-top:10px;">
                            <asp:Button ID="simpanprov" CssClass="btn btn-primary" runat="server" Text="Simpan" OnClick="btnsimpanprov" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>

