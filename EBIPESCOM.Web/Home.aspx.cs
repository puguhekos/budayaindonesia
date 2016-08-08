using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindListView();
        BindImgView();
    }

    private void BindImgView()
    {
        string constr1 = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        string query = "select top 1 file_path from budaya1 order by id_budaya desc";

        SqlDataAdapter ada = new SqlDataAdapter(query, constr1);
        DataTable tb = new DataTable();

        ada.Fill(tb);

        imgList.DataSource = tb;
        imgList.DataBind();

    }

    private void BindListView()
    {
        
        String constr = "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;";
        String strQuery = "select top 3 id_budaya, nama_budaya, provinsi, jenis_budaya, ket, ket_img, sumber, file_path from budaya1 order by id_budaya desc";

        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);
        DataTable table = new DataTable();

        sda.Fill(table);

        ArtikelID.DataSource = table;
        ArtikelID.DataBind();
    }
}