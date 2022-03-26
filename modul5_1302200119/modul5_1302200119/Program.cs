using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("Saliim");

            SayaTubeVideo vid1 = new SayaTubeVideo("Review Film Ikan 1 oleh Saliim");
            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Ikan 2 oleh Saliim");
            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Singa 1 oleh Saliim");
            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film Singa 2 oleh Saliim");
            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Singa 3 oleh Saliim");
            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Dino 1 oleh Saliim");
            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film Dino 2 oleh Saliim");
            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film Orang 1 oleh Saliim");
            SayaTubeVideo vid9 = new SayaTubeVideo("Review Film Orang 2 oleh Saliim");
            SayaTubeVideo vid10 = new SayaTubeVideo("Review Film Orang 3 oleh Saliim");

            user1.AddVideo(vid1);
            user1.AddVideo(vid2);
            user1.AddVideo(vid3);
            user1.AddVideo(vid4);
            user1.AddVideo(vid5);
            user1.AddVideo(vid6);
            user1.AddVideo(vid7);
            user1.AddVideo(vid8);
            user1.AddVideo(vid9);
            user1.AddVideo(vid10);

            user1.PrintAllVideoPlaycount();

        }
    }
}
