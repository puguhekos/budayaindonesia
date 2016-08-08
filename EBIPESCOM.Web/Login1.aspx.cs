using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

public partial class Login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(
            "Data Source=espuguh-pc\\sqlexpress;Initial Catalog=PES17;Integrated Security=True;"
            );
        SqlCommand cmd = new SqlCommand(
            "select * from admin1 where username='" + nama.Text + "' and password='" + password.Text + "'", con
            );
        SqlDataAdapter sa = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
            {
                Response.Redirect("Admin/Admin.aspx");
            }
            else
            {
                Response.Write(
                    "<script>alert('SIlahkan Masukkan Username dan Password Yang Benar')</script>"
                    );
            }
    }
}