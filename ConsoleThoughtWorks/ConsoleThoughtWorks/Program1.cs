using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleThoughtWorks
{


    public partial class Explorer
    {


        public void NewLogic()
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


    public class Dummy
    {
        public int number1;
        public int? number2;
    }

    partial class Program
    {
        static void Main12(string[] args)
        {
            try

            {

                IEnumerable<Dummy> dummyObj = new List<Dummy>
                {
                    new Dummy(){ number1=1,number2=2},
                    new Dummy()
                };

                var a = dummyObj.DefaultIfEmpty();
                Console.WriteLine($"FIRST >> Number1: {a.First().number1}:: Number2: {a.First().number2}");
                Console.WriteLine($"SECOND >> Number1: {a.Last().number1}:: Number2: {a.Last().number2}");

                ////dummyObj = new List<Dummy>();
                ////aa = dummyObj;
                var aa = dummyObj.DefaultIfEmpty().Where(x => x.number1 > 1);
                var aaaba = dummyObj.Where(x => x.number1 > 1);

                Console.WriteLine($"FIRST >> Number1: {aa.First().number1}:: Number2: {aa.First().number2}");
                Console.WriteLine($"SECOND >> Number1: {aa.Last().number1}:: Number2:{aa.Last().number2}");


                dummyObj = null;
                var aaa = dummyObj.DefaultIfEmpty();


                if (aaa != null)
                {
                    Console.WriteLine("collecton is not null");
                }



                Console.WriteLine($"FIRST >> Number1: {aaa.First().number1}:: Number2: {aaa.First().number2}");
                Console.WriteLine($"SECOND >> Number1: {aaa.Last().number1}:: Number2: {aaa.Last().number2}");

                var alist = new List<Document>
                {
                    new Document() { id = 1, name = "first" },
                    new Document() { id = 2, name = "second" },
                    new Document() { id = 3, name = "third" }
                };


                var aaaa = alist.OrderBy(x => x.getValue());
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
                    ex.NewLogic();
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
