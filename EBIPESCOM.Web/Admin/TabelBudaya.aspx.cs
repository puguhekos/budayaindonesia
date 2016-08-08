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

public partial class Admin_TabelBudaya : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if(!this.IsPostBack)
        {
            string query = "Select id_prov, nama_prov from provinsi";
            string constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = sdr["nama_prov"].ToString();
                            item.Value = sdr["id_prov"].ToString();
                            provinsi.Items.Add(item);
                        }
                    }
                    con.Close();
                }
            }
            provinsi.Items.Insert(0, new ListItem("-- Pilih Provinsi --", "0"));
        }

        if(!this.IsPostBack)
        {
            string query1 = "Select * from Table_Jenis_Budaya";
            string constr1 = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
            using (SqlConnection con1 = new SqlConnection(constr1))
            {
                using (SqlCommand cmd1 = new SqlCommand(query1))
                {
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = con1;
                    con1.Open();
                    //using (SqlDataReader sdr1 = cmd1.ExecuteReader())
                    //{
                    //    while (sdr1.Read())
                    //    {
                    //        ListItem item = new ListItem();
                    //        item.Text = sdr1["nama_jenis_budaya"].ToString();
                    //        item.Value = sdr1["id_jenis_budaya"].ToString();
                    //        jenisbudaya.Items.Add(item);
                    //    }
                    //}
                    jenisbudaya.DataSource = cmd1.ExecuteReader();
                    jenisbudaya.DataTextField = "nama_jenis_budaya";
                    jenisbudaya.DataValueField = "id_jenis_budaya";
                    jenisbudaya.DataBind();
                    con1.Close();
                }
            }
            jenisbudaya.Items.Insert(0, new ListItem("-- Pilih Jenis Budaya --", "0"));
        }

    }

    


    private Boolean InsertUpdateData(SqlCommand cmd)
    {
        string strConString = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        SqlConnection con = new SqlConnection(strConString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
            return false;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }
    protected void btnSimpanBudaya(object sender, EventArgs e)
    {
        string filename = Path.GetFileName(FileUpload2.PostedFile.FileName);
        FileUpload2.SaveAs(Server.MapPath("../interface/Budaya/" + filename));
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
            Stream fs = FileUpload2.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            byte[] bytes = br.ReadBytes((Int32)fs.Length);

            

            string strQuery = "insert into budaya1(nama_budaya, provinsi, jenis_budaya, ket, ket_img, sumber, image, file_path, id_prov, id_jenis)" + "values (@nama_budaya, @provinsi, @jenis_budaya, @ket, @ket_img, @sumber, @image, @file_path, @id_prov, @id_jenis)";
            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.Parameters.Add("@nama_budaya", NamaBudaya.Text);
            cmd.Parameters.Add("@provinsi", provinsi.SelectedItem.Text);
            cmd.Parameters.Add("@jenis_budaya", jenisbudaya.SelectedItem.Text);
            cmd.Parameters.Add("@ket", RichTextBox.Text);
            cmd.Parameters.Add("@ket_img", ketgambar.Text);
            cmd.Parameters.Add("@sumber", sumber.Text);
            cmd.Parameters.Add("@image", SqlDbType.Binary).Value = bytes;
            cmd.Parameters.Add("@file_path", "../interface/Budaya/" + filename );
            cmd.Parameters.Add("@id_prov", provinsi.SelectedItem.Value);
            cmd.Parameters.Add("@id_jenis", jenisbudaya.SelectedItem.Value);

            InsertUpdateData(cmd);

            Response.Write("<script>alert('Input Data Sukses')</script>");

            NamaBudaya.Text = "";
            provinsi.SelectedValue = "0";
            jenisbudaya.SelectedValue = "0";
            RichTextBox.Text = "";
            ketgambar.Text = "";
            sumber.Text = "";
            
        }
        else
        {
            Response.Write("<script>alert('Input Data Gagal')</script>");
        }
    }
}