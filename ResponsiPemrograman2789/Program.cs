//Program.cs
using System;


namespace Karyawan
{
    class Program
    {

        static void Main(string[] args)
        {
            Karyawan karyawan1= new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2= new Karyawan(190302124, "Jono", 2000000);
            Karyawan karyawan3 = new Karyawan(190302125, "Pujo", -1000000);

            Console.WriteLine(" No\t Nik \t Nama \t Gaji Bulanan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" 1.  {0}\t{1} \t  {2}", karyawan1.nik, karyawan1.nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2.  {0}\t{1} \t  {2}", karyawan2.nik, karyawan2.nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3.  {0}\t{1} \t  {2}", karyawan3.nik, karyawan3.nama, karyawan3.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Asyiikkkk kenaikan gaji 10%");
            Console.WriteLine();

            Console.WriteLine(" No\t Nik \t Nama \t Gaji Bulanan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" 1.  {0}\t{1} \t  {2}", karyawan1.nik, karyawan1.nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2.  {0}\t{1} \t  {2}", karyawan2.nik, karyawan2.nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3.  {0}\t{1} \t  {2}", karyawan3.nik, karyawan3.nama, karyawan3.GajiBulanan);



            //karyawan.ket = "No  nik    nama             gaji bulanan";
            //karyawan.nik1 = "190302123 Paijo\t       3.000000";
            //karyawan.nik2 = "190302124 Jono\t        2.000000";

            //karyawan.KaryawanInfo();
            //new karyawan1

            Console.ReadKey();


        }

    }

}