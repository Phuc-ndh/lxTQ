using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NguyenDinhHoangPhuc_19522036
{
    class Program
    {
        static void PrintList(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var d in dir.GetDirectories())
            {
                Console.WriteLine(d.Name);
            }
            foreach (var f in dir.GetFiles())
            {
                Console.WriteLine(f.Name);
            }
        }
        static void Create(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (!File.Exists(path))
            {
                fi.Create();
                Console.WriteLine("File da duoc tao");
            }
            else
                Console.WriteLine("File da ton tai");
        }
        static void CreateDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Da tao thanh cong");
            }
            else
                Console.WriteLine("Da ton tai");
        }
        static void Delete(string path)
        {
            FileInfo fi = new FileInfo(path); 
            if (fi.Exists)
            {
                fi.Delete();
                Console.WriteLine("Da xoa thanh cong");
            }
            else
                Console.WriteLine("Xoa that bai");
        }
        static void DeleteDir(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                di.Delete(true);
                Console.WriteLine("Da xoa thanh cong");
            }
            else
                Console.WriteLine("Xoa that bai");
        }
        static void Main(string[] args)
         {
            //Console.OutputEncoding = Encoding.UTF8;
            if (args.Length == 0)
                Console.WriteLine("Chua nhap lenh");
            else
            {
                string str;
                if (args[0] == "ls")
                {
                    if (args.Length < 2)
                        PrintList(Directory.GetCurrentDirectory());
                    else
                    {
                         str = args[1];
                        for (int i = 2; i < args.Length; i++)
                            str = str + " " + args[i];
                        PrintList(str);
                    }
                }
                else if (args[0] == "create")
                {
                    if (args.Length < 2)
                        Console.WriteLine("Lenh da nhap khong hop le");
                    else
                    {
                        str = args[1];
                        for (int i = 2; i < args.Length; i++)
                            str = str + " " + args[i];
                        Create(str);
                    }
                }
                else if (args[0] == "createdir")
                {
                    if (args.Length < 2)
                        Console.WriteLine("Lenh da nhap khong hop le");
                    else
                    {
                        str = args[1];
                        for (int i = 2; i < args.Length; i++)
                            str = str + " " + args[i];
                        CreateDir(str);
                    }
                }
                else if (args[0] == "del")
                {
                    if (args.Length < 2)
                        Console.WriteLine("Lenh da nhap khong hop le");
                    else
                    {
                        str = args[1];
                        for (int i = 2; i < args.Length; i++)
                            str = str + " " + args[i];
                        Delete(str);
                    }
                }
                else if (args[0] == "rmdir")
                {
                    if (args.Length < 2)
                        Console.WriteLine("Lenh da nhap khong hop le");
                    else
                    {
                        str = args[1];
                        for (int i = 2; i < args.Length; i++)
                            str = str + " " + args[i];
                        DeleteDir(str);
                    }
                }

            }
        }
    }
}
