using MySql.Data.MySqlClient;
using System.Data;

namespace UTS_Kelompok_6
{
    public partial class Form2 : Form
    {
        string nama, telp, alamat, combo1, combo2, a, b;
        double hrg, lama, kembali, c;
        double total = 0;
    
        string database = "server = localhost; database= hotel_db; uid = root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;

        public void konek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
        }
        public void diskonek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }

        public DataTable baca()
        {
            string sql = "select * from pemesan";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            diskonek();
            return dt;
        }


        public Form2()
        {
            InitializeComponent();
        }

        public void Input(string query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Input("insert into pemesan values('" + this.txtKamar.Text + "','" + this.txtNama.Text + "','" + this.txtNomor.Text + "','" + this.txtAlamat.Text + "','" + this.dateTimePicker1.Text + "','"+this.cbJenis.Text+"','"+this.cbLama.Text+"')");
            MessageBox.Show("Insert Data Berhasil");
            baca();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            baca();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {


            string sql = "SELECT * FROM pemesan WHERE no_kamar='" + txtCari.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            diskonek();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            Delete();
            baca();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKamar.Text = "";
            txtNama.Text = "";
            txtNomor.Text = "";
            txtAlamat.Text = "";
            baca();
        }

        public void Update()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();

                string update = "UPDATE pemesan SET no_kamar='" + txtKamar.Text + "',nama ='" + txtNama.Text + "',no_telp = '" + txtNomor.Text + "',alamat = '" + txtAlamat.Text + "', tgl_booking='"+dateTimePicker1.Text+"', jenis_kamar='"+cbJenis.Text+"', lama_menginap= '"+cbLama.Text+"'WHERE no_kamar ='" + txtKamar.Text + "'";
                cmd = new MySqlCommand(update, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update data berhasil");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();

                string delete = "DELETE FROM pemesan WHERE no_kamar='" + txtCari.Text + "'";
                cmd = new MySqlCommand(delete, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            nama = txtNama.Text;
            telp = txtNomor.Text;
            alamat = txtAlamat.Text;
            combo1 = cbJenis.Text;
            combo2 = cbLama.Text;

            lama = Convert.ToInt32(combo2);

            if (combo1.Equals("VVIP"))
            {
                textBox1.Text = "Kamar Mewah, AC, TV dan WIFI";
                hrg = 1500000;
                total = (hrg * lama);
                txtHarga.Text = hrg.ToString();
                txtBiaya.Text = total.ToString();


            }
            if (combo1.Equals("VIP"))
            {
                textBox1.Text = "Kamar Mewah, AC dan WIFI ";
                hrg = 1300000;
                total = (hrg * lama);
                txtHarga.Text = hrg.ToString();
                txtBiaya.Text = total.ToString();


            }
            if (combo1.Equals("STANDART"))
            {
                textBox1.Text = "Kamar Biasa Dan AC";
                hrg = 1000000;
                total = (hrg * lama);
                txtHarga.Text = hrg.ToString();
                txtBiaya.Text = total.ToString();


            }
            if (combo1.Equals("HEMAT"))
            {
                textBox1.Text = "Kamar Biasa dan Kipas Angin ";
                hrg = 800000;
                total = (hrg * lama);
                txtHarga.Text = hrg.ToString();
                txtBiaya.Text = total.ToString();


            }
            if (combo1.Equals("KANKER"))
            {
                textBox1.Text = "Tikar dan Kipas Tangan ";
                hrg = 50000;
                total = (hrg * lama);
                txtHarga.Text = hrg.ToString();
                txtBiaya.Text = total.ToString();


            }
            if (combo1.Equals("") && combo2.Equals(""))
            {
                MessageBox.Show("Mohon Lengkapi Form!");
            }

        }

      

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Silahkan isi form sesuai data calon pemesan.\n" +
                "2. Pastikan semua data yang diinput sudah sesuai.\n" +
                "3. Klik 'Cek' untuk mengecek fasilitas dan harga sewa dari jenis kamar yang dipilih.\n" +
                "4. Klik 'Bayar' jika pemesan sudah membayar.\n" +
                "5. Klik 'Input' untuk menambahkan data pemesan baru. \n"+
                "6. Klik 'Update' untk memperbaharui data pemesan yang sudah ada. \n"+
                "7. Klik 'Cari' untuk menampilkan data terkait yang dicari menggunakan kode nomor kamar. \n"+
                "8. Klik 'Hapus' untuk menghapus data pemesan dari database. \n"+
                "9. klik 'Cetak' untuk menampilkan tanda bukti pemesanan.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Aplikasi reservasi Hotel Darul Nikmat v.1.1 ini" +
                " dibuat oleh kelompok 6 Pemrograman Komputer 1 kelas 3E Teknik Komputer" +
                " yang ditujukan untuk memenuhi nilai UAS Pemrograman komputer 1.");
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtKamar.Text = "";
            txtAlamat.Text = "";
            txtBiaya.Text = "";
            txtHarga.Text = "";
            txtJumlah.Text = "";
            txtNama.Text = "";
            txtNomor.Text = "";
            textBox1.Text = "";
            txtJumlah.Text = "";
            txtKembali.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login(); l.Close();
            this.Close();
        }



        private void btClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("========== HOTEL DARUL NIKMAT ==============\n" +
                            "Nama Pemesan : " + nama+"\n" +
                            "Nomor HP     : " + telp+"\n" +
                            "Alamat       : " + alamat+"\n" +
                            "Jenis Kamar  : " +combo1+"\n"+
                            "Lama Menginap : " + combo2 +" hari "+ "\n" +
                            "Total Biaya  : RP." + total + "\n" +
                            "=========================================\n"+
                            "Bayar        : Rp." + a + "\n" +
                            "Kembalian    : Rp." + kembali + "\n"+"\n"+"\n"+
                            "Terima Kasih telah memesan di Hotel Kami\n"+
                            "            - Enjoy your Stay :) -       \n"+
                            "\n"+"\n"+"\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {

            a = txtJumlah.Text;
            b = txtKembali.Text;
            c = Convert.ToDouble(a);

            kembali = c - total;
            txtKembali.Text = kembali.ToString();

            if (c < total) { txtKembali.Text = "Invalid!"; }
        }
    }
}
