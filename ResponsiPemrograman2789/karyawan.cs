using System;
using System.Collections.Generic;
using System.Text;

namespace Karyawan
{
    class Karyawan
    {

        //property
        public int nik { get; set; }
        public string nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NaikGaji { get; set; }

        public Karyawan(int nik, string nama, int gajiBulanan)
        {
            this.nik = nik;
            this.nama = nama;

            if (gajiBulanan < 0)
            {
                this.GajiBulanan = 0;
                NaikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gajiBulanan;
                NaikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }


            //onsole.WriteLine(this.ket);
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("1. " + this.nik1);
            //onsole.WriteLine("2. " + this.nik2);
            //Console.WriteLine();
            //Console.WriteLine();
            //onsole.WriteLine("Asyiikkkk kenaikan gaji 10%");
            //onsole.WriteLine();

            //le.WriteLine(this.ket);
            //onsole.WriteLine("-----------------------------------------------");
            //onsole.WriteLine("1. " + this.nik1);
            //Console.WriteLine("2. " + this.nik2);

        }

    }
}
