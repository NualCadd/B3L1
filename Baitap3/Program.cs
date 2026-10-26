using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu " + i.ToString() + ":"); mang[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += mang[i];
            }

            Console.WriteLine("Tong cua mang la:" + tong.ToString());
            int maxi = 0, mini = 0;
            for (int i = 0; i < n; i++)
            {
                if (mang[i] > mang[maxi])
                {
                    maxi = i;
                }
                if (mang[i] < mang[mini])
                {
                    mini = i;
                }
            }
            Console.WriteLine("Gia tri lon nhat la:" + mang[maxi].ToString() + " o vi tri " + maxi.ToString());
            Console.WriteLine("Gia tri nho nhat la:" + mang[mini].ToString() + " o vi tri " + mini.ToString());
        }
            
     }
}