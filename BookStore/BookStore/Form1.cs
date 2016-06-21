using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        private List<Buku> DaftarBuku = new List<Buku>();
        private List<ItemJual> DaftarJual = new List<ItemJual>();
        public Form1()
        {
            InitializeComponent();
            //Semua tombol tak bisa ditekan, mwahahaha... jika anda tak memasukkan apapun...
            //bttnHapusJual.Enabled = false;
            //bttnHapusDataDftrBk.Enabled = false;
            //bttnLakukanPenjualan.Enabled = false;
            //bttnTambahDataDftrBk.Enabled = false;
            //bttnUpdateDataDftrBk.Enabled = false;
            //Deklarasi Array baru
            

            //Array.Resize(ref DaftarBuku, DaftarBuku.Length + 1);
            //DaftarBuku[DaftarBuku.GetUpperBound(0)] = new Buku("TUL15", "Buku Tulis Kosong", 2500, 100, "", "PT. WhitePapers", 2015);
            
            //Array.Resize(ref DaftarBuku, DaftarBuku.Length + 1);
            //DaftarBuku[DaftarBuku.GetUpperBound(0)] = new Buku("TULKTK15", "Buku Tulis Kotak Kosong", 2500, 100, "", "PT. WhitePapers", 2015);
            
            //Array.Resize(ref DaftarBuku, DaftarBuku.Length + 1);
            //DaftarBuku[DaftarBuku.GetUpperBound(0)] = new Buku("BKNRWN-LOST", "Buku Nirwana yang Hilang", 10000, 1, "Nirwana","Tidak Diketahui", 2015);
            DaftarBuku.Add(new Buku("TUL15", "Buku Tulis Kosong", 2500, 100, "", "PT. WhitePapers", 2015));
            DaftarBuku.Add(new Buku("TULKTK15", "Buku Tulis Kotak Kosong", 2500, 100, "", "PT. WhitePapers", 2015));
            DaftarBuku.Add(new Buku("BKNRWN-LOST", "Buku Nirwana yang Hilang", 10000, 1, "Nirwana", "Tidak Diketahui", 2015));
            DaftarBuku.Add(new Buku("TEST-NS", "Buku Habis Stok", 10000, 0,"", "", 2000));
            
            LVdaftarJual.View = View.Details;
            //Inisialisasi Kolom LVdaftarJual
            LVdaftarJual.Columns.Add("No", 30, HorizontalAlignment.Left);
            LVdaftarJual.Columns.Add("Kode",95,HorizontalAlignment.Left);
            LVdaftarJual.Columns.Add("Judul Buku", 170, HorizontalAlignment.Center);
            LVdaftarJual.Columns.Add("Harga/Satuan", 90, HorizontalAlignment.Center);
            LVdaftarJual.Columns.Add("Stok", 50, HorizontalAlignment.Left);
            LVdaftarJual.Columns.Add("Jumlah", 50, HorizontalAlignment.Left);
            LVdaftarJual.Columns.Add("Harga Total ", 100, HorizontalAlignment.Left);

            //Inisialisasi Kolom LVdaftarBuku
            LVdaftarBuku.View = View.Details;
            LVdaftarBuku.Columns.Add("No", 30, HorizontalAlignment.Right);
            LVdaftarBuku.Columns.Add("Kode Buku", 95, HorizontalAlignment.Left);
            LVdaftarBuku.Columns.Add("Judul", 170, HorizontalAlignment.Left);
            LVdaftarBuku.Columns.Add("Harga", 60, HorizontalAlignment.Right);
            LVdaftarBuku.Columns.Add("Stok", 50, HorizontalAlignment.Left);
            LVdaftarBuku.Columns.Add("Penulis", 120, HorizontalAlignment.Left);
            LVdaftarBuku.Columns.Add("Penerbit", 120, HorizontalAlignment.Left);
            LVdaftarBuku.Columns.Add("Tahun Terbit", 75, HorizontalAlignment.Center);
            for(int k=0;k<DaftarBuku.Count;k++)
            {
                LVdaftarBuku.Items.Add(Convert.ToString(k));
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].noID);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].judul);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].harga.ToString());
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].stokBuku.ToString());
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].namaPenulis);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].penerbit);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].tahunTerbit.ToString());
                         
            }
            
            //LVdaftarJual.Items[LVdaftarJual.Items.Count-1].Remove();
        }
     
        
        public void relistDftrBk(){
            LVdaftarBuku.Items.Clear();
            for (int k = 0; k < DaftarBuku.Count; k++)
            {
                LVdaftarBuku.Items.Add(Convert.ToString(k));
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].noID);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].judul);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].harga.ToString());
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].stokBuku.ToString());
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].namaPenulis);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].penerbit);
                LVdaftarBuku.Items[k].SubItems.Add(DaftarBuku[k].tahunTerbit.ToString());
            }
        }

        public void relistDftrJl()
        {
            LVdaftarJual.Items.Clear();
            for (int k = 0; k < DaftarJual.Count; k++)
            {
                LVdaftarJual.Items.Add(Convert.ToString(k));
                LVdaftarJual.Items[k].SubItems.Add(DaftarBuku[k].noID);
                LVdaftarJual.Items[k].SubItems.Add(DaftarBuku[k].judul);
                LVdaftarJual.Items[k].SubItems.Add(DaftarBuku[k].harga.ToString());
                LVdaftarJual.Items[k].SubItems.Add(DaftarBuku[k].stokBuku.ToString());
                LVdaftarJual.Items[k].SubItems.Add(DaftarJual[k].Kuantitas.ToString());
                LVdaftarJual.Items[k].SubItems.Add(DaftarJual[k].hargatotal.ToString());
            }
            double hargatotal = 0;
            for (int k = 0; k < DaftarJual.Count; k++)
            {
                hargatotal += DaftarJual[k].hargatotal;
            }
            lblTotalHargaJual.Text = hargatotal.ToString();
        }
        public void cleanupParameterDaftarBuku() 
        {
            txtKodeBarangBaru.Text = "";
            txtJudulBaru.Text = "";
            txtbPenulisBaru.Text = "";
            txtbPenerbitBaru.Text = "";
            txtbKodeBarangYgBerubah.Text = "";
            nudHargaBaru.Value = 0;
            nudStokBaru.Value = 0;
            nudTahunTerbitBaru.Value = 0;
        }
        private void txtbKodeBukuJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                //Jika tidak ada buku yg sesuai, keluarkan pesan buku tidak terdaftar
                //Bila buku kosong
                //Tambah Buku ke dalam List Jual
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbKodeBarangYgBerubah_TextChanged(object sender, EventArgs e)
        {
            /*
            if(txtbKodeBarangYgBerubah.Text!="")
            {
                bttnHapusDataDftrBk.Enabled = true;
                bttnUpdateDataDftrBk.Enabled = true;
            }
            if(txtbKodeBarangYgBerubah.Text=="")
            {
                bttnHapusDataDftrBk.Enabled = false;
                bttnUpdateDataDftrBk.Enabled = false;
            }
            */
            //Ini adalah kode yg memakan banyak sumber daya komputer
            //Lagipula, kode ini tidak akan berjalan
            /*
            for (int i = 0; i < DaftarBuku.Count; i++)
            {
                if (DaftarBuku[i].noID == txtbKodeBarangYgBerubah.Text)
                {
                    
                    nudStokBaru.Value = (decimal)DaftarBuku[i].stokBuku;
                    nudHargaBaru.Value = (decimal)DaftarBuku[i].harga;
                    txtKodeBarangBaru.Text = DaftarBuku[i].noID;
                    txtJudulBaru.Text = DaftarBuku[i].judul;
                    txtbPenulisBaru.Text = DaftarBuku[i].namaPenulis;
                    txtbPenerbitBaru.Text = DaftarBuku[i].penerbit;
                    nudTahunTerbitBaru.Value = (decimal)DaftarBuku[i].tahunTerbit;
                    
                }
            }
            */
            
            
        }

        private void bttnHapusDataDftrBk_Click(object sender, EventArgs e)
        {
            bool errortdkadaid = true;
            for(int i=0;i<DaftarBuku.Count;i++)
            {
                if (txtbKodeBarangYgBerubah.Text == DaftarBuku[i].noID)
                {
                    DaftarBuku.RemoveAt(i);
                    errortdkadaid = false;
                    break;
                }
            }
            if (errortdkadaid == true)
            {
                string error = "Tidak ada buku dengan Kode " + txtbKodeBarangYgBerubah.Text;
                MessageBox.Show(error, "Error");
            }
            else { 
                relistDftrBk();
            }
        }

        private void bttnTambahDataDftrBk_Click(object sender, EventArgs e)
        {
            bool erroridsama = false;
            string noidnew = txtKodeBarangBaru.Text;
            //Kode Buku tidak boleh ada spasi, maupun huruf kecil
            do
            {
                for (int chrindex = 0; chrindex < noidnew.Length; chrindex++)
                {
                    if (char.IsWhiteSpace(noidnew[chrindex]) == true)
                    {
                        noidnew = noidnew.Remove(chrindex, 1);
                    }
                }
            } while (noidnew.Contains(" "));
            noidnew = noidnew.ToUpper();
            //Cek buku dengan ID yg sama di DaftarBuku
            foreach (Buku i in DaftarBuku)
            {
                if (noidnew == i.noID) {
                    erroridsama = true;
                    break;
                }
            }
            if (erroridsama == false) 
            {
                
                
                //Variabel untuk menampung parameter-parameter buku baru
                string jdlnew = txtJudulBaru.Text;
                double hrgnew = Convert.ToDouble(nudHargaBaru.Value);
                int stknew = Convert.ToInt32(nudStokBaru.Value);
                string pnlsnew = txtbPenulisBaru.Text;
                string pnrbtnew = txtbPenerbitBaru.Text;
                int thntrbtnew = Convert.ToInt32(nudTahunTerbitBaru.Value);
                DaftarBuku.Add(new Buku(noidnew, jdlnew, hrgnew, stknew, pnlsnew, pnrbtnew, thntrbtnew));
                relistDftrBk();
            }
            else {
                MessageBox.Show("Sudah ada Buku dengan Kode yang sama!", "Error");
            }
        }

        private void bttnUpdateDataDftrBk_Click(object sender, EventArgs e)
        {
            //Error Check Stage 1
            string noidnew = "";
           
            bool errortdkadaid = true;
            int index=0;
            for (int i = 0; i < DaftarBuku.Count; i++)
            {
                if (txtbKodeBarangYgBerubah.Text == DaftarBuku[i].noID) { 
                    errortdkadaid = false;
                    index=i;
                    break;
                }
            }
            //Error Check Stage 1 - Tidak ada ID yang ingin diubah dalam DaftarBuku
            if (errortdkadaid == true)
            {
                string error = "Tidak ada buku dengan Kode " + txtbKodeBarangYgBerubah.Text;
                MessageBox.Show(error, "Error");
            }
            else
            {   
                
                noidnew = txtKodeBarangBaru.Text;
                //--Transformasi Kode Buku menjadi bentuk formal--
                //Kode Buku tidak boleh ada spasi, maupun huruf kecil
                do
                {
                    for(int chrindex=0;chrindex<noidnew.Length;chrindex++)
                    {
                        if (char.IsWhiteSpace(noidnew[chrindex]) == true)
                        {
                            noidnew=noidnew.Remove(chrindex,1);
                        }
                    }
                }while(noidnew.Contains(" "));
                noidnew=noidnew.ToUpper();
                //--Transformasi Kode Buku Selesai

                //Error Check Stage 2 - Adanya Buku di DaftarBuku dengan kode yang sama dengan kode baru yang ingin diubah 

                bool errorkodesama = false;
                for (int i = 0; i < DaftarBuku.Count; i++)
                {
                    if (noidnew == DaftarBuku[i].noID)
                    {
                        errorkodesama = true;
                        if (noidnew == txtbKodeBarangYgBerubah.Text)
                        {
                            errorkodesama = false;
                        }
                        break;
                    }
                }
                if (errorkodesama == false)
                {
                    double hrgnew = 0;
                    int stknew = 0, thntrbtnew = 0;
                    string pnlsnew = "", pnrbtnew = "", jdlnew = "";

                    jdlnew = txtJudulBaru.Text;
                    hrgnew = Convert.ToDouble(nudHargaBaru.Value);
                    stknew = Convert.ToInt32(nudStokBaru.Value);
                    pnlsnew = txtbPenulisBaru.Text;
                    pnrbtnew = txtbPenerbitBaru.Text;
                    thntrbtnew = Convert.ToInt32(nudTahunTerbitBaru.Value);

                    for (int i = 0; i < DaftarBuku.Count; i++)
                    {
                        if (txtbKodeBarangYgBerubah.Text == DaftarBuku[i].noID)
                        {
                            DaftarBuku[i].UpdateInfoBuku(noidnew, jdlnew, hrgnew, stknew, pnlsnew, pnrbtnew, thntrbtnew);
                            break;
                        }
                    }
                    cleanupParameterDaftarBuku();
                    relistDftrBk();
                    
                }
                else
                {
                    string errormsg="Sudah ada buku dengan kode " + txtKodeBarangBaru.Text +" di Daftar Buku";
                    MessageBox.Show(errormsg, "Error");
                }
            }
        }

        private void LVdaftarBuku_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void nudStokBaru_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bttnTambahJual_Click(object sender, EventArgs e)
        {
            bool errortdkadaid = true;
            int stokkurang=0;
            bool tdkadastok = false;
            string errormsg="";
            for (int i = 0; i < DaftarBuku.Count; i++)
            {
                if (txtbKodeBukuJual.Text == DaftarBuku[i].noID)
                {
                    errortdkadaid = false;
                    if(Convert.ToInt32(nudKuantitasJual.Value)>DaftarBuku[i].stokBuku){
                        stokkurang=Convert.ToInt32(nudKuantitasJual.Value)-DaftarBuku[i].stokBuku;
                    }
                    if (DaftarBuku[i].stokBuku == 0)
                    {
                        tdkadastok = true;
                    }
                    break;
                }
            }
            
            
            if (errortdkadaid == true)
            {
                errorProvider1.Clear();
                errormsg = "Buku dengan Kode \' " + txtbKodeBukuJual.Text + " \' Tidak terdaftar";
                MessageBox.Show(errormsg, "Error");
            }
            else
            {
                if (nudKuantitasJual.Value == 0)
                {
                    errorProvider1.SetError(nudKuantitasJual, "Masukkan jumlah buku yang akan dibeli");
                }
                else
                {
                    bool errorpemesananberulang = false;
                    for (int i = 0; i < DaftarJual.Count; i++)
                    {
                        if (txtbKodeBukuJual.Text == DaftarJual[i].noId)
                        {
                            errorpemesananberulang = true;
                            break;
                        }
                    }
                    if (errorpemesananberulang == true)
                    {

                        errormsg = "Buku dengan Kode \' " + txtbKodeBukuJual.Text + " \' Sudah ada dalam daftar jual";
                        MessageBox.Show(errormsg, "Error");
                    }
                    else
                    {
                        if (tdkadastok == true)
                        {
                            MessageBox.Show("Tidak tersedia stok untuk buku tersebut", "Error");
                        }
                        else
                        {
                            if (stokkurang > 0)
                            {
                                errormsg = "Stok tidak mencukupi, kekurangan sebanyak " + stokkurang.ToString() + " buah buku";
                                MessageBox.Show(errormsg, "Error");
                            }
                            else
                            {
                                double hargapsatuan = 0;
                                for (int i = 0; i < DaftarBuku.Count; i++)
                                {
                                    if (txtbKodeBukuJual.Text == DaftarBuku[i].noID)
                                    {
                                        hargapsatuan = DaftarBuku[i].harga;
                                    }
                                }

                                DaftarJual.Add(new ItemJual(txtbKodeBukuJual.Text, Convert.ToInt32(nudKuantitasJual.Value), hargapsatuan));
                            }
                        }
                    }
                }
                
                relistDftrJl();
            }
            
        }

        private void bttnResetJual_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            DaftarJual.Clear();
            relistDftrJl();
        }

        private void bttnLakukanPenjualan_Click(object sender, EventArgs e)
        {
            int i,j;
            for (i = 0; i < DaftarJual.Count; i++)
            {
                for(j=0;j< DaftarBuku.Count();j++)
                {
                    if(DaftarJual[i].noId==DaftarBuku[j].noID)
                    {
                        DaftarBuku[j].stokBuku -= DaftarJual[i].Kuantitas;
                    }
                }
            }
            txtbKodeBukuJual.Text = "";
            nudKuantitasJual.Value = 0;
            errorProvider1.Clear();
            DaftarJual.Clear();
            relistDftrJl();
            relistDftrBk();
        }
    }
}
