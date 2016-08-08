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

public partial class Admin_TabelJenisBudaya : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            
            string strQuery = "insert into Table_jenis_budaya(nama_jenis_budaya)" + "values (@nama_Jenis_budaya)";
            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.Parameters.Add("@nama_jenis_budaya", NamaJenis.Text);

            InsertUpdateData(cmd);

            Response.Write("<script>alert('Input Data Sukses')</script>");

            NamaJenis.Text = "";

        }
    }