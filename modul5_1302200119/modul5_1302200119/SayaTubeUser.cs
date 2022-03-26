using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200119
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        private static Random random = new Random();

        public SayaTubeUser(string username)
        {
            const string chars = "0123456789";
            this.id = int.Parse(new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray()));

            this.uploadedVideos = new List<SayaTubeVideo>();
            this.Username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(var video in this.uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo x)
        {
            uploadedVideos.Add(x);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + this.Username);

            int index = 0;
            foreach (var video in this.uploadedVideos)
            {
                Console.WriteLine("Video " + (index+1) + " judul: " + video.getTitle());
                index++;
            }
        }
    }
}
