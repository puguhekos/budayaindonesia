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

public partial class Artikel_Jenis_Budaya : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindListData();
        }
    }

    private void BindListData()
    {
        string id2 = Request.QueryString["jenis_budaya"];

        String constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        String strQuery = "select id_budaya, nama_budaya, provinsi, jenis_budaya, ket, ket_img, sumber, file_path from budaya where jenis_budaya=" + id2;


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        ListData.DataSource = table;
        ListData.DataBind();
    }
    protected void ListData_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
    {
        (ListData.FindControl("dataPager") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        this.BindListData();
    }
}