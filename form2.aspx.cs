using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret
{
    public partial class form2 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            
            var id = Request.QueryString["id"];
            SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-8IDAPTH\BERKAY;Database=bbb;Integrated Security=true");
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into dbo.kullaniciler(kullanici,sifre,ıd) values (@kullanici,@sifre,@ıd)", baglanti);
            komut.Parameters.AddWithValue("@kullanici", TextBox1.Text);
            komut.Parameters.AddWithValue("@sifre", TextBox2.Text);
            Response.Redirect("Logi_Page.aspx");

            komut.ExecuteNonQuery();


            baglanti.Close();


        }
       
    }
}