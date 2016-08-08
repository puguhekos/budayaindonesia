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

public partial class Admin_DataFormProvinsi : System.Web.UI.Page
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
        string id = Request.QueryString["id_prov"];

        String constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        String strQuery = "select * from provinsi order by id_prov";


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        DataForm.DataSource = table;
        DataForm.DataBind();
    }
    protected void update_Click(object sender, EventArgs e)
    {
        
    }
    protected void hapus_Click(object sender, EventArgs e)
    {

        string id1 = Request.QueryString["id_prov"];

        string strQuery = "delete from provinsi where id_budaya=" + id1;
        SqlCommand cmd = new SqlCommand(strQuery);

        InsertUpdateData(cmd);

        Response.Redirect("ListDataProvinsi.aspx");
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