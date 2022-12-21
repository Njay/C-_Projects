namespace UTS_Kelompok_6
{
    public partial class Form2 : Form
    {
        string nama, telp, alamat, combo1, combo2, a, b;
        double hrg, lama, kembali, c;
        double total = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Silahkan isi form sesuai data calon pemesan.\n" +
                "2. Pastikan semua data yang diinput sudah sesuai.\n" +
                "3. Klik 'Cek' untuk mengecek fasilitas dan harga sewa dari jenis kamar yang dipilih.\n" +
                "4. Klik 'Bayar' jika pemesan sudah membayar.\n" +
                "5. klik 'Cetak' untuk menampilkan tanda bukti pemesanan.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Aplikasi reservasi Hotel Darul Nikmat ini" +
                " dibuat oleh kelompok 6 Pemrograman Komputer 1 kelas 3E Teknik Komputer" +
                " yang ditujukan untuk memenuhi nilai UTS Pemrograman komputer 1.");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtBiaya_TextChanged(object sender, EventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {


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
