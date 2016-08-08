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

public partial class Admin_DataForm : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack) 
        { 
            BindDetailData();
        }
    }

    private void BindDetailData()
    {
        string id1 = Request.QueryString["id_budaya"];

        String constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        String strQuery = "select id_budaya, nama_budaya, provinsi, jenis_budaya, ket, ket_img, sumber, file_path from budaya1 where id_budaya=" + id1;


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        DataForm.DataSource = table;
        DataForm.DataBind();
    }
    protected void update_Click(object sender, EventArgs e)
    {
        string id1 = Request.QueryString["id_budaya"];
        
        string strQuery = "update budaya1 set ket=@ket, ket_img=@ket_img where id=" + id1;
        SqlCommand cmd = new SqlCommand(strQuery);

        //cmd.Parameters.Add("@ket", ketbudaya);
        //cmd.Parameters.Add("@ket_img", ketGambar);

        InsertUpdateData(cmd);

        Response.Write("<script>alert('Data Berhasil Di Update')</script>");
    }
    protected void hapus_Click(object sender, EventArgs e)
    {

        string id1 = Request.QueryString["id_budaya"];

        string strQuery = "delete from budaya1 where id_budaya=" + id1;
        SqlCommand cmd = new SqlCommand(strQuery);

        InsertUpdateData(cmd);

        Response.Redirect("ListDataBudaya.aspx");
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

}