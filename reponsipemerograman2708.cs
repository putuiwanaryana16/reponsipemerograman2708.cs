using System;

namespace ResponsiPemrogaman2717
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(1, 19112708, "putu iwan ", 3000000);
            Karyawan karyawan2 = new Karyawan(2, 19112708, "putu iwan", 2000000);

            Console.WriteLine("No NIK \t\tNama \t\tGaji");
            Console.WriteLine("----------------------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n Asyiiiiik Kenaikan gaji 10%!! \n");

            Console.WriteLine("NO NIK \t\tNama \t\tGaji");
            Console.WriteLine("----------------------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int no { get; set; }
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int no, int nik, string nama, int gaji)
        {
            this.no = no;
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0}  {1} \t{2} \t{3}", no, nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}  {1} \t{2} \t{3}", no, nik, nama, gajiBulanan);
        }

    }
}