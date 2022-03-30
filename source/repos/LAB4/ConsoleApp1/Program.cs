using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        int d, g, h;
        public bool nhap(String a,String b,String c)
        {            
            if(int.TryParse(a,out d))
            {
                if (int.TryParse(b, out g))
                {
                    if (int.TryParse(c, out h))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Nhap sai");
                    }
                }
                else
                {
                    Console.WriteLine("Nhap sai");
                }
            }
            else
            {
                Console.WriteLine("Nhap sai");                
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.nhap("1","2","3"));
            Console.ReadKey();
        }
    }
}
