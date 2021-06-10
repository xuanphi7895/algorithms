using System;
using System.Text;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập dãy số từ bàn phím!");
            int _daySo = int.Parse(Console.ReadLine());
            
            int[] array =  new int[10];
            // Nhập Dãy Số
             Console.WriteLine("Dãy số được nhập với số lượng phần tử là : {0}", _daySo);
            NhapDaySo(array, _daySo);
            // Xuất dãy số
             Console.WriteLine("Dãy số được nhập");
            XuatDaySo(array, _daySo);
           
            // Selection Sort
             Console.WriteLine("Dãy số được sắp xếp!");
            SapXep(array, _daySo);
            //XuatDaySo(array, _daySo);
            Console.ReadKey();
            //bool _result = SapXep(_daySo);


        }
        static void NhapDaySo(int[] a, int n)
        {
            for (int i = 0; i < n ; i ++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatDaySo(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write( " a[" + i + "]= " +  a[i] + " ");
            }
            Console.WriteLine(" ");
        }
       static void SapXep(int[] a, int n)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[min] > a[j])
                        {
                            min = j;
                        }
                       
                    }
                    if (min != i)
                    {
                        int x = a[min];
                        a[min] = a[i];
                        a[i] = x;
                   }
                   Console.Write( " a[" + i + "]= " +  a[i] + " ");
                }
            }
            catch (System.Exception)
            {
                
                throw;
                
            }
        }
    }
    
}
