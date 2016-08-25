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

public partial class Admin_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            BindDetailData();
            bindDetailProv();
            bindDetailJenis();
        }
    }

    private void bindDetailJenis()
    {
        String constr = "Data Source = localhost; Initial Catalog = PES17; Integrated Security = True; ";
        String strQuery = "select top 1 id_jenis_budaya from Table_Jenis_Budaya order by id_jenis_budaya desc";


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        dataJenis.DataSource = table;
        dataJenis.DataBind();
    }

    private void bindDetailProv()
    {
        String constr = "Data Source = localhost; Initial Catalog = PES17; Integrated Security = True; ";
        String strQuery = "select count (*) from provinsi";


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        DataProv.DataSource = table;
        DataProv.DataBind();
    }

    private void BindDetailData()
    {

        String constr = "Data Source = localhost; Initial Catalog = PES17; Integrated Security = True; ";
        String strQuery = "select top 1 id_budaya from budaya1 order by id_budaya desc";


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        dataBudaya.DataSource = table;
        dataBudaya.DataBind();
    }
}