using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Buku
    {
        public string noID {set;get;}
        public int stokBuku{set; get;}
        public string judul { set; get; }
        public double harga { set; get; }
        public string namaPenulis { set; get; }
        public string penerbit { set; get; }
        public int tahunTerbit { set; get; }
        public Buku(string id, string judul, double harga, int stok, string namaPenulis, string penerbit,int tahunTerbit)
        {
            this.noID = id;
            this.judul = judul;
            this.stokBuku = stok;
            this.harga = harga;
            this.penerbit = penerbit;
            this.namaPenulis = namaPenulis;
            this.tahunTerbit = tahunTerbit;
        }
        

        public void UpdateInfoBuku(string id,string judul,double harga ,int stok,string namaPenulis, string penerbit, int tahunTerbit)
        {
            this.noID = id;
            this.judul = judul;
            this.harga = Convert.ToDouble(harga); ;
            this.stokBuku = stok; 
            this.penerbit = penerbit;
            this.namaPenulis = namaPenulis;
            this.tahunTerbit = tahunTerbit;
        }

    }
}
