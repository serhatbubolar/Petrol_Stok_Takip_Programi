using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Petrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=DESKTOP-EQ95IAG\MSSQLSERVER01;Initial Catalog=TestBenzin;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EQ95IAG\MSSQLSERVER01;Initial Catalog=TestBenzin;Integrated Security=True");
        void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblkursunsuz95.Text = dr[3].ToString();
                pkursunsuz95.Value = int.Parse(dr[4].ToString());
                lblPkursunsuz95.Text = dr[4].ToString();
            }
            baglanti.Close();
            //Kurşunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblkursunsuz97.Text = dr2[3].ToString();
                pkursunsuz97.Value = int.Parse(dr2[4].ToString());
                lblPkursunsuz97.Text = dr2[4].ToString();
            }
            baglanti.Close();
            //EuroDizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEuroDizel.Text = dr3[3].ToString();
                pEuroDizel.Value = int.Parse(dr3[4].ToString());
                lblPEuroDizel.Text = dr3[4].ToString();
            }
            baglanti.Close();
            //YeniProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblProDizel.Text = dr4[3].ToString();
                pYeniProDizel.Value = int.Parse(dr4[4].ToString());
                lblPYeniProDizel.Text = dr4[4].ToString();
            }
            baglanti.Close();
            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM TBLBENZIN where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblGaz.Text = dr5[3].ToString();
                pGaz.Value = int.Parse(dr5[4].ToString());
                lblPGaz.Text = dr5[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from TBL_KASA",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void numerickursun96_ValueChanged(object sender, EventArgs e)
        {
            double kursun95, litre, tutar;
            kursun95 = Convert.ToDouble(lblkursunsuz95.Text);
            litre = Convert.ToDouble(numerickursun95.Value);
            tutar = kursun95 * litre;
            txtkursunsuz95fiyat.Text = tutar.ToString();
        }

        private void numerickursun97_ValueChanged(object sender, EventArgs e)
        {
            double kursun97, litre, tutar;
            kursun97 = Convert.ToDouble(lblkursunsuz97.Text);
            litre = Convert.ToDouble(numerickursun97.Value);
            tutar = kursun97 * litre;
            txtkursunsuz97fiyat.Text = tutar.ToString();
        }

        private void numericeurodizel_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = Convert.ToDouble(lblEuroDizel.Text);
            litre = Convert.ToDouble(numericeurodizel.Value);
            tutar = eurodizel * litre;
            txteurodizel10fiyat.Text = tutar.ToString();
        }

        private void numericprodizel_ValueChanged(object sender, EventArgs e)
        {
            double yenipro, litre, tutar;
            yenipro = Convert.ToDouble(lblProDizel.Text);
            litre = Convert.ToDouble(numericprodizel.Value);
            tutar = yenipro * litre;
            txtyeniprodizelfiyat.Text = tutar.ToString();
        }

        private void numericgaz_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(numericgaz.Value);
            tutar = gaz * litre;
            txtGazfiyat.Text = tutar.ToString();
        }

        private void btntDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numerickursun95.Value!=0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBL_HAREKET (PLAKA,BENZINTURU,FIYAT,LITRE) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1",txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2","Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3", numerickursun95.Value);
                komut.Parameters.AddWithValue("@p4",decimal.Parse(txtkursunsuz95fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBL_KASA set MIKTAR=MIKTAR+@p1",baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtkursunsuz95fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
                
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numerickursun95.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı!");
                listele();
            }
        }
    }
}
