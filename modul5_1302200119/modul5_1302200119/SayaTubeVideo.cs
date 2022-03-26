using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200119
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        private static Random random = new Random();

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 200 && title != null, "panjak karakter melebihi dari 200 atau null");
            this.title = title;

            const string chars = "0123456789";
            this.id = int.Parse(new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray()));

            this.playCount = 0;
        }

        public void IncreasePlayCount(int x)
        {
            Debug.Assert(x <= 25000000 && x >= 0, "masukkan angka yang lebih kecil! dan tidak negatif");
            try
            {
                this.playCount = checked(this.playCount + x);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\nTerjadi error Overflow: " + e.Message);
                Console.WriteLine("playCount tidak akan bertambah");
                //this.playCount++;
            }

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID\t: " + this.id + "\nJudul\t: " + this.title
                + "\nJumlah diputar: " + this.playCount);
        }

        public string getTitle()
        {
            return this.title;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }
    }
}
