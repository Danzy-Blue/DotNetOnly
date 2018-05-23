using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    public class Explorer
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


    public class Document
    {
        public int id;
        public string name;

        public string getValue()
        {
            return string.Empty;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            try

            {

                var alist = new List<Document>
                {
                    new Document() { id = 1, name = "first" },
                    new Document() { id = 2, name = "second" },
                    new Document() { id = 3, name = "third" }
                };


                var aaaa= alist.OrderBy(x => x.getValue());
                var bbb = aaaa.ToArray();

                checked
                {
                    int ii = 9090909;
                    int? kk = 8989898;

                    int? j = ii * kk;
                    Console.Write(j);
                }

                List<Explorer> explorers = new List<Explorer>();
                var t = Convert.ToInt32(Console.ReadLine());
                if (0 < t && t <= 1000)
                {
                    Console.Write("");
                }

                for (int i = 0; i < t; i++)
                {
                    var second = Console.ReadLine().Split(' ');
                    var n = Convert.ToInt32(second.First());
                    var s = Convert.ToInt32(second.Last());

                    if (!(0 < n && n <= 10000 && 0 < s && s <= 30000))
                    {
                        Console.Write("");
                    }

                    var sizeArray = Console.ReadLine().Split(' ');
                    if (!(0 < sizeArray.Length && sizeArray.Length < 100000))
                    {
                        Console.Write("");
                    }

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
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("incorrect input");
                }

                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine("Speed input is incorrect");
                }
            }

            Console.ReadLine();
        }
    }
}
