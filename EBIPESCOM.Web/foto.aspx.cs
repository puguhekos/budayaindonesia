using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class foto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            BindListData1();
       
    }

   

    private void BindListData1()
    {

        String constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        //String strQuery = "select top 1 id_budaya, jenis_budaya, file_path from budaya1 where id_jenis=('1')";
        String strQuery = "select budaya1.id_budaya, budaya1.jenis_budaya, budaya1.id_jenis, budaya1.file_path, Table_Jenis_Budaya.id_jenis_budaya from budaya1, Table_Jenis_Budaya where id_jenis=id_jenis_budaya";


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        
        ListData.DataSource = table;
        ListData.DataBind();
    }
   
}