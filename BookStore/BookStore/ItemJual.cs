using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ItemJual
    {
        public string noId { set; get; }
        public int Kuantitas { set; get; }
        public double hargapersatuan { set; get; }
        public double hargatotal;

        public ItemJual(string nomorIdentitasItem,int Kuantitas,double hargapsatuan)
        {
            this.noId = nomorIdentitasItem;
            this.Kuantitas = Kuantitas;
            this.hargapersatuan=hargapsatuan;
            this.hargatotal = this.hargapersatuan*(double) this.Kuantitas;
        }
        public void update(int Kuantitas)
        {
            this.Kuantitas = Kuantitas;
            this.hargatotal = this.hargapersatuan *(double) this.Kuantitas;
        }

    }
}
