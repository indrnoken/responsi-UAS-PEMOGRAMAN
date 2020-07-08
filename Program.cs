using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: TampilMenu();// keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("pilih menu aplikasi");
            Console.WriteLine(" ");
            Console.WriteLine("1.tambah penjualan ");
            Console.WriteLine("2.hapus penjualan");
            Console.WriteLine("3.tampilkan penjualan");
            Console.WriteLine("4.keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            int nota;
            string tanggal, nama;
            char jenis;
            double total;


            Console.WriteLine("nota :");
            nota = int.Parse(Console.ReadLine());
            Console.Write("Tanggal : ");
             tanggal = Console.ReadLine();
            Console.Write("customer : ");
             nama = Console.ReadLine();
            Console.Write("jenis T/K : ");
             jenis =char.Parse (Console.ReadLine());
            Console.Write("total nota :");
            total = double.Parse(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { nota = nota, tanggal = tanggal, nama = nama, jenis = jenis,total = total });
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
