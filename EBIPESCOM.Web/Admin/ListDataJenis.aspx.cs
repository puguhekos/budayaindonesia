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

public partial class Admin_ListDataJenis : System.Web.UI.Page
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

        String constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        String strQuery = "select * from Table_Jenis_Budaya order by id_jenis_budaya";


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        ViewBudaya.DataSource = table;
        ViewBudaya.DataBind();
    }

    protected void ViewBudaya_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
    {
        (ViewBudaya.FindControl("DataPagerView") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        this.BindListData();
    }
}