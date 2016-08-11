using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

public partial class Detail : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
        BindDetailData();
    }

    private void BindDetailData()
    {
        string id1 = Request.QueryString["id_budaya"];

        String constr = "Data Source = localhost; Initial Catalog = PES17; Integrated Security = True; ";
        String strQuery = "select id_budaya, nama_budaya, provinsi, jenis_budaya, ket, ket_img, sumber, file_path from budaya1 where id_budaya=" + id1;


        SqlDataAdapter sda = new SqlDataAdapter(strQuery, constr);

        DataTable table = new DataTable();

        sda.Fill(table);

        ListDataDetail.DataSource = table;
        ListDataDetail.DataBind();
    }

    public void ListDataDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        var item = e.Item.DataItem;
        if (item != null)
        {
            Literal LitItem = e.Item.FindControl("LitDesc") as Literal;
            Literal LitKetImg = e.Item.FindControl("ket_img") as Literal;
            Literal LitSumber = e.Item.FindControl("sumber") as Literal;
            DataRowView rowView = (DataRowView) e.Item.DataItem;
            LitItem.Text = rowView["ket"].ToString();

        }
    }
}