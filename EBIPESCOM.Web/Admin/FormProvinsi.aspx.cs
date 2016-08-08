using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.IO;

public partial class Admin_FormProvinsi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsimpanprov(object sender, EventArgs e)
    {
        string filename = Path.GetFileName(logoprov.PostedFile.FileName);
        logoprov.SaveAs(Server.MapPath("../interface/Provinsi/" + filename));
        string ext = Path.GetExtension(filename);
        string contenttype = String.Empty;

        switch (ext)
        {
            case ".jpg":
                contenttype = "image/jpg";
                break;
            case ".png":
                contenttype = "image/png";
                break;
            case ".jpeg":
                contenttype = "image/jpeg";
                break;
            case ".gif":
                contenttype = "image/gif";
                break;
        }

        if (contenttype != string.Empty)
        {
            Stream fs = logoprov.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);

            byte[] bytes = br.ReadBytes((Int32)fs.Length);

            string strQuery = "insert into provinsi(nama_prov, ibukota_prov, logo_prov, ket, file_path)" + "values (@nama_prov, @ibukota_prov, @logo_prov, @ket, @file_path)";
            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.Parameters.Add("@nama_prov", namaprov.Text);
            cmd.Parameters.Add("@ibukota_prov", ibukotaprov.Text);
            cmd.Parameters.Add("@logo_prov", SqlDbType.Binary).Value = bytes;
            cmd.Parameters.Add("@ket", ketprov.Text);
            cmd.Parameters.Add("@file_path", "../interface/Provinsi/" + filename);
            InsertUpdateData(cmd);

            namaprov.Text = "";
            ibukotaprov.Text = "";
            ketprov.Text = "";

            Response.Write("<script>alert('Input Data Sukses')</script>");
        }
        else
        {
            Response.Write("<script>alert('Input Data Gagal')</script>");
        }
    }

    private void InsertUpdateData(SqlCommand cmd)
    {
        string strConString = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        SqlConnection con = new SqlConnection(strConString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }

}