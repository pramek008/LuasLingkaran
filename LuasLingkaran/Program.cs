using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingkaran
{
    /// <summary>
    /// main class : class hitung
    /// </summary>
    /// <remarks>dalam class <c>Hitung</c> ini dapat menghitung Luas dan Keliling Lingkaran.
    /// mulai dari menerima input, menghitung dan kemudian menampilkan</remarks>
    class Hitung
    {
        /// <summary>
        /// inisiasi varibel dengan type double yang nantinya akan menyimpan nilai
        /// <value><c>jari</c> untuk menyimpan panjang jari-jari lingkaran</value>
        /// <value><c>luas</c> untuk menyimpan nilai hitung luas lingkaran</value>
        /// <value><c>keliling</c> untuk menyimpan nilai hitung keliling lingkaran</value>
        /// </summary>
        double jari, luas, keliling;

        /// <summary>
        /// public void inputdata() :      
        ///     method ini digunakan untuk menerima input data yang kemudian data tersebut disimpan ke dalam variable <c>jari</c>
        ///     method bersifat public dan void atau tidak mengembalikan nilai
        /// </summary>
        public void inputdata()
        {
            Console.WriteLine("=== Hitung keliling dan luas Lingkaran ===");
            Console.Write("Masukan panjang jarai-jari= ");
            jari = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// public void hitung():
        ///     method ini digunakan untuk menghitung <c>keliling</c> dan <c>luas</c> lingkaran        
        /// </summary>
        public void hitung()
        {
            luas = 22 / 7 * jari * jari;
            keliling = 3.14 * jari * 2;
        }

        /// <summary>
        /// public void tampil():
        ///     method ini digunakan untuk menampilkan nilai yang berupa:
        ///     <c>jari</c> nilai jari jari yang di input
        ///     <c>luas</c> nilai luas yang sudah di hitung di method hitung()
        ///     <c>keliling</c> nilai keliling yang sudah dihitung di method hitung()
        /// </summary>
        public void tampil()
        {
            Console.WriteLine("");
            Console.WriteLine("Jadi lingkaran dengan jari-jari "+ jari + " memiliki =>");
            Console.WriteLine("luas lingkaran => {0}", luas);
            Console.WriteLine("keliling lingkran => {0}", keliling);
        }

        /// <summary>
        /// class <c>tampilc</c> digunakan untuk memanggil method yang sudah dibuat sebelumnya
        /// </summary>
        class tampilc
        {            
            static void Main(string[] args)
            {
                /// <summary>
                /// menginisiasi class hitung sebagai referensi ke objek
                /// </summary>
                Hitung ll = new Hitung();
                ll.inputdata();
                ll.hitung();
                ll.tampil();

                Console.ReadKey();
            }

        }
    }
}
