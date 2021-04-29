using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace E_Ticaret
{
    public partial class shopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
          
        {
            var id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                using (SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-8IDAPTH\BERKAY;Database=bbb;Integrated Security=true"))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(@"select * from YeniUrunler", baglanti);

                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        Image1.ImageUrl = dr[0].ToString();
                        //Image2.ImageUrl = dr[1].ToString();
                        //Image3.ImageUrl = dr[2].ToString();
                        //Image4.ImageUrl = dr[3].ToString();
                        //Image5.ImageUrl = dr[4].ToString();




                    }
                    dr.Close();
                    baglanti.Close();
                }

            }

        }

       // protected void Button1_Click(object sender, EventArgs e)
        //{
            //SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-2CBP0DD\SQLEXPRESS;Database=database;Integrated Security=true");
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand(@"insert into dbo.urun_bilgiler(urun_adı,urun_fiyat,urun_resim) values (@p2,@p3,@p4)", baglanti);

            //komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            //komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            ////     komut.Parameters.AddWithValue("@p4", TextBox1.Text);


            //komut.Parameters.AddWithValue("@p4", FileUpload1.PostedFile.FileName);
            //komut.ExecuteNonQuery();

            //baglanti.Close();
        //}

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=1");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=3");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=4");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=6");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=10");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=2");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx?urunID=12");
        }
    }
}