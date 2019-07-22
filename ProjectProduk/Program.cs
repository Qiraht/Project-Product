using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

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
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Produk prod = new Produk();
            // TODO: tuliskan logika Anda di sini ...
            Console.Write("Kode Produk: ");
            prod.Kode = Console.ReadLine();
            Console.Write("Nama Produk: ");
            prod.Nama = Console.ReadLine();
            Console.Write("Harga Beli: ");
            prod.Beli = Console.ReadLine();
            Console.Write("Harga Jual: ");
            prod.Jual = Console.ReadLine();
            Console.WriteLine();
            daftarProduk.Add(prod);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Produk pdk = new Produk();

            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            string cek;
            Console.WriteLine("Hapus Produk");
            Console.WriteLine();
            Console.Write("Kode Produk: ");
            cek = Console.ReadLine();
            var hapus = daftarProduk.SingleOrDefault(f => f.Kode == cek);
            if (hapus == null)
            {
                Console.WriteLine();
                Console.WriteLine("Kode Produk tidak ditemukan");
            }
            else
            {
                daftarProduk.Remove(hapus);
                Console.WriteLine("Data Produk berhasil dihapus");

            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            int i = 1;
            Console.WriteLine("Data Produk");
            Console.WriteLine();
            foreach (Produk prod in daftarProduk)
            {
                Console.Write("{0}. {1}", i, prod.Kode);
                Console.Write(", {0}, {1}", prod.Nama, prod.Beli);
                Console.Write(", {0}", prod.Jual);
                Console.WriteLine();
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");

            Console.ReadKey();
        }
    }
}