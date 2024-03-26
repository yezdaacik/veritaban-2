using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veri_tabanı_örnek_2_815
{
    public partial class Form1 : Form
    {
        string baglanti = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwGuncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgwFilmler.SelectedRows.Count> 0)
            {
                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();
                    string sorgu = "UPDATE filmler " +
                               "SET film_ad = @film_ad, yonetmen=@yonetmen, sure=@sure, yil=@yil " +
                               "WHERE film_id = @film_id;";

                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);

                    cmd.Parameters.AddWithValue("@film_ad",txtAd.Text);
                    cmd.Parameters.AddWithValue("@yonetmen", txtYonetmen.Text);
                    cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                    cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                    cmd.Parameters.AddWithValue("@film_id", dgwFilmler.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();

                    dgwGuncelle();
                }
            }
        }
       

        private void dgwFilmler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgwFilmler.CurrentRow.Cells[1].Value.ToString();
            txtYonetmen.Text = dgwFilmler.CurrentRow.Cells[2].Value.ToString();
            txtYil.Text = dgwFilmler.CurrentRow.Cells[3].Value.ToString();
            txtSure.Text = dgwFilmler.CurrentRow.Cells[5].Value.ToString();
        }

        void dgwGuncelle()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM filmler;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                dt = new DataTable();
                da.Fill(dt);

                
                dgwFilmler.DataSource = dt;

               // dgwFilmler.Invalidate();
              //  dgwFilmler.Refresh();
            }
        }
    }
}
