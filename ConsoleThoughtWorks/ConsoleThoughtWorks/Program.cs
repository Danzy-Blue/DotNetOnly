using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleThoughtWorks
{
    public class File
    {
        public int Size;
        public int? DownloadTime;

        public File(int size, int? time)
        {
            this.Size = size;
            this.DownloadTime = time;
        }
    }

    public partial class Explorer
    {
        double speed;
        Dictionary<int, File> files;
        public Explorer(int speed, Dictionary<int, File> files)
        {
            this.speed = speed;
            this.files = files;
        }

        public int GetTotaltime()
        {

            return files.Sum(x => x.Value.DownloadTime.GetValueOrDefault());
        }

        public void Logic()
        {
            foreach (var file in files.OrderBy(x => x.Value.Size))
            {
                if (file.Value.Size > 0)
                {
                    int avgSpeed = Convert.ToInt32(Math.Floor(speed / files.Where(x => x.Value.Size > 0).Count()));
                    double size = file.Value.Size;
                    var time = Convert.ToInt32(Math.Ceiling(size / avgSpeed));
                    file.Value.DownloadTime = time;

                    foreach (var f in files)
                    {
                        if (f.Value.Size > 0)
                        {
                            ////f.Value.Size = f.Value.Size - time * avgSpeed;
                            f.Value.Size = f.Value.Size - (int)size;
                        }
                    }
                }
            }
        }
    }

    partial class Program
    {
        static void Main2(string[] args)
        {
            List<Explorer> explorers = new List<Explorer>();
            var t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var second = Console.ReadLine().Split(' ');
                var n = Convert.ToInt32(second.First());
                var s = Convert.ToInt32(second.Last());

                var sizeArray = Console.ReadLine().Split(' ');

                Dictionary<int, File> file = new Dictionary<int, File>();
                for (int f = 0; f < n; f++)
                {
                    file.Add(f, new File(Convert.ToInt32(sizeArray[f]), null));
                }

                explorers.Add(new Explorer(s, file));
            }

            foreach (var ex in explorers)
            {
                ex.Logic();
                Console.WriteLine(ex.GetTotaltime());
            }

            Console.ReadLine();
        }
    }
}




